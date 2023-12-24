namespace DefaultNamespace;


//Sequential coupling occurs when
//the output of one module is used as the input of
//another module, creating a chain or sequence of dependencies.
//This type of coupling can be difficult to maintain and modify.
public class DataProcessor
{
    private int _rawData;
    public int LoadData(int a, int b)
    {
        _rawData = a + b
        return _rawData;
    }

    public void SaveData()
    {
        Console.WriteLine("Data Save..")
    }
}

class Program
{
    static void Main(string[] args)
    {
        var dataProcessor = new DataProcessor();

        // Sequential coupling: The sequence Load -> Process -> Save must be followed
        dataProcessor.LoadData();
        dataProcessor.SaveData();
    }
}