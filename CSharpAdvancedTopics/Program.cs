namespace CSharpAdvancedTopics
{

    class Program
    {
        static void Main(string[] args)
        {
            // Can't instantiate abstract class
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
