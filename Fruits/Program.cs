using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to search: ");
            string input = Console.ReadLine();
            string filePath = @"C:\Users\solis\source\repos\Palindrome\Palindrome\bin\Debug\Fruits.txt";
            bool isFound = false;


            List<string> fruits = new List<string> {
            "apple", "banana", "orange", "pineapple", "mango",
            "strawberry", "grapefruit", "kiwi", "peach", "cherry"
        };


            if (fruits.Contains(input.ToLower()))
            {
                Console.WriteLine($"{input} is a fruit.");
            }


            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(input))
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"The input '{input}' is found in the file.");
            }
            else
            {
                Console.WriteLine($"The input '{input}' is not found in the file.");
            }
        }
    }
}
