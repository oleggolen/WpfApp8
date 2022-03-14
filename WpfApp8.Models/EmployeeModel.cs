using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp8.Core.Utils;

namespace WpfApp8.Models
{
    public sealed class EmployeeModel : INotifyPropertyChanged
    {
        #region Private fields

        private string? _fio;
        private int _salary;
        private string? _post;
        private int _experience;

        #endregion

        #region INotifyPropertyChanged realization
        
        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Public Properties
        public string? FIO
        {
            get => _fio;
            set
            {
                _fio = value;
                OnPropertyChanged(nameof(FIO));
            }
        }
        public int Salary
        {
            get => _salary;
            set
            {
                _salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }

        public string? Post
        {
            get => _post;
            set
            {
                _post = value;
                OnPropertyChanged(nameof(Post));
            }
        }

        public int Experience
        {
            get => _experience;
            set
            {
                _experience = value;
                OnPropertyChanged(nameof(Experience));
            }
        }
        #endregion

    }
}
