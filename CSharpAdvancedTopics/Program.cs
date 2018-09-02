using System;
using System.Collections.Generic;

namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Nullable<DateTime> date = null;
            DateTime? date = null;
            // Coalescing operator. If date has a value, assign, otherwise use DateTime.Today
            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}