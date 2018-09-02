using System;

namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Lambdas are anonymous functions; they have no access modifier, name, or return statement
            // 'args => expression'
            // '() => ...' if no arg
            // 'x => ...' if one arg
            // '(x, y, z) => ...' if multiple args
            
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}