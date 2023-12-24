namespace DefaultNamespace;

//Temporal coupling refers to a scenario
//where the order of execution matters for
//certain functions or methods — that is,
//some methods need to be called in a specific sequence.
//When temporal coupling is not obvious from the method names or not properly documented,
//it can lead to execution flow that’s difficult to understand or maintain
public class Account
{
    public void Create()
    {
        Console.WriteLine("Account created.");
    }

    public void Initialize()
    {
        Console.WriteLine("Account initialized with default values.");
    }

    public void Activate()
    {
        Console.WriteLine("Account activated.");
    }
}

public class AccountProcess
{
    public void ProcessAccount()
    {
        var account = new Account();

        // Temporal coupling: methods must be called in a correct sequence.
        account.Create();
        account.Initialize();
        account.Activate();
    }
}