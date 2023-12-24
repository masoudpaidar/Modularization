namespace DefaultNamespace;


/*Data coupling is a level on the coupling scale where modules share data with one another. 
The idea is that the only connection between various modules should be data that they need to share*/
public class Bmi
{
    public int Weight { get; set; }
    public int Height { get; set; }

    public Bmi(int weight ,int height)
    {
        Weight = weight;
        Height = height;
    }

    public int CalculateBmi()
    {
        return Weight / Height * Height;
    }
}

public class BmiPrinter
{
    public void PrintBmi(Bmi person)
    {
        int bmi = person.CalculateBmi();
        Console.WriteLine("The bmi of the person is: " + bmi);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var person = new Bmi(60, 2);
        var printer = new BmiPrinter();
        
        printer.PrintArea(person); // Data coupling happens here where person is passed to PrintArea method.
    }
}