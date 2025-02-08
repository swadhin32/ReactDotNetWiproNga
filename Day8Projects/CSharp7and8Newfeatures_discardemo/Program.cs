namespace CSharp7and8Newfeatures_discardemo
{
    internal class Program
    {
        static (string Name, int Age, bool IsActive) GetPersonInfo()
        {
            return ("John Doe", 30, true);
        }
        static void Main(string[] args)
        {
            var person = GetPersonInfo();
            Console.WriteLine($"Name:{person.Name},Age:{person.Age},IsActive:{person.IsActive}");

            var (name, age, isactive) = person;
            Console.WriteLine($"Name:{name},Age:{age},IsActive:{isactive}");

            // i want to destructure also also want to ignore some value like age 

            var (name1, _, isactive1) = person;
            Console.WriteLine($"Name:{name1},IsActive:{isactive1}");

            Console.ReadLine();
        }
    }
}
