namespace DefaultNamespace;

public class InvoiceProcessor
{
    private List<InvoiceItem> _items;
    private decimal _total;
    private decimal _taxRate;

    public InvoiceProcessor(List<InvoiceItem> items, decimal taxRate)
    {
        _items = items;
        _total = 0m;
        _taxRate = taxRate;
    }

    // Processes each invoice item by calculating its total and tax.
    public void ProcessInvoice()
    {
        CalculateTotal();
        CalculateTax();
        PrintInvoice();
    }

    private void CalculateTotal()
    {
        foreach (var item in _items)
        {
            _total += item.Price * item.Quantity;
        }
    }

    private void CalculateTax()
    {
        var tax = _total * _taxRate;
        Console.WriteLine($"Tax: {tax:C2}");
    }

    private void PrintInvoice()
    {
        Console.WriteLine($"Total before tax: {_total:C2}");
        Console.WriteLine($"Total with tax: {_total * (1 + _taxRate):C2}");
    }
}

public class InvoiceItem
{
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}