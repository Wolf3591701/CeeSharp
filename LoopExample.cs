using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Option 4");
                Console.WriteLine("5. Option 5");
                Console.WriteLine("Press X to exit");

                ConsoleKeyInfo input = Console.ReadKey(true);

                switch (input.KeyChar)
                {
                    case '1':
                        Option1();
                        break;
                    case '2':
                        Option2();
                        break;
                    case '3':
                        Option3();
                        break;
                    case '4':
                        Option4();
                        break;
                    case '5':
                        Option5();
                        break;
                    case 'x':
                    case 'X':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid key pressed, please choose one between 1-5");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Option1()
        {
            Console.WriteLine("You selected option 1");
        }

        static void Option2()
        {
            Console.WriteLine("You selected option 2");
        }

        static void Option3()
        {
            Console.WriteLine("You selected option 3");
        }

        static void Option4()
        {
            Console.WriteLine("You selected option 4");
        }

        static void Option5()
        {
            Console.WriteLine("You selected option 5");
        }
    }
}




//private, public, protected
//petlje - primjer izbornik (do, while)
//