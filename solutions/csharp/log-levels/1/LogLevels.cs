static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":");

        if(index == -1) return logLine.Trim();

        return logLine.Substring(index+2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int index = logLine.IndexOf(":");
        return logLine.Substring(0,index).Trim().Substring(1,index-2).ToLower();  
    }

    public static string Reformat(string logLine)
    {
        int index = logLine.IndexOf(":");
        string level = logLine.Substring(1,index-2).ToLower().Trim();
        string message = logLine.Substring(index+2).Trim();

        return $"{message} ({level})";
    }
}
