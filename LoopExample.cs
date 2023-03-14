using System;
using System.Net;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace VjezbaC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. for current date");
                Console.WriteLine("2. to convert currency \"Kuna\" to \"Euro\"");
                Console.WriteLine("3. to convert whole number to it's hexadecimal value");
                Console.WriteLine("4. to find out your computer hostname and IP address");
                Console.WriteLine("5. to generate a random password");
                Console.WriteLine("Press X to exit");

                ConsoleKeyInfo userInput = Console.ReadKey(true);

                switch (userInput.KeyChar)
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
            Console.Clear();
            Console.WriteLine("You selected option 1");

            string date = DateTime.UtcNow.ToString("dd-MMMM");
            Console.WriteLine("The current date is {0}", date);
        }

        static void Option2()
        {
            Console.Clear();
            Console.WriteLine("You selected option 2");

            double currencyKuna;
            Console.Write("Enter amount in Kunas:");
            currencyKuna = Convert.ToDouble(Console.ReadLine());

            double conversion = currencyKuna / 7.53450;
            double conversionRounding = Math.Round((Double)conversion, 2);
            Console.WriteLine("{0} kunas is = {1} Euros", currencyKuna, conversionRounding);
        }

        static void Option3()
        {
            Console.Clear();
            Console.WriteLine("You selected option 3");

            Console.WriteLine("Enter any whole number you wish to convert:");
            int decimalInput = int.Parse(Console.ReadLine());
            string hexValue = decimalInput.ToString("X");

            Console.WriteLine("Number {0} is = {1} in hexadecimal", decimalInput, hexValue);
        }

        static void Option4()
        {
            Console.Clear();
            Console.WriteLine("You selected option 4");

            string hostName = Dns.GetHostName();
            Console.WriteLine("Your computer (host) name is: "+ hostName);
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
        }

        static void Option5()
        {
            Console.Clear();
            Console.WriteLine("You selected option 5");

            string password = Membership.GeneratePassword(12, 1);
            Console.WriteLine("Here is your password:" + password);
        }
    }
}




//private, public, protected
//petlje - primjer izbornik (do, while)
//