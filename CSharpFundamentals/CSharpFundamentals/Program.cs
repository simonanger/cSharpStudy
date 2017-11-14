using CSharpFundamentals.math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //System.Console.WriteLine(result);
            //var numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //System.Console.WriteLine(numbers[0]);

            var firstName = "Simon";
            var lastName = "Anger";

            var concatName = firstName + " " + lastName;

            var formatName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            System.Console.WriteLine(formattedNames);

            var text = @"Hi John
Look in to the following path
c:\folder";
            System.Console.WriteLine(text);
        }
    }
}
