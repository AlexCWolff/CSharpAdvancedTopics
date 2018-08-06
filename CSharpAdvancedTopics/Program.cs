using System;

namespace CSharpAdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Upcast
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            // Downcast
            Shape shape2 = new Text();
            Text text2 = (Text) shape2;
        }
    }
}
