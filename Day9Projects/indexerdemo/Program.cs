namespace indexerdemo;
class abcd
{
    public int[] _numbers = new int[5];

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < _numbers.Length)
            {
                return _numbers[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < _numbers.Length)
            {
                _numbers[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

        }


    }

    public void displaynumbers()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}:{_numbers[i]}");
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        abcd abcdobj = new abcd();
        abcdobj[0] = 230;
        abcdobj[1] = 330;
        abcdobj[2] = 230;
        abcdobj[3] = 330;
        abcdobj[4] = 230;
        //  abcdobj[5] = 230;// error here 
        Console.WriteLine($"{abcdobj[4]}");
        //    Console.WriteLine($"{abcdobj[5]}");//not possible error 

        abcdobj.displaynumbers();


    }
}
