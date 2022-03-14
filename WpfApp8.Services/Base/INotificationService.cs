namespace WpfApp8.Services.Base;

public interface INotificationService
{
    void NotifyError(string text, string caption);
}