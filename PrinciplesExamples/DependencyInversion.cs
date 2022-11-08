namespace PrinciplesExamples;

// High level modules shouldn't depend on low level modules
// IoC - ( Inversion of Control ) is pattern that implements this pattern
// DI - ( Dependency Injection ) is a pattern that implements IoC
public interface INotificationProvider
{
    // Formats specially for provider
    Task FormatNotificationContext(string content);

    // Sends the notification
    Task Send(int userId, string title, string content);
}

public class EmailProvider : INotificationProvider
{
    
}

public interface INotificationService
{
    
}

public class NotificationService : INotificationProvider
{
    private readonly INotificationProvider _notificationProvider;

    public NotificationService(INotificationProvider notificationProvider)
    {
        _notificationProvider = notificationProvider;
    }

    public Task SendNotification(int senderId, int receiverId, string title, string content)
    {
        // Create notification record
        
        // Add notification to queue
        
        // Retry if service oro task fails
        
        // Retry other providers
    }
}