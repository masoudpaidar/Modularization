namespace DefaultNamespace;

public class TemperatureConverter
{
    // Converts temperature from Celsius to Fahrenheit.
    public double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Converts temperature from Fahrenheit to Celsius.
    public double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // You might include other related conversion functions here, like from Celsius to Kelvin
    // and vice versa since they all are about converting temperature scales.
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        TemperatureConverter converter = new TemperatureConverter();

        double celsius = 100;
        double fahrenheit = converter.ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} C is {fahrenheit} F");

        double backToCelsius = converter.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} F is {backToCelsius} C");
    }
}