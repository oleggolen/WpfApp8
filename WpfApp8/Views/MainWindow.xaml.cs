using WpfApp8.Services;
using WpfApp8.ViewModels;

namespace WpfApp8.Views
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel(new SimpleEmployeeLoader(), new WpfNotificationService(), new WpfNavigationService());
            InitializeComponent();
        }
    }
}
