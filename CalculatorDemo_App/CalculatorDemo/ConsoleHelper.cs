using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintToConsole(this double answer)
        {
            Console.WriteLine(answer);
        }

        public static string RequestString(this string message) 
        {
            string output;
            while (true)
            {
                Console.Write(message);
                output = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(output) == true)
                {
                    break;
                }
                else
                {
                    "Enter in correct format.".PrintToConsole();
                    Console.Write("\n");
                }
                
            }
            return output;
        }

        public static double RequestDouble(this string message) 
        {
            double output;
            string textNum;
            

            while (true) 
            {
                Console.WriteLine();
                Console.Write(message);
                textNum = Console.ReadLine();
                if (double.TryParse(textNum, out output))
                {
                    break;
                }
                else
                {
                    "Put in valid number".PrintToConsole();
                    Console.WriteLine();
                }
            }

            return output;
        }

        public static List<double> RequestNumbers(this string message) 
        {
            
            List<double> output = new List<double>();
            string input;
            $"{message}".PrintToConsole();

            while (true)
            {
                Console.Write("(Type in number or 'done' to finish): ");
                input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }
                if (double.TryParse(input, out double number))
                {
                    output.Add(number);
                }
                else
                {
                    "That's not a valid number. Please try again.".PrintToConsole();
                    Console.Write("\n");
                }

            }   

            return output;
                
        }

    }
}
