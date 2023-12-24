namespace DefaultNamespace;

public class DataEncryptor
{
    public byte[] EncryptData(string data)
    {
        // Imaginary encryption process (not real encryption)
        byte[] encryptedData = System.Text.Encoding.UTF8.GetBytes(data);
        for (int i = 0; i < encryptedData.Length; i++)
        {
            encryptedData[i] ^= 0xA5; // XOR operation with a dummy key
        }
        return encryptedData;
    }
}

public class DataSender
{
    // The following method is functionally coupled with DataEncryptor.EncryptData
    public void SendEncryptedData(string data, DataEncryptor encryptor)
    {
        var encryptedData = encryptor.EncryptData(data);
        // Imaginary data sending process
        Console.WriteLine($"Sending encrypted data: {BitConverter.ToString(encryptedData)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data = "Sensitive Data";
        var encryptor = new DataEncryptor();
        var sender = new DataSender();

        sender.SendEncryptedData(data, encryptor);
    }
}