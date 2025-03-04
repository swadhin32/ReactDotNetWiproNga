namespace factorydemo;
// Product Interface
public interface IDocument
{
    void Open();
    void Save();
}

// Concrete Product 1: PDF Document
public class PDFDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF document.");
    }

    public void Save()
    {
        Console.WriteLine("Saving PDF document.");
    }
}

// Concrete Product 2: Word Document
public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word document.");
    }

    public void Save()
    {
        Console.WriteLine("Saving Word document.");
    }
}

// Abstract Factory Class
public abstract class DocumentFactory
{
    // Factory Method
    public abstract IDocument CreateDocument();
}

// Concrete Factory 1: PDF Document Factory
public class PDFDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PDFDocument();
    }
}

// Concrete Factory 2: Word Document Factory
public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //  PDF Document Creation first way 
        IDocument obj = new PDFDocument();
        obj.Open();
        obj.Save();
        obj = new WordDocument();
        obj.Open();
        obj.Save();

        // scond way of using factory method 

        DocumentFactory obj2 = new PDFDocumentFactory();
        IDocument pdffile = obj2.CreateDocument();
        pdffile.Save();
        pdffile.Open();

        Console.ReadLine();
    }
}
