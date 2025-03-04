namespace ocp;

public enum EmpType
{
    permenant,
    temperory
}
public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }


    public Employee()
    {

    }

    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;

    }

    public abstract decimal CalculateBonus(decimal salary);


    public override string ToString()
    {
        return string.Format($"Employee Id is : {Id} and Name : {Name}");
    }

}

class temperaoryemp : Employee
{


    public temperaoryemp()
    {

    }
    public temperaoryemp(int id, string name) : base(id, name)
    {

    }
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * 0.05M;
    }
}

class Permenantemp : Employee
{
    public Permenantemp()
    {

    }
    public Permenantemp(int id, string name) : base(id, name)
    {

    }
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * 0.1M;
    }
}
interface EmpBonus
{
    decimal caluclateBonus(decimal salary);
    void displayemp();
}
class contractemp : EmpBonus
{

    public int Id { get; set; }
    public string Name { get; set; }

    public contractemp()
    {

    }
    public contractemp(int id, string name)
    {
        Id = id;
        Name = name;

    }
    public decimal caluclateBonus(decimal salary)
    {
        return 0;

    }

    public void displayemp()
    {
        Console.WriteLine($"Employee Id is :{this.Id}  and Name : {this.Name}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Permenantemp(101, "ravi");
        Employee e2 = new temperaoryemp(102, "mahesh");
        EmpBonus e3 = new contractemp(103, "kiran");
        Console.WriteLine($"{e1} and bonus:{e1.CalculateBonus(30000)}");
        Console.WriteLine($"{e2} and bonus:{e2.CalculateBonus(30000)}");
        e3.displayemp();
        Console.WriteLine($" bonus: {e3.caluclateBonus(30000)} ");
    }
}
