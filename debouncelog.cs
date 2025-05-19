// These methods implement a debounced logging system
// Add after LoadSettings method:

public void LogMixedDebounced(string category, string message, Color mcolor)
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

// Replace the SetupProcessOutputHandlers method with this:

private void SetupProcessOutputHandlers(Process process)
{
    process.OutputDataReceived += (s, args) =>
    {
        if (args.Data \!= null)
        {
            // Debounce similar output lines
            DateTime now = DateTime.Now;
            if (args.Data == lastLoggedLine && (now - lastLoggedTime) < TimeSpan.FromMilliseconds(1000))
            {
                // Skip this duplicate line that came too quickly
                return;
            }

            lastLoggedLine = args.Data;
            lastLoggedTime = now;

            CMDDownloadText.Invoke((MethodInvoker)delegate
            {
                CMDDownloadText.AppendText(args.Data + Environment.NewLine);
                // Auto-scroll to the bottom
                CMDDownloadText.SelectionStart = CMDDownloadText.Text.Length;
                CMDDownloadText.ScrollToCaret();
            });
        }
    };
    
    process.ErrorDataReceived += (s, args) =>
    {
        if (args.Data \!= null)
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
