using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Extension methods will most often be used, not created. 
            // Microsoft recommends making them only when you absolutely need to because of the possibility of namespace conflicts in the future.
            string post = "This is a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();
            
            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
}