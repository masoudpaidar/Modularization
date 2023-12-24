namespace DefaultNamespace;


public enum Operation : byte
{
    pluse = 0,
    subtraction = 1
}

public class Operation
{
    public int GenerateOperation(Operation operation,int a,int b)
    {
        switch (operation)
        {
            case Operation.pluse:
                return a + b;
                break;
            case Operation.subtraction:
                return a - b;
                break;
            default:
                Console.WriteLine("Not Found Operation")
                return 0;
                break;
        }
        
    }
}


class Program
{
    static void Main(string[] args)
    {
        var operation = new Operation();

        // The behavior of GenerateReport is controlled by the type of report passed to it
        operation.GenerateOperation(Operation.pluse,1,2);  // Control coupling// Control coupling
        operation.GenerateOperation(Operation.subtraction,2,1);  // Control coupling// Control coupling
    }
}