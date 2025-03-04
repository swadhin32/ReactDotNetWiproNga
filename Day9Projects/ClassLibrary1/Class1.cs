namespace ClassLibrary1;
[AttributeUsage(AttributeTargets.method)]
public class AddNumbers : Attribute
{
    private int _num1;
    private int _num2;

    public AddNumbers(int num1, int num2)
    {
        _num1 = num1;
        _num2 = num2;
    }

    public int Add()
    {
        return _num1 + _num2;
    }
    public int Substract()
    {

        return _num1 - _num2;
    }
}


