using System;
using System.Collections.Generic;

namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            dynamic b = 10;
            // will be dynamic
            var c = a + b;

            int i = 5;
            // will be integer
            dynamic d = i;
            // implicit cast from int to long
            long l = d;
        }
    }
}