using System.Collections.ObjectModel;
using WpfApp8.Core;
using WpfApp8.Models;
using WpfApp8.Services.Base;
using WpfApp8.ViewModels.Commands;

namespace WpfApp8.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Commands

        public CommandAction AddCommand => new(OpenAddWindow);
        public CommandAction EditCommand => new(OpenEdit);
        public CommandAction DeleteCommand => new(Delete);

        #endregion
        
        #region Private fields
        private EmployeeModel? _selectedEmployer;
        #endregion

        #region Public properties
        public ObservableCollection<EmployeeModel> Employees { get;  }
        public EmployeeModel? SelectedEmployee
        {
            get => _selectedEmployer;
            set
            {
                _selectedEmployer = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }
        #endregion

        #region Services

        private readonly INotificationService _notificationService;
        private readonly INavigationService _navigationService;
        

        #endregion
        
        #region Constructors
        public MainWindowViewModel(IEmployeesLoader employeesLoader, INotificationService notificationService, INavigationService navigationService)
        {
            _notificationService = notificationService;
            _navigationService = navigationService;
            Employees = new ObservableCollection<EmployeeModel>(employeesLoader.LoadEmployees());
        }
        
        #endregion

        #region Private methods
        private void Delete()
        {
            if (SelectedEmployee != null)
                Employees.Remove(SelectedEmployee);
            else
                _notificationService.NotifyError("Выберите работника", "Ошибка");
        }

        

        #endregion

        private void OpenAddWindow()
        {
            var edit = new EditWindowViewModel();
            _navigationService.Navigate(edit);
            if (edit.HasSaved)
            {
                Employees.Add(new EmployeeModel()
                {
                    Experience = edit.Experience,
                    Post = edit.Post ?? "",
                    Salary = edit.Salary,
                    FIO = edit.Name ?? ""
                });
            }
        }

        private void OpenEdit()
        {
            var edit = new EditWindowViewModel();
            if (SelectedEmployee != null)
            {
                edit.Name = SelectedEmployee.FIO;
                edit.Salary = SelectedEmployee.Salary;
                edit.Post = SelectedEmployee.Post;
                edit.Experience = SelectedEmployee.Experience;
                _navigationService.Navigate(edit);
            }
            else
            {
                _notificationService.NotifyError("Выберите работника", "Ошибка");
                return;
            }
            if (!edit.HasSaved) 
                return;
            SelectedEmployee.FIO = edit.Name ?? "";
            SelectedEmployee.Post = edit.Post;
            SelectedEmployee.Salary = edit.Salary;
            SelectedEmployee.Experience = edit.Experience;
        }


    }
}