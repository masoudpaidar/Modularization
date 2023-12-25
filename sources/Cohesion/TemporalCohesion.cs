namespace DefaultNamespace;


public class DataBaseHandler
{
    public void SaveData() { }
    public void InsertData() { }

    public void ExportFromDbEveryWeek(DateTime dateTime)
    {
        if (DateTime.Now == dateTime.Friday)
        {
            // Todo
        }
    }
}