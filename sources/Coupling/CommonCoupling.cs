namespace DefaultNamespace;

//The modules have shared data such as global data structures. The changes in global data mean
//tracing back to all modules which access that data to evaluate the effect of the change.
public class GlobalData
{
    public static string SharedState = "Initial State";
}

public class ClassA
{
    public void DisplayState()
    {
        // Accessing the global state
        Console.WriteLine(GlobalData.SharedState);
    }
}


public class ClassB
{
    public void DisplayState()
    {
        // Accessing the global state
        GlobalData.SharedState = "Change By ClassB"
    }
}

class Program
{
    static void Main(string[] args)
    {
        var moduleA = new ClassA();
        var moduleB = new ClassB();

        // Both Class are coupled through GlobalData.SharedState
        moduleA.DisplayState(); // Output: Initial State
        moduleB.ChangeState();
        moduleA.DisplayState(); // Output: Changed by ClassA
    }
}



