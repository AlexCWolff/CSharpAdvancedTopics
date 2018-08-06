using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing, not type safe
            var list = new ArrayList();
            list.Add(1);
            list.Add("Alex");
            list.Add(DateTime.Today);

            // Throws an error
            var number = (int)list[1];

            // Use generic list instead
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Alex");
        }
    }
}
