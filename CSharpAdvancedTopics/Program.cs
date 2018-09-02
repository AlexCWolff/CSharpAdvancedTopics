using System;
using System.Linq;

namespace CSharpAdvancedTopics
{
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            
            // LINQ Query Operators
            // Very similar to SQL
            var cheaperBooks = from b in books 
                                where b.Price < 10
                                orderby b.Title
                                select b.Title;
            
            // LINQ Extension Methods
            // Extension methods have more capabilities than query operators.
            // Prefer extension methods except in cases where query operators make more sense.
            // 'Where' filters the results, 'OrderBy' sorts the results, and 'Select' grabs the property. 
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);
            
            foreach (var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook);
            
            // Single result or default. 'Single' also exists but will error if nothing is found.
            var singleBook = books.SingleOrDefault(b => b.Title == "Title 1");
            
            Console.WriteLine(singleBook == null);
            
            // Last result or default. 'First' also exists.
            var lastBook = books.LastOrDefault(b => b.Title == "Title 5");
            
            Console.WriteLine(lastBook.Title + " " + lastBook.Price);
            
            // Iterable, skips the first 2 results and takes the next 3
            var pagedBooks = books.Skip(2).Take(3);
        
            foreach (var pagedBook in pagedBooks)
                Console.WriteLine(pagedBook.Title);
            
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var sumPrice = books.Sum(b => b.Price);
            
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(sumPrice);
        }
    }
}