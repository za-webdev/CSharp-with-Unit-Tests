using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTesting
{
    class Program
    {
        public static string num1;
        public static string num2;
        public static string wish;

        public static void FirstNum()
        {
            
            num1 = Console.ReadLine();
            if (num1.ToLower() == "exit")
                Environment.Exit(0);
            if (!num1.All(char.IsDigit))
            {
                Console.WriteLine("invalid,try again");
                //FirstNum(int num);
            }
        }
        public static void SecondNum()
        {
            Console.WriteLine("enter second number");
            num2 = Console.ReadLine();
            if (num2.ToLower() == "exit")
                Environment.Exit(0);
            if (!num2.All(char.IsDigit))
            {
                Console.WriteLine("invalid, try again");
                SecondNum();
            }
        }

        public static void Operator()
        {
            Console.WriteLine("Choose an Operator  (add,multiply,divide)");
            var input = Console.ReadLine();
            if (input.ToLower() == "add" || input == "+")
            {
                Add();
            }

            else if (input.ToLower() == "multiply" || input == "*")
            {
                Multiply();
            }

            else if (input.ToLower() == "divide" || input == "/")
            {
                Divide();
            }
            else
            {
                //if a different operator is entered other than options provided
                Console.WriteLine("Please select from the provided options");
                Operator();
            }
        }
        public static void Add()
        {
            var sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Console.WriteLine("Sum is {0}:", sum);
        }

        public static void Multiply()
        {
            var answer = Convert.ToInt32(num1) * Convert.ToInt32(num2);
            Console.WriteLine(answer);
        }

        public static void Divide()
        {
            if (Convert.ToInt32(num1) == 0 || Convert.ToInt32(num2) == 0)
                Console.WriteLine("Err");

            else
            {
                var result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                var remainder = Convert.ToInt32(num1) % Convert.ToInt32(num2);
                Console.WriteLine("{0} and reaminder is {1}", result, remainder);
            }
        }
        static void Main(string[] args)
        {
            var demo = new Demo(new ConsoleInput());
            do
            {
                demo.ReadExample();
                //Handles second number entered
                //FirstNum();
                //Handles second number entered
                SecondNum();
                //handles the Math operations
                Operator();
                //Prompts if the user wish to continue
                Console.WriteLine("Do you wish to continue? yes/no");
                wish = Console.ReadLine();
                if (wish.ToLower() == "no" || wish.ToLower() == "n")
                {
                    break;
                }
            }
            while (wish.ToLower() == "yes" || wish.ToLower() == "y");
        }
        
    }
}
