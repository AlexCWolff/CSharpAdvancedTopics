using System.Collections.Generic;

namespace CSharpAdvancedTopics
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
      
        public VideoEncoder() 
        {
           _notificationChannels = new List<INotificationChannel>();
        }
      
        public void Encode(Video video)
        {
            // video encoding logic
          
            foreach (var channel in _notificationChannels)
              channel.Send(new Message());
        }
      
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            // video encoding logic
          
            _notificationChannels.Add(channel);
        }
    }
}