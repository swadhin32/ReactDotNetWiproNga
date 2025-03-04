namespace ISP;

public interface IPrinter
{
    void Print(string content);
}

public interface IScanner
{
    void Scan(string content);
}
public interface IFax
{
    void Fax(string content);
}
public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print(string content)
    {
        Console.WriteLine("Printing content: " + content);
    }

    public void Scan(string content)
    {
        Console.WriteLine("Scanning content: " + content);
    }

    public void Fax(string content)
    {
        Console.WriteLine("Faxing content: " + content);
    }
}

public class SimplePrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing content: " + content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using MultiFunctionPrinter, which supports printing, scanning, and faxing
        MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.Print("MultiFunctionPrinter: Document 1");
        multiFunctionPrinter.Scan("MultiFunctionPrinter: Document 1");
        multiFunctionPrinter.Fax("MultiFunctionPrinter: Document 1");

        // Using SimplePrinter, which only supports printing
        SimplePrinter simplePrinter = new SimplePrinter();
        simplePrinter.Print("SimplePrinter: Document 2");

        Console.ReadLine();
    }
}
