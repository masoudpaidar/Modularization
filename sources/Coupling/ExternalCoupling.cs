namespace DefaultNamespace;
//In external coupling, the modules depend on other modules,
//external to the software being developed or to a particular type of hardware.
//Ex- protocol, external file, device format, etc.
public class FileLogger
{
    private readonly string _loggerPath;

    public FileLogger(string loggerPath)
    {
        _loggerPath = loggerPath;
    }

    public void logMessage(string msg)
    {
        File.AppendAllText(_loggerPath, $"{message}\n");
    }
}



class Program
{
    static void Main(string[] args)
    {
        var logger = new FileLogger("logFile.txt");
        
        // This operation is dependent on the external file ("logFile.txt").
        logger.LogMessage("This is a log message");
    }
}