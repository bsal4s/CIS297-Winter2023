using System.Numerics;

namespace Week1_WithTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int someBigNumber = 1_236_987;

            int[] numbers = { 1, 2, 3, 4, 5 };

            int[] usersNumbers = new int[5];

            for (int index = 0; index < usersNumbers.Length; index++)
            {
                Console.WriteLine($"Enter number {index + 1}");
                usersNumbers[index] = Convert.ToInt32(Console.ReadLine());
            }

            // throws exception on bad indexes, yay!
            //usersNumbers[6] = 42;

            foreach (var userNumber in usersNumbers)
            {
                Console.WriteLine(userNumber);
            }

            var name = "Eric";

            // strings can't be changed in methods - they are immuatable
            changeString(name);

            var number = SomeMethodDoesThisSpeicalThingOtherThing();

            double otherNumber = 4.2;

            double copyNumber = otherNumber;

            Console.WriteLine("Please enter a number");
            var input = Console.ReadLine();

            var inputAsNumeric = int.Parse(input);
            inputAsNumeric = Convert.ToInt32(input);

            if (inputAsNumeric > 0 && inputAsNumeric < 100)
            {
                Console.WriteLine("Your number is 0-100");
            }
            else
            {
                Console.WriteLine("Too high or too low");
            }

            var result = inputAsNumeric > 100 ? "too high" : "ok";




            Console.WriteLine($"{otherNumber} * {inputAsNumeric} == {otherNumber * inputAsNumeric}");

            Console.WriteLine($"5 / 2 == {5 / 2}");
            Console.WriteLine($"5 / 2.0 == {5 / 2.0}");
            Console.WriteLine($"5 / {inputAsNumeric} == {5 / inputAsNumeric}");

            Console.WriteLine($"What is 5 + 6/2*3");

            Console.Beep(1000, 1000);



            SomeFunction();
            SomeMethodDoesThisSpeicalThingOtherThing();
        }

        static void changeString(string value)
        {
            value = "Test";
        }

        static int doubleNumber(int number) => number * 2;

        static int doubleNumberLongForm(int number)
        {
            return number * 2;
        }

        static string getChoice(int choice)
        {
            string response;
            response = choice switch
            {
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };
            return response;
        }

        static bool IsOneBiggerThanTwo(int number1, int number2)
        {
            return number1 >= number2;
        }

        static void SomeFunction()
        {
            Console.WriteLine("Some function");
        }

        static double SomeMethodDoesThisSpeicalThingOtherThing()
        {
            return 7.7;
        }
    }
}