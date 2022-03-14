using WpfApp8.Core;
using WpfApp8.Services.Base;
using WpfApp8.Views;

namespace WpfApp8.Services;

public class WpfNavigationService : INavigationService
{
    public void Navigate(ViewModelBase viewModel)
    {
        var editWindow = new EditWindow
        {
            DataContext = viewModel
        };
        editWindow.ShowDialog();
    }
}