using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        public enum DayofWeek
        {
            Monday=1,Tuesday,wednesday,Thursday,Friday,Saturday
        }
        static void Main(string[] args)
        {
            DayofWeek today = DayofWeek.Friday;
            Console.WriteLine("day: "+today);
            Console.WriteLine("day number:" + (int)today);
            Console.ReadKey();
        }
    }
}
