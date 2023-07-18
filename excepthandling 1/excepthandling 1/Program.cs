using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    public class Calculation
    {
        public static byte Add(byte num1, byte num2)

        {
            var result = num1 + num2;
            return (byte)result;
        }
    }
    internal class exception_hand
    {
        static void Main(string[] args)
        {
            byte fNum, sNum;
            try
            {
                Console.WriteLine("enter first number");
                fNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                sNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("result: \t" + Calculation.Add(fNum, sNum));

            }
            catch (FormatException fe) { Console.WriteLine("format error " + fe.Message); }
            catch (OverflowException fe) { Console.WriteLine("over flow error " + fe.Message); }
            catch (Exception ex) { Console.WriteLine("error " + ex.Message); }
            finally
            {
                Console.WriteLine("end of program!!");
                Console.ReadKey();
            }
        }
    }
}
