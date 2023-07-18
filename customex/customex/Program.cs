using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace customex
{
    public class CustomException:Exception
    {
        public CustomException(string message):base(message) 
        {
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int userAge;
                Console.WriteLine("enter your age");
                userAge = int.Parse(Console.ReadLine());
                if(userAge<0)
                {
                    throw new CustomException("Age must be positive number, please enter positive number only");

                }
                else if(userAge>=18)
                {
                    Console.WriteLine("your are eligible for voting");
                }
                else
                {
                    Console.WriteLine("your are not eligible for voting, you have to wait");
                }
            }
            catch(CustomException ce) { Console.WriteLine("customer error !! "+ ce.Message); }
            catch (Exception ex) { Console.WriteLine("error !! " + ex.Message); }
            finally { Console.WriteLine("** Bye Bye **");
                Console.ReadKey();

            }
        }

    }
}
