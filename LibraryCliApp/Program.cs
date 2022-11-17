using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCliApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Books Library!");
            Console.WriteLine("What book do you have?");
            String input = Console.ReadLine();

            // xxxxbookTitleyyy
            String bookNumber = input.Substring(0, 4);
            String bookTitle = input.Substring(4, input.Length - 7);
            String bookType = input.Substring(input.Length - 3, 3);

            Console.WriteLine("Book Number: " + bookNumber);
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("Book Type: " + bookType);

            Console.ReadKey();

        }
    }
}
