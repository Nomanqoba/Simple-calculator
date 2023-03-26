using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select from the options below");
            Console.WriteLine("Press a for Addition");
            Console.WriteLine("Press b for Subtraction");
            Console.WriteLine("Press c for Multiplication");
            Console.WriteLine("Press d for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine(Please try again");
                    break;
                    }
 Console.WriteLine("The result is {0}", result);
                    Console.ReadKey();
            }
            //Addition
            public static int Addition(int input_1, int input_2)
            {
                int result = input_1 + input_2;
                return result;
            }
            //Substraction 
            public static int Subtraction(int input_1, int input_2)
            {
                int result = input_1 + input_2;
                return result;
            }
            //Multiplication 
            public static int Multiplication(int input_1, int input_2)
            {
                int result = input_1 + input_2;
                return result;
            }
            //Division 
            public static int Division(int input_1, int input_2)
            {
                int result = input_1 + input_2;
                return result;
            }
    }
}
