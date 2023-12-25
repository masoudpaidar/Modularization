namespace DefaultNamespace;

public class GodObject
{
    // This method calculates tax but has nothing to do with the other methods.
    public decimal CalculateTax(decimal amount)
    {
        const decimal taxRate = 0.20m; // Let's assume a flat 20% tax rate.
        return amount * taxRate;
    }

    // This method sends an email, which is usually a separate concern.
    public void SendEmail(string toAddress, string subject, string body)
    {
        // Logic to send an email
        // ...
    }
    
    // This method generates a random number, which is a separate responsibility.
    public int GenerateRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    // Imagine more unrelated methods here that further blur the purpose of the class.
}
