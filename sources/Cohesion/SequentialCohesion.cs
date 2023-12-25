namespace DefaultNamespace;

public class StudentDataProcessor
{
    public void Run(string path)
    {
        try
        {
            var students = new List<Student>();
            var result = ProcessStudentInfo(students);
            var report = GenerateReport(result);
            var storeReprt = StoreReport(report);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public List<Student> ProcessStudentInfo(List<Student> student)
    {
        // logic
        Console.WriteLine("ProcessStudentInfo....");
        return new List<Student>();
    }

    public string GenerateReport(List<Student> student)
    {
        // logic
        Console.WriteLine("GenerateReport....");
        return new List<Student>();
    }
    
    public string StoreReport(List<Student> student)
    {
        // logic
        Console.WriteLine("GenerateReport....");
        return new List<Student>();
    }
}


public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }
}