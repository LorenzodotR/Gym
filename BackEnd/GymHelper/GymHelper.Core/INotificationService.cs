namespace GymHelper.Core
{
    public interface INotificationService
    {
        Task SendNotification(Model.Notification notification);
    }
}
