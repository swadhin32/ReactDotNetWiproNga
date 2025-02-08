namespace CSharp7and8ewFeature_TuplesandDeconstruction
{
    internal class Program
    {
        public static (string Name, int Age, bool IsActive) GetPersonInfo()
        {
            return ("Jane Doe", 25, false);
        }
        
        static void Main(string[] args)
        {
            //create a tuple it is a variable which will have multiple types 
            (string Name, int Age, bool IsActive) person = ("John doe", 30, true);

            //accessing person data 

            Console.WriteLine($"Name:{person.Name} ,Age:{person.Age},IsActive:{person.IsActive}");
            // like this below i cannot print 

            // Console.WriteLine($"Name:{Name} ,Age:{Age},IsActive:{IsActive}");

            // Using tuple deconstruction to unpack the tuple into variables
            var (name1, age1, isActive1) = person;

            // Accessing the deconstructed values
            Console.WriteLine($"Deconstructed - Name: {name1}, Age: {age1}, IsActive: {isActive1}");

            // Returning a tuple from a function
            var personInfo = GetPersonInfo();
            Console.WriteLine($"From Function - Name: {personInfo.Name}, Age: {personInfo.Age}, IsActive: {personInfo.IsActive}");

            // Deconstructing tuple returned from a function
            var (personName, personAge, personIsActive) = GetPersonInfo();
            Console.WriteLine($"From Deconstruction - Name: {personName}, Age: {personAge}, IsActive: {personIsActive}");


            Console.ReadLine();
        }
    }
}
