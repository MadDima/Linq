using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Book
    {
        public string Name;
        public string Author;
        public int Year;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book() { Name = "Harry Doter 1", Year = 1111, Author = "Juan Crawling" },
                new Book() { Name = "Harry Doter 2", Year = 1111, Author = "Juan Crawling" },
                new Book() { Name = "Harry Doter 3", Year = 1111, Author = "Juan Crawling" },
                new Book() { Name = "Mein Kampf", Year = 1925, Author = "Adolg Hitler" },
                new Book() { Name = "LINQ", Year = 2000, Author = "Some guy" },
                new Book() { Name = "ololo", Year = 2017, Author = "Vasya"}
            };

            foreach (var item in books.Where(f => f.Name == "LINQ"&&f.Year%4 == 0))
            {
                Console.WriteLine(item.Name+" "+item.Year+" - "+item.Author);
            }
            String input = ("baba misha, golubaya luna, yo ho ho");
            Console.WriteLine(input.Distinct().Count());

            int[] numbers = { 11, 11, 33, 44, 56, 52, 55, 77, 88, 32, 74, 72, 78, 36, 41, 49, 89, 81 };
            var sortedNumbers = numbers.OrderBy(f => f / 10).ThenByDescending(f => f % 10);
            foreach (var item in sortedNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in books.GroupBy(book => book.Author))
            {
                Console.WriteLine("{0,-20} - {1,3}", item.Key, item.Count());
            }
        }
    }
}
