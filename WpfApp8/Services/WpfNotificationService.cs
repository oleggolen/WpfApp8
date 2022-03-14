using System.Windows;
using WpfApp8.Services.Base;

namespace WpfApp8.Services;

public class WpfNotificationService : INotificationService
{
    public void NotifyError(string text, string caption) =>
        MessageBox.Show(text, caption, MessageBoxButton.OK, MessageBoxImage.Error);

}