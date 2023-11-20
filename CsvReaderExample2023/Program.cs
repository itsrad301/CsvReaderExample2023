using Microsoft.EntityFrameworkCore;
using Week4.Console;

namespace CsvReaderExample2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // How could you return a random number of 10 students?
            using(SchoolContext schoolContext = new SchoolContext(new DbContextOptions<SchoolContext>()))
            {
                // Take the first 10 students
                foreach (var item in schoolContext.Students.Take(10))
                {
                    Console.WriteLine($"Student ID {item.StudentID} First Name {item.FirstName} Second Name: {item.SecondName}");
                }
            }
            Console.ReadKey();
        }
    }
}