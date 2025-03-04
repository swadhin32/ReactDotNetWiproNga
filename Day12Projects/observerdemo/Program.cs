namespace observerdemo;
public interface IInvestor
{
    void Update(Stock stock);
}
public interface IStock
{
    void RegisterObserver(IInvestor investor);
    void RemoveObserver(IInvestor investor);
    void NotifyObservers();
}

public class Stock : IStock
{
    //here this list is not the list of investors  it is list of contracts taken by investor on stock
    private List<IInvestor> _investors = new List<IInvestor>(); // here  have take IInvestor which is like a contract

    private string _symbol;
    private double _price;

    public Stock(string symbol, double price)
    {
        _symbol = symbol;
        _price = price;
    }

    public string Symbol => _symbol;

    public double Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;
                NotifyObservers();
            }
        }
    }
    public void NotifyObservers()
    {
        foreach (var investor in _investors)
        {
            investor.Update(this);
        }
    }
    public void RegisterObserver(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void RemoveObserver(IInvestor investor)
    {
        _investors.Remove(investor);
    }



}

public class Investor : IInvestor
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {_name} of {stock.Symbol}'s price change to {stock.Price:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a stock and investors
        Stock appleStock = new Stock("AAPL", 120.00);
        Investor investor1 = new Investor("John Doe");
        Investor investor2 = new Investor("Jane Smith");
        // Register the investors (observers) with the stock (subject)
        appleStock.RegisterObserver(investor1);
        appleStock.RegisterObserver(investor2);

        // Change the stock price (this will notify the observers)
        appleStock.Price = 121.00;
        appleStock.Price = 123.50;

        //  Remove one investor and change the price again
        appleStock.RemoveObserver(investor1);
        appleStock.Price = 125.75;


    }
}
