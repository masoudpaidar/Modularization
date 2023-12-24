namespace DefaultNamespace;

// Stamp coupling 
// occurs when a module  passes a data structure to another module
// which then makes use of part of that structure. In other words, the receiving module
// has knowledge of the data structure format and accesses several elements of it.
public class Student
{
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string StudentId { get; set; }
    public string Email { get; set; }
}

public class StudentProcessor
{
    public void RecognizeStudent(Student student)
    {
        // some code logic
        Console.WriteLine($"Student with this id -> {student.StudentId} has been detect")
        // some code logic
    }

    public void SendStudentScores(Student student)
    {
        // some logic
        Console.WriteLine($"Score for {student.FirstName student.Lastname} Has Send to {student.Email}")
        // some logic
    }
}


class Program
{
    static void Main(string[] args)
    {
        var student = new Student
        {
            FirstName = "jennifer",
            Lastname = "lawrence",
            StudentId = "A876BN",
            Email = "jenniferlawrence@gmail.com",
        };

        // Stamp coupling occurs here.
        var studentProcessor = new StudentProcessor();
        studentProcessor.RecognizeStudent(student);
        studentProcessor.SendStudentScores(student);

        
    }
}