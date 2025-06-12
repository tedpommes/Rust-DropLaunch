using Bunifu.UI.WinForms;
using EasyMapTestRust.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace EasyMapTestRust
{
	// 30, 32, 40     main back color
	// 28,27,31       darker panels

	// 178,183,191    white text
	// 122,149,227    blue main accent

	public partial class MainForm : Form
	{

		private bool configLoaded = false;

		private FileSystemWatcher watcher;
		private DateTime lastChange = DateTime.MinValue;
		private readonly TimeSpan debounceTime = TimeSpan.FromMilliseconds(500);

		private string SteamCmdDirPath;
		private string mapDirPath;
		private string ServerFilesDirPath;

		private string UpdatedMapName;

		// Dictionary to store the last logged message by category and content
		private Dictionary<string, DateTime> lastLogByCategory = new Dictionary<string, DateTime>();
		private readonly TimeSpan logDebounceTime = TimeSpan.FromMilliseconds(500);

		// Store the last logged line to avoid duplicates for process output
		private string lastLoggedLine = string.Empty;
		private DateTime lastLoggedTime = DateTime.MinValue;

		public MainForm()
		{
			InitializeComponent();
			InitializeNotification();
			// Enable drag & drop for the form.
			this.AllowDrop = true;
			this.DragEnter += MainForm_DragEnter;
			this.DragDrop += MainForm_DragDrop;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//ResetSettingsToDefault();

			// Attach a global exception handler to log unhandled exceptions.  
			AppDomain.CurrentDomain.UnhandledException += (s, ex) =>
			{
				LogMixed("ERROR: ", $"Unhandled exception: {ex.ExceptionObject}", Color.Red);
			};

			Application.ThreadException += (s, ex) =>
			{
				LogMixed("ERROR: ", $"Thread exception: {ex.Exception.Message}", Color.Red);
			};

			InitializeHelpTabAccordion();


            Booting();


			LogMixed("INFO: ", "Application started.", Color.Blue);
		}

		public void LogMixed(string category, string message, Color mcolor)
		{
			if (ConsoleTextbox.InvokeRequired)
			{
				ConsoleTextbox.Invoke(new Action(() => LogMixed(category, message, mcolor)));
				return;
			}

			ConsoleTextbox.SelectionStart = ConsoleTextbox.TextLength;
			ConsoleTextbox.SelectionLength = 0;
			// Add timestamp in blue
			ConsoleTextbox.SelectionFont = new Font(ConsoleTextbox.Font, FontStyle.Bold);
			ConsoleTextbox.SelectionColor = Color.Black;
			ConsoleTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] ");
			// Add category in bold
			ConsoleTextbox.SelectionColor = mcolor;
			ConsoleTextbox.SelectionFont = new Font(ConsoleTextbox.Font, FontStyle.Bold);
			ConsoleTextbox.AppendText(category);
			// Add message in normal font
			ConsoleTextbox.SelectionColor = Color.Black;
			ConsoleTextbox.SelectionFont = ConsoleTextbox.Font;
			ConsoleTextbox.AppendText(message + Environment.NewLine);
			ConsoleTextbox.ScrollToCaret();
		}

		// Method for debounced logging to prevent duplicate messages
		private void LogMixedDebounced(string category, string message, Color mcolor)
		{
			// Use the debounce dictionary to prevent message spam
			string key = category + message;
			DateTime now = DateTime.Now;

			if (lastLogByCategory.ContainsKey(key))
			{
				// If this message was logged recently, skip it
				if (now - lastLogByCategory[key] < logDebounceTime)
				{
					return;
				}
			}

			// Update the last log time for this key
			lastLogByCategory[key] = now;

			// Call the original method
			LogMixed(category, message, mcolor);
		}

		private string GetSteamCMDPath()
		{
			string appDirectory = Application.StartupPath;

			// Check same directory
			string steamCmdPath = Path.Combine(appDirectory, "steamcmd.exe");
			if (File.Exists(steamCmdPath))
			{
				return steamCmdPath;
			}

			// Check steamcmd folder
			string steamCmdInFolderPath = Path.Combine(appDirectory, "steamcmd", "steamcmd.exe");
			if (File.Exists(steamCmdInFolderPath))
			{
				return steamCmdInFolderPath;
			}

			return null;
		}

        private void InitializeHelpTabAccordion()
        {
            const int collapsedHeight = 40;

            foreach (var pnl in HelpPanelScroll.Controls.OfType<Bunifu.UI.WinForms.BunifuShadowPanel>())
            {
                // Store the original (expanded) height in Tag
                pnl.Tag = pnl.Height;
                pnl.Height = collapsedHeight;

                // Hide all group boxes initially
                foreach (var groupBox in pnl.Controls.OfType<Bunifu.UI.WinForms.BunifuGroupBox>())
                {
                    groupBox.Visible = false;
                }

                // Wire up only the header label
                var header = pnl.Controls
                                .OfType<System.Windows.Forms.Label>()
                                .FirstOrDefault(l => l.Name == "lblHeader");
                if (header != null)
                {
                    header.Cursor = Cursors.Hand;
                    header.Click += HelpPanelHeader_Click;
                }
            }
        }



        private void HelpPanelHeader_Click(object sender, EventArgs e)
        {
            const int collapsedHeight = 40;

            var header = (System.Windows.Forms.Label)sender;
            var clickedPanel = (Bunifu.UI.WinForms.BunifuShadowPanel)header.Parent;

            int expandedHeight = (int)(clickedPanel.Tag ?? collapsedHeight);

            bool isAlreadyExpanded = clickedPanel.Height > collapsedHeight;

            // Collapse all panels and hide their group boxes
            foreach (var pnl in HelpPanelScroll.Controls.OfType<Bunifu.UI.WinForms.BunifuShadowPanel>())
            {
                pnl.Height = collapsedHeight;

                foreach (var groupBox in pnl.Controls.OfType<Bunifu.UI.WinForms.BunifuGroupBox>())
                {
                    groupBox.Visible = false;
                }
            }

            // If already expanded, don't expand again (toggle behavior)
            if (isAlreadyExpanded)
            {
                clickedPanel.Height = collapsedHeight;
                return;
            }

            // Expand clicked panel and show its group boxes
            clickedPanel.Height = expandedHeight;

            foreach (var groupBox in clickedPanel.Controls.OfType<Bunifu.UI.WinForms.BunifuGroupBox>())
            {
                groupBox.Visible = true;
            }
        }


        public void CheckCmdSimple()
		{
			string steamCmdPath = Path.Combine(Properties.Settings.Default.SteamCMDDir, "steamcmd.exe");

			if (File.Exists(steamCmdPath))
			{
				LogMixed("INFO: ", "SteamCMD.exe found in specified directory.", Color.Blue);
				StatusPic.Image = Properties.Resources.icons8_check_64;
			}
			else
			{
				LogMixed("ERROR: ", "SteamCMD.exe not found in specified directory.", Color.Red);
				StatusPic.Image = Properties.Resources.icons8_red_circle_48;
			}
		}

		private string GenerateRandomPassword(int length)
		{
			const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var random = new Random();
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}


		private void UpdateDirectories()
		{
			SteamCmdDirPath = GetSteamCMDPath();
		}



		#region Settings Management

		// Load settings from the application settings
		public void LoadSettings()
		{
			try
			{
				// Check if this is the first run by looking at the FirstRun setting
				if (Properties.Settings.Default.FirstRun == false)
				{
					// Load settings values into UI controls
					ServerFilesDirbox.Text = Properties.Settings.Default.RustFilesDir;
					MapDirBox.Text = Properties.Settings.Default.MapsFilesDir;
					SteamCMDBox.Text = Properties.Settings.Default.SteamCMDDir;

					LogMixed("INFO: ", "Settings loaded successfully.", Color.Blue);
					configLoaded = true;

					// Set up file watcher if enabled
					if (CheckboxFileWatch.Checked && !string.IsNullOrEmpty(Properties.Settings.Default.MapsFilesDir))
					{
						SetupFolderWatcher(Properties.Settings.Default.MapsFilesDir);
					}
				}
				else
				{
					// First run, create default settings
					LogMixed("INFO: ", "First run detected.", Color.Blue);
					CreateDefaultSettings();
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "loading settings");
			}
		}

		// Save current settings to the application settings
		private void SaveSettings(string logMessage = "Settings saved.")
		{
			try
			{
				// Update the settings object with current values
				Properties.Settings.Default.FirstRun = false;
				Properties.Settings.Default.RustFilesDir = ServerFilesDirbox.Text;
				Properties.Settings.Default.MapsFilesDir = MapDirBox.Text;
				Properties.Settings.Default.SteamCMDDir = SteamCMDBox.Text;

				// Save settings to disk
				Properties.Settings.Default.Save();

				LogMixed("FILES: ", logMessage, Color.Goldenrod);
			}
			catch (Exception ex)
			{
				HandleError(ex, "saving settings");
			}
		}

		// Create default settings for first run
		public void CreateDefaultSettings()
		{
			// Set default values
			Properties.Settings.Default.FirstRun = false;
			Properties.Settings.Default.RustFilesDir = Application.StartupPath + "\\Server_Files";
			Properties.Settings.Default.MapsFilesDir = Application.StartupPath + "\\Maps";
			Properties.Settings.Default.SteamCMDDir = Application.StartupPath + "\\SteamCMD";

			//set default checkmark values
			Settings.Default.CheckFileWatcher = true;
			Settings.Default.CheckDesktopNoti = true;
			Settings.Default.CheckNewStart = true;
			Settings.Default.CheckToolTips = false;

			// Save settings to disk
			Properties.Settings.Default.Save();

			LogMixed("FILES: ", "Default settings created.", Color.Goldenrod);

			// Show first run notification
			FirstRunSnackbar();
		}

		private void HistoryDataView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			try
			{
				var row = e.Row;

				string name = row.Cells[0].Value?.ToString() ?? string.Empty;
				string directory = row.Cells[1].Value?.ToString() ?? string.Empty;
				string date = row.Cells[2].Value?.ToString() ?? string.Empty;

				string entryToRemove = $"{directory}\\{name}|{date}";

				// Remove from StringCollection  
				if (RunHistory.Default.HistoryList != null && RunHistory.Default.HistoryList.Contains(entryToRemove))
				{
					RunHistory.Default.HistoryList.Remove(entryToRemove);
					RunHistory.Default.Save();
				}

				LogMixed("INFO: ", "History entry removed and settings synchronized.", Color.Blue);
			}
			catch (Exception ex)
			{
				HandleError(ex, "removing history entry and syncing settings");
			}
		}


		private void LoadRunHistoryToGrid()
		{
			var historyList = RunHistory.Default.HistoryList;

			if (historyList == null || historyList.Count == 0)
				return;

			// Optional: remove this if you want to preserve existing rows
			HistoryDataView.Rows.Clear();

			foreach (string entry in historyList)
			{
				// Prevent duplicates based on the full string value
				bool exists = false;
				foreach (DataGridViewRow row in HistoryDataView.Rows)
				{
					if (row.IsNewRow) continue;

					// Reconstruct the row string to compare
					string rowString = $"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}";
					if (string.Equals(rowString, entry, StringComparison.OrdinalIgnoreCase))
					{
						exists = true;
						break;
					}
				}

				if (!exists)
				{
					var parts = entry.Split('\\');
					if (parts.Length == 3)
						HistoryDataView.Rows.Add(parts[2].Replace(".bat", ""), parts[0] + "\\" + parts[1], DateTime.Now.ToString("dd/MM/yyyy"));
				}
			}
		}

		#endregion

		#region App first run functions

		//This function is called when the program is booting. Check for first run to make the process as simple as possible.
		public void Booting()
		{
			LogMixed("FILES: ", "Loading settings...", Color.Goldenrod);

			// Load settings
			if (Properties.Settings.Default.FirstRun == true)
			{
				LogMixed("INFO: ", "First run or incomplete settings.", Color.Blue);
				//LogMixed("FILES: ", "Creating default settings.", Color.Goldenrod);
				//CreateDefaultSettings();

				FirstRunSnackbar();
				return;
			}
			else if (!configLoaded)
			{
				// Load settings
				ServerFilesDirbox.Text = Properties.Settings.Default.RustFilesDir;
				MapDirBox.Text = Properties.Settings.Default.MapsFilesDir;
				SteamCMDBox.Text = Properties.Settings.Default.SteamCMDDir;
				RustGameDirbox.Text = Properties.Settings.Default.ClientMapsDir;

				//load the checkmark settings and update ui
				CheckboxFileWatch.Checked = Properties.Settings.Default.CheckFileWatcher;
				CheckboxDesktopNoti.Checked = Properties.Settings.Default.CheckDesktopNoti;
				CheckNewStart.Checked = Properties.Settings.Default.CheckNewStart;
				CheckDeleteClientMap.Checked = Properties.Settings.Default.CheckDeleteMap;
				CheckToolTips.Checked = Properties.Settings.Default.CheckToolTips;

				//load the stringcolletion settings and add the history gridview
				LoadRunHistoryToGrid();

				LogMixed("INFO: ", "Settings loaded successfully.", Color.Blue);
				configLoaded = true;

				// Set up file watcher if enabled
				if (CheckboxFileWatch.Checked && !string.IsNullOrEmpty(Properties.Settings.Default.MapsFilesDir))
				{
					SetupFolderWatcher(Properties.Settings.Default.MapsFilesDir);
				}

				// Load maps list
				if (!string.IsNullOrEmpty(Properties.Settings.Default.MapsFilesDir) &&
					Properties.Settings.Default.MapsFilesDir != "X")
				{
					LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);

					if (MapsDataGridView.Rows.Count == 0)
					{
						LogMixed("ERROR: ", "No map files found, update your map directory.", Color.Red);
					}
				}

				CheckCmdSimple();
			}

			ConsoleTextbox.Refresh();
			ConsoleTextbox.Update();
		}

		//used to show a message to the user on first run.
		public void FirstRunSnackbar()
		{
			MainSnackbar.Show(this, "Initial setup required. One-click setup creates all folders in the app directory.", BunifuSnackbar.MessageTypes.Warning, 20000, "Run One-Click Setup",
			  BunifuSnackbar.Positions.TopCenter).Then((result) =>
			  {
				  if (result == BunifuSnackbar.SnackbarResult.ActionClicked)
				  {
                      RadioCarbon.Checked = true;
					  RadioUmod.Checked = false;

                      string path = Directory.GetCurrentDirectory();

					  DropDownBranches.SelectedIndex = 0;
					  SettingsBranchDropdown.SelectedIndex = 0;

					  SetupServerTextbox.Text = Properties.Settings.Default.RustFilesDir;
					  SetupMapsDirectory.Text = Properties.Settings.Default.MapsFilesDir;
					  SetupCMDdir.Text = Properties.Settings.Default.SteamCMDDir;

					  if (SetupServerTextbox.Text == "" ||
						  SetupMapsDirectory.Text == "" ||
						  SetupCMDdir.Text == "")
					  {
						  Properties.Settings.Default.RustFilesDir = path + "\\Server_Files";
						  Properties.Settings.Default.MapsFilesDir = path + "\\Maps";
						  Properties.Settings.Default.SteamCMDDir = path + "\\SteamCMD";
						  Properties.Settings.Default.Save();

						  SetupServerTextbox.Text = Properties.Settings.Default.RustFilesDir;
						  SetupMapsDirectory.Text = Properties.Settings.Default.MapsFilesDir;
						  SetupCMDdir.Text = Properties.Settings.Default.SteamCMDDir;
					  }
					  else
					  {
						  //go to setup page
						  MainPages.SetPage(2);
					  }

					  //go to main page
					  MainPages.SetPage(2);


                      //call SetupDirNextButton_Click to start the setup process
					    SetupDirNextButton_Click(this, EventArgs.Empty);




                  }

              });
		}

		//used to select a directory for the server files, maps and steamcmd.
		private void SelectDirectory(BunifuTextBox targetTextBox)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				folderDialog.Description = "Select a folder";
				folderDialog.ShowNewFolderButton = true;

				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					targetTextBox.Text = folderDialog.SelectedPath;
				}
			}
		}
		#endregion

		#region Buttons
		private void SetupCMDNextButton_Click(object sender, EventArgs e)
		{
			MainPages.SetPage(4);
		}

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			// Load settings values into UI controls
			ServerFilesDirbox.Text = Properties.Settings.Default.RustFilesDir;
			MapDirBox.Text = Properties.Settings.Default.MapsFilesDir;
			SteamCMDBox.Text = Properties.Settings.Default.SteamCMDDir;

			SettingsBranchDropdown.SelectedIndex = 0;

			//go to settings page
			MainPages.SetPage(1);
		}

		public void UpdateSettings()
		{
			bool settingsChanged = false;

			//check if server files directory are set, if so update settings
			if (ServerFilesDirbox.Text != "" && ServerFilesDirbox.Text != Properties.Settings.Default.RustFilesDir)
			{
				Properties.Settings.Default.RustFilesDir = ServerFilesDirbox.Text;
				settingsChanged = true;

			}

			if (MapDirBox.Text != "" && MapDirBox.Text != Properties.Settings.Default.MapsFilesDir)
			{
				Properties.Settings.Default.MapsFilesDir = MapDirBox.Text;
				settingsChanged = true;

			}

			if (SteamCMDBox.Text != "" && SteamCMDBox.Text != Properties.Settings.Default.SteamCMDDir)
			{
				Properties.Settings.Default.SteamCMDDir = SteamCMDBox.Text;
				settingsChanged = true;

			}

			if (RustGameDirbox.Text != "" && RustGameDirbox.Text != Properties.Settings.Default.ClientMapsDir)
			{
				Properties.Settings.Default.ClientMapsDir = RustGameDirbox.Text;
				settingsChanged = true;

			}

			if (settingsChanged)
			{
				Properties.Settings.Default.FirstRun = false;
				// Save changes
				Properties.Settings.Default.Save();
				LogMixed("FILES: ", "Settings updated.", Color.Goldenrod);
			}
		}

		private void SettingsBackButton_Click(object sender, EventArgs e)
		{
			UpdateSettings();

			if (CheckboxFileWatch.Checked && !string.IsNullOrEmpty(Properties.Settings.Default.MapsFilesDir))
			{
				SetupFolderWatcher(Properties.Settings.Default.MapsFilesDir);
			}

			LoadMapFilesToDataGridView(MapDirBox.Text, MapsDataGridView);

			CheckCmdSimple();

			//go to main page
			MainPages.SetPage(0);

			ConsoleTextbox.Update();
			ConsoleTextbox.Refresh();
		}

		private void SetupDirBackButton_Click(object sender, EventArgs e)
		{

			DropDownBranches.SelectedIndex = 0;

			LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);

			//go to main page
			MainPages.SetPage(1);
		}

		private void SetupServerTextbox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(SetupServerTextbox);
		}

		private void MapDirBox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(MapDirBox);
			UpdateSettings();
		}

		private void startServerWithMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MapsDataGridView.SelectedRows.Count > 0)
			{
				string directory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
				// use directory value
				MessageBox.Show(directory);
			}
		}

		private void SteamCMDBox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(SteamCMDBox);

			UpdateSettings();
		}

		private void ServerFilesDirbox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(ServerFilesDirbox);

			UpdateSettings();
		}

		private async void SetupDirNextButton_Click(object sender, EventArgs e)
		{
			if (!ValidateInputAndUpdateSettings())
				return;

			//check if the steamcmd directory exists if not create it.

			if (!Directory.Exists(Properties.Settings.Default.RustFilesDir))
			{
				Directory.CreateDirectory(Properties.Settings.Default.RustFilesDir);
				LogMixed("INFO: ", "Rust server files directory did not exist and was created.", Color.Blue);
			}

			if (!Directory.Exists(Properties.Settings.Default.MapsFilesDir))
			{
				Directory.CreateDirectory(Properties.Settings.Default.MapsFilesDir);
				LogMixed("INFO: ", "Maps directory did not exist and was created.", Color.Blue);
			}

			if (!Directory.Exists(Properties.Settings.Default.SteamCMDDir))
			{
				Directory.CreateDirectory(Properties.Settings.Default.SteamCMDDir);
				LogMixed("INFO: ", "SteamCMD directory did not exist and was created.", Color.Blue);
			}


			UpdateUIForDownload();

			// Check if steamcmd.exe exists in the specified directory
			if (!await EnsureSteamCmdExists())
				return;

			// Check for selected branch type and pass the correct branch name
			if (DropDownBranches.SelectedIndex == 0)
			{
				// Main branch
				await DownloadServerFiles(false, null);
			}
			else
			{
				// Beta branch - pass the selected branch name
				await DownloadServerFiles(true, DropDownBranches.SelectedItem.ToString());
			}
		}
		#region Download asyncs
		private async Task<bool> EnsureSteamCmdExists()
		{
			string steamCmdPath = Path.Combine(SetupCMDdir.Text, "steamcmd.exe");

			if (File.Exists(steamCmdPath))
			{
				LogMixed("INFO: ", "SteamCMD.exe found in specified directory.", Color.Blue);
				return true;
			}

			// If steamcmd.exe doesn't exist in the user-specified directory, download it
			LogMixed("INFO: ", "SteamCMD not found. Downloading to specified directory...", Color.Blue);

			// Update the download page UI
			CMDDownloadText.Invoke((MethodInvoker)delegate
			{
				CMDDownloadText.AppendText("SteamCMD not found. Downloading..." + Environment.NewLine);
				CMDStatusLabel.Text = "Downloading SteamCMD...";
				CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
				CMDDownloadText.ScrollToCaret();
			});

			try
			{
				string steamCmdUrl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
				string zipPath = Path.Combine(SetupCMDdir.Text, "steamcmd.zip");

				// Create user-specified directory if it doesn't exist
				Directory.CreateDirectory(SetupCMDdir.Text);

				// First check if the zip file already exists and delete it to avoid exceptions
				if (File.Exists(zipPath))
				{
					CMDDownloadText.Invoke((MethodInvoker)delegate
					{
						CMDDownloadText.AppendText("Found existing steamcmd.zip, will use it directly..." + Environment.NewLine);
						CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
						CMDDownloadText.ScrollToCaret();
					});
				}
				else
				{
					// Download the file with progress reporting
					using (var client = new HttpClient())
					{
						// Get file size first 
						var response = await client.GetAsync(steamCmdUrl, HttpCompletionOption.ResponseHeadersRead);
						var totalBytes = response.Content.Headers.ContentLength ?? -1L;

						CMDDownloadText.Invoke((MethodInvoker)delegate
						{
							CMDDownloadText.AppendText($"Downloading SteamCMD.zip ({totalBytes / 1024} KB)..." + Environment.NewLine);
							CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
							CMDDownloadText.ScrollToCaret();
						});

						using (var download = await client.GetStreamAsync(steamCmdUrl))
						using (var fileStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None))
						{
							var buffer = new byte[8192];
							long totalBytesRead = 0;
							int bytesRead;
							int lastPercentage = 0;

							while ((bytesRead = await download.ReadAsync(buffer, 0, buffer.Length)) > 0)
							{
								await fileStream.WriteAsync(buffer, 0, bytesRead);
								totalBytesRead += bytesRead;

								// Update progress every 10%
								if (totalBytes > 0)
								{
									int percentage = (int)((totalBytesRead * 100) / totalBytes);
									if (percentage >= lastPercentage + 10)
									{
										lastPercentage = percentage;
										CMDDownloadText.Invoke((MethodInvoker)delegate
										{
											CMDDownloadText.AppendText($"Download progress: {percentage}%" + Environment.NewLine);
											CMDStatusLabel.Text = $"Downloading SteamCMD... {percentage}%";
											CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
											CMDDownloadText.ScrollToCaret();
										});
									}
								}
							}
						}
					}
				}

				LogMixed("INFO: ", "Download complete. Extracting...", Color.Blue);
				CMDDownloadText.Invoke((MethodInvoker)delegate
				{
					CMDDownloadText.AppendText("Extracting steamcmd.zip..." + Environment.NewLine);
					CMDStatusLabel.Text = "Extracting SteamCMD...";
					CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
					CMDDownloadText.ScrollToCaret();
				});

				// Extract using ZipArchive - Fixed the resource leak issue
				using (var fileStream = File.OpenRead(zipPath))
				using (var archive = new ZipArchive(fileStream))
				{
					int totalFiles = archive.Entries.Count;
					int filesExtracted = 0;

					foreach (var entry in archive.Entries)
					{
						string fullPath = Path.Combine(SetupCMDdir.Text, entry.FullName);
						string directory = Path.GetDirectoryName(fullPath);

						// Create directory if needed
						if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
							Directory.CreateDirectory(directory);

						// Skip directory entries (those with empty names)
						if (!string.IsNullOrEmpty(entry.Name))
						{
							// Extract file and overwrite if it exists
							entry.ExtractToFile(fullPath, true);
							filesExtracted++;
						}

						// Update every 25% of files extracted
						if (filesExtracted % Math.Max(1, (totalFiles / 4)) == 0)
						{
							int percentage = (filesExtracted * 100) / totalFiles;
							CMDDownloadText.Invoke((MethodInvoker)delegate
							{
								CMDDownloadText.AppendText($"Extraction progress: {percentage}% ({filesExtracted}/{totalFiles} files)" + Environment.NewLine);
								CMDStatusLabel.Text = $"Extracting SteamCMD... {percentage}%";
								CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
								CMDDownloadText.ScrollToCaret();
							});
						}
					}
				}

				// Delete the zip file after extraction
				File.Delete(zipPath);

				LogMixed("SUCCESS: ", "SteamCMD installed successfully to specified directory!", Color.Green);
				CMDDownloadText.Invoke((MethodInvoker)delegate
				{
					CMDDownloadText.AppendText("SteamCMD installed successfully!" + Environment.NewLine);
					CMDStatusLabel.Text = "SteamCMD installation complete! Updating...";
					CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
					CMDDownloadText.ScrollToCaret();
				});

				// Also update the settings
				Properties.Settings.Default.SteamCMDDir = SetupCMDdir.Text;
				Properties.Settings.Default.Save();

				return true;
			}
			catch (Exception ex)
			{
				HandleError(ex, "downloading/extracting SteamCMD");
				return false;
			}
		}
		private async Task<bool> EnsureCarbonReleaseExists()
		{
			string targetDir = Properties.Settings.Default.RustFilesDir;
			string zipUrl = "https://github.com/CarbonCommunity/Carbon/releases/download/production_build/Carbon.Windows.Release.zip";
			string zipPath = Path.Combine(targetDir, "Carbon.Windows.Release.zip");

			try
			{
				// Ensure directory exists
				Directory.CreateDirectory(targetDir);

				// Update UI
				CMDDownloadText.Invoke((MethodInvoker)delegate
				{
					CMDDownloadText.AppendText("Checking for Carbon release..." + Environment.NewLine);
					CMDStatusLabel.Text = "Downloading Carbon...";
					CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
					CMDDownloadText.ScrollToCaret();
				});

				if (!File.Exists(zipPath))
				{
					using (var client = new HttpClient())
					{
						var response = await client.GetAsync(zipUrl, HttpCompletionOption.ResponseHeadersRead);
						var totalBytes = response.Content.Headers.ContentLength ?? -1L;

						using (var download = await response.Content.ReadAsStreamAsync())
						using (var fileStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None))
						{
							var buffer = new byte[8192];
							long totalBytesRead = 0;
							int bytesRead;
							int lastPercentage = 0;

							while ((bytesRead = await download.ReadAsync(buffer, 0, buffer.Length)) > 0)
							{
								await fileStream.WriteAsync(buffer, 0, bytesRead);
								totalBytesRead += bytesRead;

								if (totalBytes > 0)
								{
									int percentage = (int)((totalBytesRead * 100) / totalBytes);
									if (percentage >= lastPercentage + 10)
									{
										lastPercentage = percentage;
										CMDDownloadText.Invoke((MethodInvoker)delegate
										{
											CMDDownloadText.AppendText($"Download progress: {percentage}%" + Environment.NewLine);
											CMDStatusLabel.Text = $"Downloading Carbon... {percentage}%";
											CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
											CMDDownloadText.ScrollToCaret();
										});
									}
								}
							}
						}
					}
				}
				else
				{
					CMDDownloadText.Invoke((MethodInvoker)delegate
					{
						CMDDownloadText.AppendText("Carbon zip already exists, using cached version..." + Environment.NewLine);
						CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
						CMDDownloadText.ScrollToCaret();
					});
				}

				// Extract
				CMDDownloadText.Invoke((MethodInvoker)delegate
				{
					CMDDownloadText.AppendText("Extracting Carbon zip..." + Environment.NewLine);
					CMDStatusLabel.Text = "Extracting Carbon...";
					CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
					CMDDownloadText.ScrollToCaret();
				});

				using (var fileStream = File.OpenRead(zipPath))
				using (var archive = new ZipArchive(fileStream))
				{
					int totalFiles = archive.Entries.Count;
					int filesExtracted = 0;

					foreach (var entry in archive.Entries)
					{
						string fullPath = Path.Combine(targetDir, entry.FullName);
						string directory = Path.GetDirectoryName(fullPath);

						if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
							Directory.CreateDirectory(directory);

						if (!string.IsNullOrEmpty(entry.Name))
						{
							entry.ExtractToFile(fullPath, true);
							filesExtracted++;
						}

						if (filesExtracted % Math.Max(1, (totalFiles / 4)) == 0)
						{
							int percentage = (filesExtracted * 100) / totalFiles;
							CMDDownloadText.Invoke((MethodInvoker)delegate
							{
								CMDDownloadText.AppendText($"Extraction progress: {percentage}% ({filesExtracted}/{totalFiles} files)" + Environment.NewLine);
								CMDStatusLabel.Text = $"Extracting Carbon... {percentage}%";
								CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
								CMDDownloadText.ScrollToCaret();
							});
						}
					}
				}

				// Cleanup
				File.Delete(zipPath);

				LogMixed("SUCCESS: ", "Carbon installed successfully!", Color.Green);
				CMDDownloadText.Invoke((MethodInvoker)delegate
				{
					CMDDownloadText.AppendText("Carbon installed successfully!" + Environment.NewLine);
					CMDStatusLabel.Text = "Carbon installation complete!";
					CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
					CMDDownloadText.ScrollToCaret();
				});

				return true;
			}
			catch (Exception ex)
			{
				HandleError(ex, "downloading/extracting Carbon");
				return false;
			}
		}
        private async Task<bool> EnsureUmodExists()
        {
            string targetDir = Properties.Settings.Default.RustFilesDir;
            string zipUrl = "https://umod.org/games/rust/download?tag=public";
            string zipPath = Path.Combine(targetDir, "Oxide.Rust.zip");

            try
            {
                // Ensure directory exists
                Directory.CreateDirectory(targetDir);

                // Update UI
                CMDDownloadText.Invoke((MethodInvoker)delegate
                {
                    CMDDownloadText.AppendText("Checking for Umod release..." + Environment.NewLine);
                    CMDStatusLabel.Text = "Downloading Umod...";
                    CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                    CMDDownloadText.ScrollToCaret();
                });

                if (!File.Exists(zipPath))
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(zipUrl, HttpCompletionOption.ResponseHeadersRead);
                        var totalBytes = response.Content.Headers.ContentLength ?? -1L;

                        using (var download = await response.Content.ReadAsStreamAsync())
                        using (var fileStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            var buffer = new byte[8192];
                            long totalBytesRead = 0;
                            int bytesRead;
                            int lastPercentage = 0;

                            while ((bytesRead = await download.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await fileStream.WriteAsync(buffer, 0, bytesRead);
                                totalBytesRead += bytesRead;

                                if (totalBytes > 0)
                                {
                                    int percentage = (int)((totalBytesRead * 100) / totalBytes);
                                    if (percentage >= lastPercentage + 10)
                                    {
                                        lastPercentage = percentage;
                                        CMDDownloadText.Invoke((MethodInvoker)delegate
                                        {
                                            CMDDownloadText.AppendText($"Download progress: {percentage}%" + Environment.NewLine);
                                            CMDStatusLabel.Text = $"Downloading Umod... {percentage}%";
                                            CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                                            CMDDownloadText.ScrollToCaret();
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    CMDDownloadText.Invoke((MethodInvoker)delegate
                    {
                        CMDDownloadText.AppendText("Umod zip already exists, using cached version..." + Environment.NewLine);
                        CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                        CMDDownloadText.ScrollToCaret();
                    });
                }

                // Extract
                CMDDownloadText.Invoke((MethodInvoker)delegate
                {
                    CMDDownloadText.AppendText("Extracting Umod zip..." + Environment.NewLine);
                    CMDStatusLabel.Text = "Extracting Umod...";
                    CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                    CMDDownloadText.ScrollToCaret();
                });

                using (var fileStream = File.OpenRead(zipPath))
                using (var archive = new ZipArchive(fileStream))
                {
                    int totalFiles = archive.Entries.Count;
                    int filesExtracted = 0;

                    foreach (var entry in archive.Entries)
                    {
                        string fullPath = Path.Combine(targetDir, entry.FullName);
                        string directory = Path.GetDirectoryName(fullPath);

                        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        if (!string.IsNullOrEmpty(entry.Name))
                        {
                            entry.ExtractToFile(fullPath, true);
                            filesExtracted++;
                        }

                        if (filesExtracted % Math.Max(1, (totalFiles / 4)) == 0)
                        {
                            int percentage = (filesExtracted * 100) / totalFiles;
                            CMDDownloadText.Invoke((MethodInvoker)delegate
                            {
                                CMDDownloadText.AppendText($"Extraction progress: {percentage}% ({filesExtracted}/{totalFiles} files)" + Environment.NewLine);
                                CMDStatusLabel.Text = $"Extracting Carbon... {percentage}%";
                                CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                                CMDDownloadText.ScrollToCaret();
                            });
                        }
                    }
                }

                // Cleanup
                File.Delete(zipPath);

                LogMixed("SUCCESS: ", "Umod installed successfully!", Color.Green);
                CMDDownloadText.Invoke((MethodInvoker)delegate
                {
                    CMDDownloadText.AppendText("Umod installed successfully!" + Environment.NewLine);
                    CMDStatusLabel.Text = "Umod installation complete!";
                    CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                    CMDDownloadText.ScrollToCaret();
                });

                return true;
            }
            catch (Exception ex)
            {
                HandleError(ex, "downloading/extracting Umod");
                return false;
            }
        }

        private async Task<bool> DownloadRustEditDllAsync()
		{
			string url = "https://raw.githubusercontent.com/k1lly0u/Oxide.Ext.RustEdit/master/Oxide.Ext.RustEdit.dll";
			string targetDir = Properties.Settings.Default.RustFilesDir + "\\carbon\\extensions";
			string outputPath = Path.Combine(targetDir, "Oxide.Ext.RustEdit.dll");

			try
			{
				Directory.CreateDirectory(targetDir);

				using (var client = new HttpClient())
				using (var response = await client.GetAsync(url))
				{
					response.EnsureSuccessStatusCode();
					var content = await response.Content.ReadAsByteArrayAsync();

					using (var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
					{
						await fs.WriteAsync(content, 0, content.Length);
					}
				}

				LogMixed("SUCCESS: ", "Downloaded Oxide.Ext.RustEdit.dll successfully.", Color.Green);
				return true;
			}
			catch (Exception ex)
			{
				HandleError(ex, "downloading Oxide.Ext.RustEdit.dll");
				return false;
			}
		}
		#endregion

		private bool ValidateInputAndUpdateSettings()
		{
			// Check if server files directory are set

			if (SetupServerTextbox.Text == "" || SetupCMDdir.Text == "")
			{
				MainSnackbar.Show(this, "A directory for the server files and SteamCMD is required to continue.",
					BunifuSnackbar.MessageTypes.Warning, 5000, "Close", BunifuSnackbar.Positions.TopCenter);
				return false;
			}

			// Update settings with new values
			Properties.Settings.Default.RustFilesDir = SetupServerTextbox.Text;
			Properties.Settings.Default.MapsFilesDir = SetupMapsDirectory.Text;
			Properties.Settings.Default.SteamCMDDir = SetupCMDdir.Text;
			Properties.Settings.Default.ClientMapsDir = RustGameDirbox.Text;
			Properties.Settings.Default.Save();

			return true;
		}

		private void UpdateUIForDownload()
		{
			MainPages.SetPage(3);
			SetupCMDNextButton.Enabled = false;
			CMDStatusLabel.Text = "Please wait for the download to finish.";

			// Update text boxes with current settings
			ServerFilesDirbox.Text = Properties.Settings.Default.RustFilesDir;
			MapDirBox.Text = Properties.Settings.Default.MapsFilesDir;
			SteamCMDBox.Text = Properties.Settings.Default.SteamCMDDir;
		}

		private async Task DownloadServerFiles(bool isBeta, string branchName)
		{
			try
			{
				string steamCmdPath = ValidateSteamCmdPath();
				if (steamCmdPath == null)
					return;

				Process process = SetupDownloadProcess(steamCmdPath, isBeta, branchName);

				await RunDownloadProcess(process);
			}
			catch (Exception ex)
			{
				HandleDownloadError(ex);
			}
		}

		private async Task DownloadMainBranchFiles()
		{
			await DownloadServerFiles(false, null);
		}

		private async Task DownloadBetaBranchFiles()
		{
			await DownloadServerFiles(true, DropDownBranches.SelectedItem.ToString());
		}

		private string ValidateSteamCmdPath()
		{
			string steamCmdPath = Path.Combine(SetupCMDdir.Text, "steamcmd.exe");

			if (!File.Exists(steamCmdPath))
			{
				MessageBox.Show("steamcmd.exe not found in the specified directory.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainPages.SetPage(2);
				return null;
			}

			return steamCmdPath;
		}

		private Process SetupDownloadProcess(string steamCmdPath, bool isBetaBranch, string branchName)
		{
			string batchDir = SetupCMDdir.Text;
			string batchFilePath = Path.Combine(batchDir, "download_server.bat");

			// Create batch file content
			StringBuilder batchContent = new StringBuilder();
			batchContent.AppendLine("@echo off");
			batchContent.AppendLine("echo Updating SteamCMD...");
			batchContent.AppendLine("\"" + steamCmdPath + "\" +login anonymous +quit");
			batchContent.AppendLine("echo SteamCMD updated. Now downloading Rust server files...");

			// Add command to download server files
			if (isBetaBranch)
			{
				// Use the provided branch name to create flexible branch arguments
				batchContent.AppendLine("\"" + steamCmdPath + "\" +force_install_dir \"" +
					SetupServerTextbox.Text + "\" +login anonymous +app_update 258550 -beta " +
					branchName + " validate +quit");
			}
			else
			{
				batchContent.AppendLine("\"" + steamCmdPath + "\" +force_install_dir \"" +
					SetupServerTextbox.Text + "\" +login anonymous +app_update 258550 validate +quit");
			}

			// Write batch file
			File.WriteAllText(batchFilePath, batchContent.ToString());

			CMDDownloadText.Invoke((MethodInvoker)delegate
			{
				CMDDownloadText.AppendText("Created batch file for SteamCMD operations" + Environment.NewLine);
				CMDDownloadText.AppendText("Step 1: Update SteamCMD" + Environment.NewLine);
				CMDDownloadText.AppendText("Step 2: Download Rust server files" + Environment.NewLine);
				CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
				CMDDownloadText.ScrollToCaret();
			});

			// Create process to run the batch file
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();

			startInfo.FileName = batchFilePath;
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;
			startInfo.WorkingDirectory = batchDir;

			process.StartInfo = startInfo;

			// Setup output handling
			SetupProcessOutputHandlers(process);

			return process;
		}

		private void SetupProcessOutputHandlers(Process process)
		{
			process.OutputDataReceived += (s, args) =>
			{
				if (args.Data != null)
				{
					// Apply debouncing to process output
					string data = args.Data;
					DateTime now = DateTime.Now;

					// Skip duplicate lines that occur frequently
					if (data == lastLoggedLine && now - lastLoggedTime < TimeSpan.FromMilliseconds(1000))
					{
						return;
					}

					// Update the last logged information
					lastLoggedLine = data;
					lastLoggedTime = now;

					CMDDownloadText.Invoke((MethodInvoker)delegate
					{
						CMDDownloadText.AppendText(data + Environment.NewLine);
						// Auto-scroll to the bottom
						CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
						CMDDownloadText.ScrollToCaret();
					});
				}
			};

			process.ErrorDataReceived += (s, args) =>
			{
				if (args.Data != null)
				{
					CMDDownloadText.Invoke((MethodInvoker)delegate
					{
						CMDDownloadText.AppendText("Error: " + args.Data + Environment.NewLine);
						CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
						CMDDownloadText.ScrollToCaret();
					});
				}
			};
		}

		private async Task RunDownloadProcess(Process process)
		{
			// No need to check for SteamCMD here as it's part of the batch file now
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();

			// Wait for the process to exit asynchronously
			await Task.Run(() => process.WaitForExit());

			// Update UI after completion
			CMDDownloadText.Invoke((MethodInvoker)delegate
			{
				CMDDownloadText.AppendText("Process completed!" + Environment.NewLine);
				CMDStatusLabel.Text = "Steam Cmd Installed. Click next at the top.";
			});
		}

		private async Task CheckSteamCmdAndDownloadIfNeeded()
		{
			try
			{
				// Try to detect steamcmd.exe in the specified directory
				string steamCmdPath = Path.Combine(SteamCMDBox.Text, "steamcmd.exe");
				if (File.Exists(steamCmdPath))
				{
					LogMixed("INFO: ", "SteamCMD.exe found.", Color.Blue);
					LogMixed("INFO: ", "Starting SteamCMD please wait.", Color.Blue);
				}
				else
				{
					LogMixed("INFO: ", "SteamCMD not found. Downloading...", Color.Blue);
					await DownloadAndExtractSteamCMD();
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "checking SteamCMD");
			}
		}

		private void HandleDownloadError(Exception ex)
		{
			HandleError(ex, "downloading server files");
		}

		private void SaveSettingsButton_Click(object sender, EventArgs e)
		{
            RadioCarbon.Checked = true;
            RadioUmod.Checked = false;

            string path = Directory.GetCurrentDirectory();

			SetupServerTextbox.Text = ServerFilesDirbox.Text;
			SetupCMDdir.Text = SteamCMDBox.Text;
			SetupMapsDirectory.Text = MapDirBox.Text;

			if (SetupServerTextbox.Text == "" ||
						  SetupMapsDirectory.Text == "" ||
						  SetupCMDdir.Text == "")
			{
				Properties.Settings.Default.RustFilesDir = path + "\\Server_Files";
				Properties.Settings.Default.MapsFilesDir = path + "\\Maps";
				Properties.Settings.Default.SteamCMDDir = path + "\\SteamCMD";
				Properties.Settings.Default.Save();

				SetupServerTextbox.Text = Properties.Settings.Default.RustFilesDir;
				SetupMapsDirectory.Text = Properties.Settings.Default.MapsFilesDir;
				SetupCMDdir.Text = Properties.Settings.Default.SteamCMDDir;
			}


			DropDownBranches.SelectedIndex = 0;

			MainPages.SetPage(2);
		}

		private void SetupMapsDirectory_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(SetupMapsDirectory);
		}

		private void SetupCMDdir_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(SetupCMDdir);
		}

		private void SetupCMDBackButton_Click(object sender, EventArgs e)
		{
			SetupServerTextbox.Text = Properties.Settings.Default.RustFilesDir;
			SetupCMDdir.Text = Properties.Settings.Default.SteamCMDDir;
			SetupMapsDirectory.Text = Properties.Settings.Default.MapsFilesDir;

			LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);

			DropDownBranches.SelectedIndex = 0;
			MainPages.SetPage(2);
		}

		private void createStartFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string serverDir = Properties.Settings.Default.RustFilesDir;
			string mapDirectory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			string mapFileName = MapsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
			string batchFileName = mapFileName.Replace(".map", ".bat");

			string batchFilePath = Path.Combine(serverDir, batchFileName);
			WriteBatchFile(batchFilePath, mapDirectory);

			LogMixed("FILES: ", "Start file created at: " + serverDir, Color.Goldenrod);
		}

		private void startServerWithMapToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			string serverDir = Properties.Settings.Default.RustFilesDir;
			string mapDirectory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			string mapName = MapsDataGridView.SelectedRows[0].Cells[0].Value.ToString();

			CreateAndStartMapServer(mapName, mapDirectory, serverDir);
		}

		private void CreateAndStartMapServer(string mapName, string mapPath, string serverDir)
		{
			string batchFilePath = Path.Combine(serverDir, mapName.Replace(".map", ".bat"));
			WriteBatchFile(batchFilePath, mapPath);
			LogMixed("FILES: ", "Start file created at: " + serverDir, Color.Goldenrod);

			if (CheckDeleteClientMap.Checked)
			{
				string clientMapPath = Path.Combine(Properties.Settings.Default.ClientMapsDir, mapName);
				if (File.Exists(clientMapPath))
				{
					File.Delete(clientMapPath);
					LogMixed("FILES: ", "Client map deleted: " + clientMapPath, Color.Goldenrod);
				}
			}

			StartBatFile(batchFilePath);
			LogMixed("INFO: ", "Server started with map: " + mapName, Color.Blue);
		}

		private void CreateAndStartMapServerTest(string mapName, string mapPath, string serverDir)
		{
			string batchFilePath = Path.Combine(serverDir, mapName.Replace(".map", ".bat"));
			WriteBatchFileTest(batchFilePath, mapPath);
			LogMixed("FILES: ", "Start file created at: " + serverDir, Color.Goldenrod);

			if (CheckDeleteClientMap.Checked)
			{
				string clientMapPath = Path.Combine(Properties.Settings.Default.ClientMapsDir, mapName);
				if (File.Exists(clientMapPath))
				{
					File.Delete(clientMapPath);
					LogMixed("FILES: ", "Client map deleted: " + clientMapPath, Color.Goldenrod);
				}
			}

			StartBatFile(batchFilePath);
			LogMixed("INFO: ", "Server started with map: " + mapName, Color.Blue);
		}


		#endregion

		#region FileWatcher
		private void SetupFolderWatcher(string folderPath)
		{
			try
			{
				watcher = new FileSystemWatcher();
				watcher.Path = folderPath;

				// Watch for all types of changes
				watcher.NotifyFilter = NotifyFilters.LastWrite
								   | NotifyFilters.FileName
								   | NotifyFilters.DirectoryName
								   | NotifyFilters.Size;

				// Add event handlers
				watcher.Created += OnFileCreated;
				watcher.Deleted += OnFileDeleted;
				watcher.Changed += OnFileChanged;
				watcher.Renamed += OnFileRenamed;
				watcher.Filter = "*.map";
				watcher.IncludeSubdirectories = true;

				// Begin watching
				watcher.EnableRaisingEvents = true;

				LogMixed($"INFO: ", "Now watching folder: " + folderPath, Color.Blue);
			}
			catch (Exception ex)
			{
				LogMixed("ERROR: ", $"Error setting up folder watcher: {ex.Message}", Color.Red);

			}
		}

		private bool ShouldProcessFileEvent(string filePath)
		{
			// Debounce time to prevent multiple events firing in quick succession
			TimeSpan debounceTime = TimeSpan.FromSeconds(2); // Adjust debounce time as needed

			DateTime now = DateTime.Now;

			lock (lastChangeByFile) // Ensure thread safety
			{
				// Check if the file path is already being processed
				if (lastChangeByFile.TryGetValue(filePath, out DateTime lastChangeTime))
				{
					if (now - lastChangeTime < debounceTime)
					{
						return false; // Skip processing if within debounce time
					}
				}

				// Update the last change time for this file
				lastChangeByFile[filePath] = now;
			}

			return true;
		}

		// Event handlers
		private void OnFileCreated(object sender, FileSystemEventArgs e)
		{
			if (ShouldProcessFileEvent(Properties.Settings.Default.MapsFilesDir))
			{
				LogMixed("FILES: ", $"File created: {e.Name}", Color.Goldenrod);

				// Show notification only if the checkbox is checked
				if (CheckboxDesktopNoti.Checked)
				{
					ShowWindowsNotification("Map Changed", "Click here to run a server with this map.", e.FullPath);
				}

				// Ensure the DataGridView update is performed on the UI thread  
				if (MapsDataGridView.InvokeRequired)
				{
					MapsDataGridView.Invoke(new Action(() =>
					{
						LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
					}));
				}
				else
				{
					LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
				}
			}
		}

		private void OnFileDeleted(object sender, FileSystemEventArgs e)
		{
			if (ShouldProcessFileEvent(Properties.Settings.Default.MapsFilesDir))
			{
				LogMixed("FILES: ", $"File deleted: {e.Name}", Color.Goldenrod);
				UpdatedMapName = e.Name;

				// Ensure the DataGridView update is performed on the UI thread  
				if (MapsDataGridView.InvokeRequired)
				{
					MapsDataGridView.Invoke(new Action(() =>
					{
						LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
					}));
				}
				else
				{
					LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
				}
			}
		}

		private void OnFileRenamed(object sender, RenamedEventArgs e)
		{
			if (ShouldProcessFileEvent(Properties.Settings.Default.MapsFilesDir))
			{
				LogMixed("FILES: ", $"File Renamed: {e.Name}", Color.Goldenrod);

				UpdatedMapName = e.Name;

				// Ensure the DataGridView update is performed on the UI thread  
				if (MapsDataGridView.InvokeRequired)
				{
					MapsDataGridView.Invoke(new Action(() =>
					{
						LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
					}));
				}
				else
				{
					LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
				}
			}
		}

		private void OnFileChanged(object sender, FileSystemEventArgs e)
		{
			if (ShouldProcessFileEvent(e.FullPath))
			{
				LogMixed("FILES: ", $"File changed: {e.Name}", Color.Goldenrod);
				UpdatedMapName = e.Name;

				// Show notification only if the checkbox is checked
				if (CheckboxDesktopNoti.Checked)
				{
					ShowWindowsNotification("Map Changed", "Click here to run a server with this map.", e.FullPath);
				}

				// Update DataGridView on the UI thread
				if (MapsDataGridView.InvokeRequired)
				{
					MapsDataGridView.Invoke(new Action(() =>
					{
						LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
					}));
				}
				else
				{
					LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);
				}
			}
		}

		// close the watcher on app close
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (watcher != null)
			{
				watcher.EnableRaisingEvents = false;
				watcher.Dispose();
			}

			if (notifyIcon != null)
			{
				notifyIcon.Dispose();
			}

			base.OnFormClosing(e);
		}
		#endregion

		#region Desktop Notify
		private NotifyIcon notifyIcon;

		private Dictionary<string, DateTime> lastChangeByFile = new Dictionary<string, DateTime>();

		private void InitializeNotification()
		{
			notifyIcon = new NotifyIcon()
			{
				Icon = SystemIcons.Information,
				
                Visible = false
			};

			// Handle notification click
			notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;

			// Handle right-click menu
			ContextMenuStrip menu = new ContextMenuStrip();
			//menu.Items.Add("Open Map", null, OpenMap_Click);
			//menu.Items.Add("Show Details", null, ShowDetails_Click);
			//menu.Items.Add("-"); // Separator
			menu.Items.Add("Close", null, (s, e) => Application.Exit());

			notifyIcon.ContextMenuStrip = menu;
		}

		private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(UpdatedMapName) &&
				!string.IsNullOrEmpty(Properties.Settings.Default.MapsFilesDir) &&
				!string.IsNullOrEmpty(Properties.Settings.Default.RustFilesDir))
			{
				CreateAndStartMapServer(UpdatedMapName, Path.Combine(Properties.Settings.Default.MapsFilesDir, UpdatedMapName), Properties.Settings.Default.RustFilesDir);
			}
			else
			{
				LogMixed("ERROR: ", "Cannot start server - missing map name or directory settings", Color.Red);
			}
		}

		private void OpenMap_Click(object sender, EventArgs e)
		{
			if (notifyIcon.Tag != null && File.Exists(notifyIcon.Tag.ToString()))
			{
				string mapDirectory = Path.GetDirectoryName(notifyIcon.Tag.ToString());
				Process.Start("explorer.exe", mapDirectory);
				LogMixed("INFO: ", "Map directory opened in explorer", Color.Blue);
			}
		}

		private void ShowDetails_Click(object sender, EventArgs e)
		{
			if (notifyIcon.Tag != null && File.Exists(notifyIcon.Tag.ToString()))
			{
				string mapFile = notifyIcon.Tag.ToString();
				FileInfo fileInfo = new FileInfo(mapFile);
				string details = $"File: {Path.GetFileName(mapFile)}\nPath: {mapFile}\nSize: {fileInfo.Length / 1024} KB\nLast Modified: {fileInfo.LastWriteTime}";
				MessageBox.Show(details, "Map Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void ShowWindowsNotification(string title, string message, string mapPath = null)
		{
			notifyIcon.Tag = mapPath; // Store map path for use in click handlers
			notifyIcon.BalloonTipTitle = title;
			notifyIcon.BalloonTipText = message;
			notifyIcon.ShowBalloonTip(3000);
		}
		#endregion

		#region Dropped Files
		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".map")
				{
					e.Effect = DragDropEffects.Copy;

				}
				else
				{
					e.Effect = DragDropEffects.None;
				}
			}
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			CheckCmdSimple();

			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			string mapFile = files[0];

			if (Path.GetExtension(mapFile).ToLower() == ".map")
			{
				try
				{
					//check if map client delete is checked and only then delete it.
					if (CheckDeleteClientMap.Checked)
					{
						string clientMapPath = Path.Combine(Properties.Settings.Default.ClientMapsDir, mapFile);
						if (File.Exists(clientMapPath))
						{
							File.Delete(clientMapPath);
							LogMixed("FILES: ", "Client map deleted: " + clientMapPath, Color.Goldenrod);
						}
					}

					LogMixed("FILES: ", mapFile + " drop detected.", Color.Goldenrod);
					string mapdropped = Path.GetFileName(mapFile);
					CreateAndStartMapServer(mapdropped, mapFile, Properties.Settings.Default.RustFilesDir);
				}
				catch (Exception ex)
				{
					HandleError(ex, "creating batch file");
				}
			}
		}

		private void HandleError(Exception ex, string operationDescription)
		{
			LogMixed("ERROR: ", $"Error {operationDescription}: {ex.Message}", Color.Red);
			//MessageBox.Show($"Error {operationDescription}: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void HandleDroppedMap(string mapFile)
		{
			CheckCmdSimple();

			try
			{
				LogMixed("FILES: ", mapFile + " drop detected.", Color.Goldenrod);
				string mapdropped = Path.GetFileName(mapFile);
				CreateAndStartMapServer(mapdropped, mapFile, Properties.Settings.Default.RustFilesDir);
			}
			catch (Exception ex)
			{
				HandleError(ex, "creating batch file for dropped map");
			}
		}
		#endregion

		#region Start files
		private void WriteBatchFile(string filePath, string MapPath)
		{
			try
			{
				string mapName = Path.GetFileName(MapPath);
				string password = GenerateRandomPassword(8);
				string id = GenerateRandomPassword(6);

				StringBuilder batchContent = new StringBuilder();

				batchContent.AppendLine("@echo off");
				batchContent.AppendLine("RustDedicated.exe ^");
				batchContent.AppendLine("-batchmode ^");
				batchContent.AppendLine("+server.port 28015 ^");
				batchContent.AppendLine($"+server.levelurl \"file:///{MapPath}\" ^");
				batchContent.AppendLine("+server.maxplayers 10 ^");
				batchContent.AppendLine("+server.hostname \"Name of Server\" ^");
				batchContent.AppendLine("+server.description \"Description shown on server connection window.\" ^");
				batchContent.AppendLine("+server.url \"http://yourwebsite.com\" ^");
				batchContent.AppendLine("+server.headerimage \"http://yourwebsite.com/serverimage.jpg\" ^");
				batchContent.AppendLine($"+server.identity \"{mapName.Replace(".map", "_")}{id}\" ^");
				batchContent.AppendLine("+rcon.port 28016 ^");
				batchContent.AppendLine($"+rcon.password \"{password}\" ^");
				batchContent.AppendLine("+rcon.web 1 ^");
				batchContent.AppendLine("-logfile \"rustserverlog.txt\"");

				//check if checkmark is checked and only then delete it.
				if (CheckNewStart.Checked == true)
				{
					if (File.Exists(filePath))
						File.Delete(filePath);

					File.WriteAllText(filePath, batchContent.ToString());
				}
				else
				{
					if (File.Exists(filePath))
					{
					}
					else
					{
						File.WriteAllText(filePath, batchContent.ToString());
					}

				}


			}
			catch (Exception ex)
			{
				HandleError(ex, "writing batch file");
			}
		}

		private void WriteBatchFileTest(string filePath, string MapPath)
		{
			try
			{
				string mapName = Path.GetFileName(MapPath);
				string password = GenerateRandomPassword(8);
				string id = GenerateRandomPassword(6);

				StringBuilder batchContent = new StringBuilder();


				batchContent.AppendLine("@echo off");
				batchContent.AppendLine("RustDedicated.exe -batchmode^");
				batchContent.AppendLine("+cargoship.event_enabled False ^");
				batchContent.AppendLine("+baseboat.generate_paths False ^");
				batchContent.AppendLine("+ai.ocean_patrol_path_iterations 0 ^");
				batchContent.AppendLine("+server.events False ^");
				batchContent.AppendLine("+antihack.terrain_protection 0 ^");
				batchContent.AppendLine("+server.port 28015 ^");
				batchContent.AppendLine($"+server.levelurl \"file:///{MapPath}\" ^");
				batchContent.AppendLine("+server.maxplayers 10 ^");
				batchContent.AppendLine("+server.hostname \"Name of Server\" ^");
				batchContent.AppendLine("+server.description \"Description shown on server connection window.\" ^");
				batchContent.AppendLine("+server.url \"http://yourwebsite.com\" ^");
				batchContent.AppendLine("+server.headerimage \"http://yourwebsite.com/serverimage.jpg\" ^");
				batchContent.AppendLine($"+server.identity \"{mapName.Replace(".map", "_")}{id}\" ^");
				batchContent.AppendLine("+rcon.port 28016 ^");
				batchContent.AppendLine($"+rcon.password \"{password}\" ^");
				batchContent.AppendLine("+rcon.web 1 ^");
				batchContent.AppendLine("-logfile \"rustserverlog.txt\"");

				//check if checkmark is checked and only then delete it.
				if (CheckNewStart.Checked == true)
				{
					if (File.Exists(filePath))
						File.Delete(filePath);

					File.WriteAllText(filePath, batchContent.ToString());
				}
				else
				{
					if (File.Exists(filePath))
					{
					}
					else
					{
						File.WriteAllText(filePath, batchContent.ToString());
					}

				}


			}
			catch (Exception ex)
			{
				HandleError(ex, "writing batch file");
			}
		}

		private void StartBatFile(string batFilePath)
		{
			try
			{
				// Start the bat file
				using (Process process = new Process())
				{
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = batFilePath,
						WorkingDirectory = Path.GetDirectoryName(batFilePath),
						UseShellExecute = true // Use shell execute for .bat files
					};

					process.StartInfo = startInfo;
					process.Start();

					// Add to history DataGridView
					HistoryDataView.Rows.Add(
						Path.GetFileName(batFilePath),           // Name
						Path.GetDirectoryName(batFilePath),      // Location
						DateTime.Now.ToString("dd/MM/yyyy"));      // Date


					//add map path to internal stringcollection

					//if (RunHistory.Default.HistoryList == null)
					//	RunHistory.Default.HistoryList = new StringCollection();

					if (RunHistory.Default.HistoryList == null)
						RunHistory.Default.HistoryList = new StringCollection();
					RunHistory.Default.HistoryList.Add(batFilePath);
					RunHistory.Default.Save();
					//add the map path to the to Properties.RunHistory.Default

				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "starting batch file");
			}
		}

		public void CreatePROCStartBatFile(string directory)
		{
			StringBuilder batchContent = new StringBuilder();
			string password = GenerateRandomPassword(8);
			string ID = GenerateRandomPassword(6);


			string batFilePath = Path.Combine(directory, "start_rust_server.bat");

			string batContent = $@"@echo off
RustDedicated.exe -batchmode ^
+server.port 28015 ^
+server.level ""Procedural Map"" ^
+server.seed 1184645116 ^
+server.worldsize 3000 ^
+server.maxplayers 100 ^
+server.hostname ""My Rust Server"" ^
+server.description ""This is my Rust server"" ^
+server.url ""http://myrustserver.com"" ^
+server.identity ""server_{ID}"" ^
+rcon.port 28016 ^
+rcon.password ""{password}"" ^
+rcon.web 1
pause";

			File.WriteAllText(batFilePath, batContent);
		}


		private bool CheckServerFilesDirectory()
		{
			string serverFilesDir = Properties.Settings.Default.RustFilesDir;

			if (string.IsNullOrEmpty(serverFilesDir))
			{
				LogMixed("ERROR: ", "Server files directory is not set.", Color.Red);
				MessageBox.Show("The server files directory is not set. Please configure it in the settings.",
					"Directory Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (Directory.Exists(serverFilesDir))
			{
				LogMixed("INFO: ", "Server files directory is available.", Color.Blue);
				return true;
			}
			else
			{
				LogMixed("ERROR: ", "Server files directory does not exist or is inaccessible.", Color.Red);
				MessageBox.Show("The server files directory does not exist or is inaccessible. Please verify the path.",
					"Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		#endregion

		#region SteamCMD

		private async Task DownloadAndExtractSteamCMD()
		{
			try
			{
				string steamCmdUrl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
				string zipPath = Path.Combine(SteamCMDBox.Text, "steamcmd.zip");

				// Create user-specified directory if it doesn't exist
				Directory.CreateDirectory(SteamCMDBox.Text);

				// Check if the zip file already exists
				if (File.Exists(zipPath))
				{
					LogMixed("INFO: ", "Found existing steamcmd.zip, will use it directly.", Color.Blue);
				}
				else
				{
					LogMixed("INFO: ", "Downloading SteamCMD to specified directory...", Color.Blue);

					// Download the file
					using (var client = new HttpClient())
					{
						byte[] zipData = await client.GetByteArrayAsync(steamCmdUrl);
						File.WriteAllBytes(zipPath, zipData);  // Using synchronous version
					}

					LogMixed("INFO: ", "Download complete.", Color.Blue);
				}

				LogMixed("INFO: ", "Extracting SteamCMD...", Color.Blue);

				// Extract using ZipArchive - Fixed the resource leak issue
				using (var fileStream = File.OpenRead(zipPath))
				using (var archive = new ZipArchive(fileStream))
				{
					foreach (var entry in archive.Entries)
					{
						string destinationPath = Path.Combine(SteamCMDBox.Text, entry.FullName);
						string destinationDir = Path.GetDirectoryName(destinationPath);

						// Create directory if it doesn't exist
						if (!string.IsNullOrEmpty(destinationDir) && !Directory.Exists(destinationDir))
							Directory.CreateDirectory(destinationDir);

						// Skip directories (entries that end with '/')
						if (!string.IsNullOrEmpty(entry.Name))
						{
							// Extract and overwrite if exists
							entry.ExtractToFile(destinationPath, true);
						}
					}
				}

				// Delete the zip file after extraction
				File.Delete(zipPath);

				LogMixed("SUCCESS: ", "SteamCMD installed successfully to specified directory!", Color.Green);

				// Update the setting
				Properties.Settings.Default.SteamCMDDir = SteamCMDBox.Text;
				Properties.Settings.Default.Save();
			}
			catch (Exception ex)
			{
				HandleError(ex, "downloading/extracting SteamCMD");
			}
		}

		#endregion

		private void LoadMapFilesToDataGridView(string folderPath, Bunifu.UI.WinForms.BunifuDataGridView dataGridView, int pageSize = 100, int pageNumber = 1)
		{
			try
			{
				// Clear existing rows
				dataGridView.Rows.Clear();

				// Get all .map files including sudirectories
				string[] allMapFiles = Directory.GetFiles(folderPath, "*.map", SearchOption.AllDirectories);

				// Calculate total pages
				int totalFiles = allMapFiles.Length;
				int totalPages = (int)Math.Ceiling((double)totalFiles / pageSize);

				// Validate page number
				pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages > 0 ? totalPages : 1));

				// Get files for current page
				string[] pageMapFiles = allMapFiles
					.Skip((pageNumber - 1) * pageSize)
					.Take(pageSize)
					.ToArray();

				// Create columns if they don't exist
				if (dataGridView.Columns.Count == 0)
				{
					// Add columns with Bunifu styling
					dataGridView.ColumnCount = 3;
					dataGridView.Columns[0].HeaderText = "Name";
					dataGridView.Columns[1].HeaderText = "Directory";
					dataGridView.Columns[2].HeaderText = "Date";

					// Optional: Customize column appearance
					foreach (DataGridViewColumn column in dataGridView.Columns)
					{
						column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
						column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					}
				}

				// Add files to the grid
				foreach (string file in pageMapFiles)
				{
					FileInfo fileInfo = new FileInfo(file);
					dataGridView.Rows.Add(
						Path.GetFileName(file),                    // Name
						Path.GetFullPath(file),               // Directory
						fileInfo.LastWriteTime.ToString("dd/MM/yyyy")  // Date
					);
				}

				// Optional: Additional Bunifu-specific styling
				dataGridView.AllowCustomTheming = true;
				dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 161, 192);
				dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

				// Enable sorting
				dataGridView.AllowUserToOrderColumns = true;
				dataGridView.Sort(dataGridView.Columns[2], System.ComponentModel.ListSortDirection.Descending);

				if (totalPages > 1)
				{
					LogMixed("INFO: ", $"Map files added to list (Page {pageNumber} of {totalPages}, showing {pageMapFiles.Length} of {totalFiles} files)", Color.Blue);
				}
				else
				{
					LogMixed("INFO: ", "Map files added to list.", Color.Blue);
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "loading map files");
			}
		}

		private void CMDDownloadText_TextChanged(object sender, EventArgs e)
		{
			if (CMDDownloadText.Text.Contains("Connecting anonymously to Steam Public"))
			{
				SetupStepsLabel.Text = "Step\n2/8";
			}


			if (CMDDownloadText.Text.Contains("[----] Verifying installation..."))
			{
				SetupStepsLabel.Text = "Step\n3/8";
			}

			if (CMDDownloadText.Text.Contains("SteamCMD updated. Now downloading Rust server files..."))
			{
				SetupStepsLabel.Text = "Step\n4/8";
			}

			if (CMDDownloadText.Text.Contains("Waiting for user info...OK"))
			{
				SetupStepsLabel.Text = "Step\n5/8";
			}


			if (CMDDownloadText.Text.Contains("Update state (0x5) verifying install, progress:"))
			{
				SetupStepsLabel.Text = "Step\n6/8";
			}


			if (CMDDownloadText.Text.Contains("Update state (0x5) verifying install, progress: 5"))
			{
				SetupStepsLabel.Text = "Step\n7/8";
			}


			//if textbox contains "Process completed!" then enable next button
			if (CMDDownloadText.Text.Contains("App '258550' fully installed."))
			{
				SetupCMDNextButton.Enabled = true;
				SetupCMDNextButton.Visible = true;
				SetupCMDNextButton.Refresh();

				CMDStatusLabel.Text = "Rust files downloaded, Click next.";

				SetupStepsLabel.Text = "Step\n8/8";

				if (DropDownBranches.SelectedIndex == 0)
				{
					LogMixed("FILES: ", "Downloaded main branch files to: " + Properties.Settings.Default.RustFilesDir, Color.Goldenrod);
				}
				else
				{
					LogMixed("FILES: ", "Downloaded beta branch files to: " + Properties.Settings.Default.RustFilesDir, Color.Goldenrod);
				}

				if (AutoNextSetupCheck.Checked == true)
				{
					SetupCMDNextButton.PerformClick();
				}
			}

			if (CMDDownloadText.Text.Contains("SteamCMD updated. Now downloading Rust server files..."))
			{
				CMDStatusLabel.Text = "Downloading Rust files, Please wait.";
			}
		}



		private void openMapDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string fullPath = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
				string Mapdirectory = Path.GetDirectoryName(fullPath);

				if (Directory.Exists(Mapdirectory))
				{
					LogMixed("INFO: ", "Maps path opened in explorer", Color.Blue);
					Process.Start("explorer.exe", Mapdirectory);
				}
				else
				{
					HandleError(new DirectoryNotFoundException("Folder not found"), "opening maps directory");
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "opening maps directory");
			}
		}

		private void copyMapDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string fullPath = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
				string Mapdirectory = Path.GetDirectoryName(fullPath);

				if (Directory.Exists(Mapdirectory))
				{
					Clipboard.SetText(Mapdirectory);
					LogMixed("INFO: ", "Path copied to clipboard", Color.Blue);
				}
				else
				{
					HandleError(new DirectoryNotFoundException("Folder not found"), "copying map directory");
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "copying map directory");
			}
		}

		private void copyMapNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string fullPath = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
				string fileName = Path.GetFileName(fullPath);

				Clipboard.SetText(fileName);
				LogMixed("INFO: ", "Map name copied to clipboard", Color.Blue);
			}
			catch (Exception ex)
			{
				HandleError(ex, "copying map name");
			}
		}



		private async void SetupcompletedHome_Click(object sender, EventArgs e)
		{
			LoadMapFilesToDataGridView(Properties.Settings.Default.MapsFilesDir, MapsDataGridView);

			MainPages.SetPage(0);

			if (CheckOpenReadme.Checked == true)
			{
				TabsFoundMaps.SelectedTab = HelpTab;
			}

			if (CheckHelpTooltips.Checked == true)
			{
				CheckToolTips.Checked = true;
			}

			CheckCmdSimple();

			Properties.Settings.Default.FirstRun = false;
			Properties.Settings.Default.Save();
			ConsoleTextbox.Update();
			ConsoleTextbox.Refresh();


			if (RadioCarbon.Checked == true)
			{
				// Check if carbon release exists
				if (!await EnsureCarbonReleaseExists())

					return;
			}

            if (RadioUmod.Checked == true)
            {
                // Check if carbon release exists
                if (!await EnsureUmodExists())

                    return;
            }


            if (CheckRusteditDLL.Checked == true)
			{
				// Check if carbon release exists
				if (!await DownloadRustEditDllAsync())

					return;
			}

			if (CheckRunExampleStart.Checked == true)
			{
				CreatePROCStartBatFile(Properties.Settings.Default.RustFilesDir);
				StartBatFile(Path.Combine(Properties.Settings.Default.RustFilesDir, "start_rust_server.bat"));
				LogMixed("INFO: ", "Server started with example start file", Color.Blue);
			}

			if (CheckCopyConnect.Checked == true)
			{
				//set clipboard to the connection command
				Clipboard.SetText("client.connect localhost 28015");
				LogMixed("INFO: ", "Connection command copied to clipboard", Color.Blue);
			}

		}

		private async void UpdateServerButton_Click(object sender, EventArgs e)
		{

			SetupServerTextbox.Text = Properties.Settings.Default.RustFilesDir;
			SetupCMDdir.Text = Properties.Settings.Default.SteamCMDDir;


			if (!ValidateInputAndUpdateSettings())
				return;

			UpdateUIForDownload();

			// Check if steamcmd.exe exists in the specified directory
			if (!await EnsureSteamCmdExists())
				return;

			// Check for selected branch type and pass the correct branch name
			if (SettingsBranchDropdown.SelectedIndex == 0)
			{
				// Main branch
				await DownloadServerFiles(false, null);
			}
			else
			{
				// Beta branch - pass the selected branch name
				await DownloadServerFiles(true, SettingsBranchDropdown.SelectedItem.ToString());
			}
		}

		private void CopyConnectButton_Click(object sender, EventArgs e)
		{
			//set clipboard to the connection command
			Clipboard.SetText("client.connect localhost 28015");
		}

		private void DiscordPic_Click(object sender, EventArgs e)
		{
			//open the default browser and go to the discord link
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://discord.gg/hbXD2YArdV",
				UseShellExecute = true
			});
		}

		private void moreStartFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (!CheckServerFilesDirectory())
			{
				LogMixed("ERROR: ", "Server files directory is missing or invalid.", Color.Red);
				return;
			}

			//generate a start file for a rust server
			CreatePROCStartBatFile(Properties.Settings.Default.RustFilesDir);

			LogMixed("FILES: ", "Procgen Start file created.", Color.Goldenrod);
		}

		private void ResetSettingsToDefault()
		{
			try
			{
				// Reset settings to default values
				Properties.Settings.Default.FirstRun = true;
				Properties.Settings.Default.RustFilesDir = string.Empty;
				Properties.Settings.Default.MapsFilesDir = string.Empty;
				Properties.Settings.Default.SteamCMDDir = string.Empty;
				Properties.Settings.Default.CheckDesktopNoti = true;
				Properties.Settings.Default.CheckFileWatcher = true;
				Properties.Settings.Default.CheckNewStart = false;
				Properties.Settings.Default.CheckToolTips = false;
				Properties.Settings.Default.CheckDeleteMap = true;
				Properties.Settings.Default.ClientMapsDir = string.Empty;

				//clear the history list settings internal file
				Properties.RunHistory.Default.HistoryList.Clear();
				Properties.RunHistory.Default.Save();

				// Save the reset settings
				Properties.Settings.Default.Save();

				// Log the reset action  
				LogMixed("INFO: ", "Settings have been reset to default.", Color.Blue);



			}
			catch (Exception ex)
			{
				HandleError(ex, "resetting settings to default");
			}
		}

		private void WriteStartfilesButton_Click(object sender, EventArgs e)
		{

			MainSnackbar.Show(this, "Are  you sure you want to reset all settings?", BunifuSnackbar.MessageTypes.Warning, 20000, "Reset Settings and Restart",
			  BunifuSnackbar.Positions.TopCenter).Then((result) =>
			  {
				  if (result == BunifuSnackbar.SnackbarResult.ActionClicked)
				  {
					  ResetSettingsToDefault();

					  // Restart the application
					  LogMixed("INFO: ", "Application is restarting with default settings...", Color.Blue);

					  // Use Application.Restart() to properly restart the application
					  System.Windows.Forms.Application.Restart();
					  this.Close();
				  }
			  });

		}


		private void AutoNextSetupCheck_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (CMDDownloadText.Text.Contains("App '258550' fully installed."))
			{
				SetupCMDNextButton.Enabled = true;
				SetupCMDNextButton.Visible = true;
				SetupCMDNextButton.Refresh();

				CMDStatusLabel.Text = "Rust files downloaded, Click next.";

				//dont trigger multiple times
				if (DropDownBranches.SelectedIndex == 0)
				{
					LogMixed("FILES: ", "Downloaded main branch files to: " + Properties.Settings.Default.RustFilesDir, Color.Goldenrod);
				}
				else
				{
					LogMixed("FILES: ", "Downloaded beta branch files to: " + Properties.Settings.Default.RustFilesDir, Color.Goldenrod);
				}

				if (AutoNextSetupCheck.Checked == true)
				{
					SetupCMDNextButton.PerformClick();
				}
			}

			if (CMDDownloadText.Text.Contains("SteamCMD updated. Now downloading Rust server files..."))
			{
				CMDStatusLabel.Text = "Downloading Rust files, Please wait.";
			}
		}

		private void MapsContextMenu_Opening(object sender, CancelEventArgs e)
		{

		}

		private void openServerDirectoryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				//string fullPath = Properties.Settings.Default.RustFilesDir;
				string Serverdirectory = Properties.Settings.Default.RustFilesDir;

				if (Directory.Exists(Serverdirectory))
				{
					LogMixed("INFO: ", "Server path opened in explorer", Color.Blue);
					Process.Start("explorer.exe", Serverdirectory);
				}
				else
				{
					HandleError(new DirectoryNotFoundException("Folder not found"), "opening server directory");
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "opening map directory");
			}
		}

		private void SetupServerTextbox_TextChange(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void SetupMapsDirectory_TextChanged(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void SetupCMDdir_TextChanged(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void CheckboxFileWatch_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
			{
				Properties.Settings.Default.CheckFileWatcher = true;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "File watcher enabled. Settings Saved.", Color.Blue);
			}
			else
			{
				Properties.Settings.Default.CheckFileWatcher = false;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "File watcher disabled. Settings Saved.", Color.Blue);
			}
		}

		private void CheckboxDesktopNoti_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
			{
				Properties.Settings.Default.CheckDesktopNoti = true;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "Desktop notifications enabled. Settings Saved.", Color.Blue);
			}
			else
			{
				Properties.Settings.Default.CheckDesktopNoti = false;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "Desktop notifications disabled. Settings Saved.", Color.Blue);
			}
		}

		private void MapsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			SyncRunHistoryWithGridView();


			//LoadRunHistoryToGrid();
		}

		private void RemoveSelectedHistoryEntry()
		{
			//if (HistoryDataView.SelectedRows.Count > 0)
			//{
			DataGridViewRow selectedRow = HistoryDataView.SelectedRows[0];

			string name = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
			string directory = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
			string date = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;

			string entryToRemove = $"{directory}\\{name}|{date}";

			// Remove from StringCollection
			if (RunHistory.Default.HistoryList != null && RunHistory.Default.HistoryList.Contains(entryToRemove))
			{
				RunHistory.Default.HistoryList.Remove(entryToRemove);
				RunHistory.Default.Save();
			}

			// Remove from DataGridView
			HistoryDataView.Rows.Remove(selectedRow);
			//}
		}

		private void SyncRunHistoryWithGridView()
		{
			try
			{
				// Ensure the RunHistory StringCollection is initialized
				if (RunHistory.Default.HistoryList == null)
				{
					RunHistory.Default.HistoryList = new StringCollection();
				}

				// Create a HashSet to track existing entries for efficient removal
				HashSet<string> existingEntries = new HashSet<string>(RunHistory.Default.HistoryList.Cast<string>());

				// Iterate through the rows of the HistoryDataView and update the StringCollection
				foreach (DataGridViewRow row in HistoryDataView.Rows)
				{
					if (!row.IsNewRow)
					{
						string name = row.Cells[0].Value?.ToString() ?? string.Empty;
						string directory = row.Cells[1].Value?.ToString() ?? string.Empty;
						string date = row.Cells[2].Value?.ToString() ?? string.Empty;

						// Combine the values into a single string
						string entry = $"{directory}\\{name}|{date}";

						// Add the entry if it doesn't already exist
						if (!existingEntries.Contains(entry))
						{
							RunHistory.Default.HistoryList.Add(entry);
						}
						else
						{
							// Remove from the HashSet to track remaining entries
							existingEntries.Remove(entry);
						}
					}
				}

				// Remove any remaining entries in the HashSet from the StringCollection
				foreach (string entry in existingEntries)
				{
					RunHistory.Default.HistoryList.Remove(entry);
				}

				// Save the updated RunHistory settings
				RunHistory.Default.Save();

				LogMixed("INFO: ", "RunHistory settings synchronized with the grid view.", Color.Blue);
			}
			catch (Exception ex)
			{
				HandleError(ex, "synchronizing RunHistory with grid view");
			}
		}

		private void HistoryDataView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			SyncRunHistoryWithGridView();
		}

		private void MapsDataGridView_DoubleClick(object sender, EventArgs e)
		{
			string serverDir = Properties.Settings.Default.RustFilesDir;
			string mapDirectory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			string mapName = MapsDataGridView.SelectedRows[0].Cells[0].Value.ToString();

			CreateAndStartMapServer(mapName, mapDirectory, serverDir);
		}

		private void HistoryDataView_DoubleClick(object sender, EventArgs e)
		{
			string serverDir = Properties.Settings.Default.RustFilesDir;
			string mapDirectory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			string mapName = MapsDataGridView.SelectedRows[0].Cells[0].Value.ToString();

			CreateAndStartMapServer(mapName, mapDirectory, serverDir);
		}

		private void CheckNewStart_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
			{
				Properties.Settings.Default.CheckNewStart = true;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "New Start file on boot enabled. Settings Saved.", Color.Blue);
			}
			else
			{
				Properties.Settings.Default.CheckNewStart = false;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "New Start file on boot disabled. Settings Saved.", Color.Blue);
			}
		}

		private void CheckDeleteClientMap_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
			{
				Properties.Settings.Default.CheckDeleteMap = true;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "New Start file on boot enabled. Settings Saved.", Color.Blue);
			}
			else
			{
				Properties.Settings.Default.CheckDeleteMap = false;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "New Start file on boot disabled. Settings Saved.", Color.Blue);
			}
		}

		private void RustGameDirbox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(RustGameDirbox);
			UpdateSettings();
		}

		private void SetupRustGameDirbox_OnIconLeftClick(object sender, EventArgs e)
		{
			SelectDirectory(SetupRustGameDirbox);
			UpdateSettings();
		}



		private void RustGameDirbox_TextChange(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void ServerFilesDirbox_TextChange(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void SteamCMDBox_TextChange(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void MapDirBox_TextChange(object sender, EventArgs e)
		{
			UpdateSettings();
		}

		private void openClientMapsDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				//string fullPath = Properties.Settings.Default.RustFilesDir;
				string Serverdirectory = Properties.Settings.Default.ClientMapsDir;

				if (Directory.Exists(Serverdirectory))
				{
					LogMixed("INFO: ", "Client maps path opened in explorer", Color.Blue);
					Process.Start("explorer.exe", Serverdirectory);
				}
				else
				{
					HandleError(new DirectoryNotFoundException("Folder not found"), "opening client maps directory");
				}
			}
			catch (Exception ex)
			{
				HandleError(ex, "opening map directory");
			}
		}

		private void CheckToolTips_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
			{
				Properties.Settings.Default.CheckToolTips = true;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "Tool tips Enabled.", Color.Blue);

				MainToolTip.Active = true;

			}
			else
			{
				Properties.Settings.Default.CheckToolTips = false;
				Properties.Settings.Default.Save();
				LogMixed("INFO: ", "Tool tips Disabled.", Color.Blue);

				MainToolTip.Active = false;
			}
		}

		private void createPrefabStartFileAndStartServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string serverDir = Properties.Settings.Default.RustFilesDir;
			string mapDirectory = MapsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			string mapName = MapsDataGridView.SelectedRows[0].Cells[0].Value.ToString();

			CreateAndStartMapServerTest(mapName, mapDirectory, serverDir);
		}

		private void HelpReadmeBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		private void CheckHelpTooltips_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
			if (CheckHelpTooltips.Checked == true)
			{
				// Show the help tooltips
				CheckToolTips.Checked = true;
				LogMixed("INFO: ", "Help tooltips enabled.", Color.Blue);
			}
			else
			{
				// Hide the help tooltips
				CheckToolTips.Checked = false;
				LogMixed("INFO: ", "Help tooltips disabled.", Color.Blue);
			}
		}


		private void TabsFoundMaps_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TabsFoundMaps.SelectedTab == HelpTab)
			{
				BottomConsolePanel.Visible = false;
			}
			else
			{
				BottomConsolePanel.Visible = true;
			}
		}

		private void CheckCarbonInstall_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{


        }

		private void CheckUmodInstall_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
		{
		
		}

        private void CheckNoPlugins_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
			if (CheckNoPlugins.Checked == true)

			{
				RadioCarbon.Checked = false;
				RadioUmod.Checked = false;
				CheckRusteditDLL.Checked = false;
            }
        }



        private void RadioUmod_Click(object sender, EventArgs e)
        {
            if (CheckNoPlugins.Checked == true)
            {
                CheckNoPlugins.Checked = false;
				RadioUmod.Checked = true;
            }
        }

        private void RadioCarbon_Click(object sender, EventArgs e)
        {
            if (CheckNoPlugins.Checked == true)
            {
                CheckNoPlugins.Checked = false;
				RadioCarbon.Checked = true;
            }
        }

        private void CheckRusteditDLL_Click(object sender, EventArgs e)
        {
            if (CheckNoPlugins.Checked == true)
            {
                CheckNoPlugins.Checked = false;
            }

            // check if radiocarbon or radioUmod is checked otherwise check radiocarbon
            if (RadioCarbon.Checked == false && RadioUmod.Checked == false)
            {
                RadioCarbon.Checked = true;
            }
        }

        private void SetupLabel_Click(object sender, EventArgs e)
        {
            HelpPanelHeader_Click(sender, e);
        }

        private void TestingMaplabel_Click(object sender, EventArgs e)
        {
            HelpPanelHeader_Click(sender, e);
        }

        private void FilewatcherLabel_Click(object sender, EventArgs e)
        {
            HelpPanelHeader_Click(sender, e);
        }

        private void CheckNoTesting_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (CheckNoTesting.Checked == true)
            {
                CheckRunExampleStart.Checked = false;
                CheckCopyConnect.Checked = false;
            }
        }

        private void CheckRunExampleStart_Click(object sender, EventArgs e)
        {
            if (CheckRunExampleStart.Checked == true)
            {
                CheckNoTesting.Checked = false;
            }
        }

        private void CheckCopyConnect_Click(object sender, EventArgs e)
        {
            if (CheckNoTesting.Checked == true)
            {
                CheckNoTesting.Checked = false;
            }
        }

        private void CheckOpenReadme_Click(object sender, EventArgs e)
        {
            if (CheckNoHelp.Checked == true)
            {
                CheckNoHelp.Checked = false;
            }
        }

        private void CheckHelpTooltips_Click(object sender, EventArgs e)
        {
            if (CheckNoHelp.Checked == true)
            {
                CheckNoHelp.Checked = false;
            }
        }

        private void CheckNoHelp_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (CheckNoHelp.Checked == true)
            {
                CheckOpenReadme.Checked = false;
                CheckHelpTooltips.Checked = false;
            }
        }

        private void CheckNoHelp_Click(object sender, EventArgs e)
        {
            if (CheckNoHelp.Checked == true)
            {
                CheckOpenReadme.Checked = false;
                CheckHelpTooltips.Checked = false;
            }
        }

    }



}