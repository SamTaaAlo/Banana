using System;

namespace ConsoleApp
{
    public class Program{
        public static void Main(string[] args)
        {
            int age = 15;
            float grade = 1.5f;
            char lal = 'A';
            string name = "Tom";
            bool bestanden = true;

            Console.WriteLine("alter: " + age);
            Console.WriteLine("Note: " + grade);
            Console.WriteLine("name: " + name);
            Console.WriteLine("Buchstabe: " + lal);
            Console.WriteLine("bestanden: " + bestanden);
        }
    }
}