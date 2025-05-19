using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMapTestRust
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Create form instance and pass arguments
			MainForm mainForm = new MainForm();

			if (args.Length > 0)
			{
				string mapFile = args[0];
				if (Path.GetExtension(mapFile).ToLower() == ".map")
				{
					// Make sure settings are loaded first
					mainForm.LoadSettings();
					mainForm.HandleDroppedMap(mapFile);
				}
			}

			Application.Run(mainForm);
		}
	}
}