using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structex
{
    public struct Student
    {
        int id;
        string name;
        public Student(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        public void Display()
        { 
            Console.WriteLine($"student ID: {id} & Student Name: {name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12, "viya");
            student.Display();
            Student student1 = new Student(16, "kavi");
            student1.Display();
            Console.ReadKey();
        }
    }
}
