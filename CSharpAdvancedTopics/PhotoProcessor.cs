using System;

namespace CSharpAdvancedTopics 
{
    public class PhotoProcessor 
    {
        // public delegate void PhotoFilterHandler(Photo photo);
        
        public void Process(string path, Action<Photo> filterHandler) // PhotoFilterHandler filterHandler
        {
            // System.Action<> is a generic delegate that takes up to 16 parameters and does not return a value.
            // System.Func<> is a generic delegate that takes no parameters and returns up to 16 parameters.
            
            var photo = Photo.Load(path);

            filterHandler(photo);    
            
            photo.Save();
        }
    }
}