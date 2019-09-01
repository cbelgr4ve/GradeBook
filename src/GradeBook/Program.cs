using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            double x = 34.1;
            double y = 66.6;
            double average = (x + y) / 2;

            if(args.Length > 0)
            {  
            Console.WriteLine($"Hello, {args[0]}! Your average is {average}%!");
            } 
            else {
            Console.WriteLine("Hello!");
            }   
        }
    }
}
