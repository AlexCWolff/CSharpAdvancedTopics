using System;
using System.IO;

namespace CSharpAdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Alex");
            }
            catch (Exception ex)
            {
                // If 'try' fails, catch exception and writeline to console instead
                Console.WriteLine(ex.Message);
            }
            // finally
            // {
            //      Use finally when you need to make sure some code is run, like closing a handle.
            // }
        }
    }
}
