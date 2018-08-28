namespace CSharpAdvancedTopics
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}