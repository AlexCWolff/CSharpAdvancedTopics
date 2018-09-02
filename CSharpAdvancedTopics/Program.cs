namespace CSharpAdvancedTopics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Events are a mechanism for communicating between objects
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber
            
            // no brackets; this is a reference/pointer, not a function call
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; 
            // subscribers can be added without changing the publisher
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}