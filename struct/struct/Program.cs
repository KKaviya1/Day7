using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    public struct Rectangle
    {
        public int width;
        public int height;

        public void Area()
        {
            int area = height * width;
            Console.WriteLine($"Area of rectangle {height} * {width}= {area}");
        }
    }
    public class MyClass
    {

        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect;
                Console.WriteLine("enter height");
                rect.height = int.Parse(Console.ReadLine());
                Console.WriteLine("enter width");
                rect.width = int.Parse(Console.ReadLine());
                rect.Area();
                Console.ReadKey();
            }
        }
    }

}