using System;

namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // A delegate is a pointer to a method with a signature
            // Every delegate is essentially a class that derives from System.Delegate and System.MulticastDelegate
            // Use a delegate over an interface when: 
            // An eventing design pattern is used 
            // The caller doesn't need access to other properties and methods on the object implementing the method.
            
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            // Can even declare and use delegates here
            filterHandler += RemoveRedEyeFilter;
            
            processor.Process("photo.jpg", filterHandler);
        }
        
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}