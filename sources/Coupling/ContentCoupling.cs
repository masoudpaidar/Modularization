namespace DefaultNamespace;

//In a content coupling, one module can modify the data of another module
public class ClassA
{
    private string _userName = "Masoud Haji";
    public string UserName => ref _userName;
}

public class ClassB
{
    public void Display(ClassA classA)
    {
        Console.WriteLine(classA.UserName);
        classA.UserName = "Another User Name";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var moduleA = new ClassA();
        var moduleB = new ClassB();

        moduleB.Display(moduleA); // Display now will alter the internal state of moduleA
        // This not only breaks encapsulation but is also highly prone to error.
    }
}