using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            try
            {
                Console.WriteLine("enter first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter second number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("result after adding {0} and {1} = {2}", num1, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error!!"+ex.Message);
            }
            finally
            {
                Console.WriteLine("end of program!!");
                Console.ReadKey();
            }
        }
    }
}
