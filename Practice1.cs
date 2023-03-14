using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_Vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string - ReadLine, WriteLine
            // enter username - string
            Console.WriteLine("Enter username:");

            //get given output and store in function userName
            string userName = Console.ReadLine();

            // use function above to output the user's name, using Concatonation
            Console.WriteLine("Username is: " + userName);

            // C# IS CASE SENSITIVE! Converting to Upper case or Lower case:
            string someText = "Sup World!";
            Console.WriteLine(someText.ToUpper());  //returns SUP WORLD!
            Console.WriteLine(someText.ToLower());  //returns sup world!

            //NOTE: Console.ReadLine returns a string, if other datataype is passed, throws an error as it's the wrong datatype
            Console.WriteLine("Enter your age:");
            int age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);

            //to achieve this use convert (or better to use Parse, alt. TryParse if it's from user input, like here)
            Console.WriteLine("Enter your age:");
            int resultAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + resultAge);

            // Math
            // Square root
            Console.WriteLine("Enter number:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is: " + Math.Sqrt(inputNumber));

            //Modulus(%) example: checking if number is even or odd
            int number, modulus;
            Console.WriteLine("Enter absolute number to be checked ODD/EVEN:");
            number = Convert.ToInt32(Console.ReadLine());

            modulus = number % 2;

            if (modulus == 0)
            {
                Console.WriteLine("{0} is an EVEN number!", number);
            }
            else
            {
                Console.WriteLine("{0} is an ODD number!", number);
            }

            //TryParse - temperature suggestion check app
            Console.WriteLine("Is it warm enough outside?");
            string temperature = Console.ReadLine();
            int numTemp;
            int numberResult;

            if (int.TryParse(temperature,out numberResult))
            {
                numTemp = numberResult;
            }
            else
            {
                numTemp=0;
                Console.WriteLine("Value entered is not a number, setting temperature to 0");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("It would be a good idea to take a coat!");
            }
            else if (numTemp >= 20)
            {
                Console.WriteLine("Warm weather ahead, time for shorts!");
            }

        }
    }
}

