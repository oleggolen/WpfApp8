using WpfApp8.Core;

namespace WpfApp8.Services.Base;

public interface INavigationService
{
    void Navigate(ViewModelBase viewModel);
}