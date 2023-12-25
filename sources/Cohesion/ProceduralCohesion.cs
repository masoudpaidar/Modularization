namespace DefaultNamespace;

public class ProcessDataHandelr
{
    public void ProcessData(string filePath)
    {
        var Data = LoadData(filePath);

        for (int i = 0; i < Data.Count(); i++)
        {
            if (ValidateData(Data[i]))
            {
                InsertData(Data[i]);
            }
        }

        LogData();

    }


    public List<string> LoadData(string filePath)
    {
        // Some Logic
        Console.writeLine("Load The Data.....");
    }

    public bool ValidateData(string Data)
    {
        // logic
        Console.writeLine("ValidateData.....");
    }

    public void InsertData(string data)
    {
        // logic
        Console.writeLine("InsertData.....");
    }

    public void LogData()
    {
        // logic
        Console.writeLine("LogData.....");
    }
}