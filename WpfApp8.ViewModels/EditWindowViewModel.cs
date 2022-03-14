using WpfApp8.Core;
using WpfApp8.ViewModels.Commands;

namespace WpfApp8.ViewModels
{
    public class EditWindowViewModel:ViewModelBase
    {
        #region Commands

        public CommandAction OkCommand => new(OkButtonClick);

        #endregion

        #region Private fields
        private string? _name;
        private int _salary;
        private string? _post;
        private int _experience;
        #endregion

        #region Public properties
        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
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
        public bool HasSaved { get; private set; }

        #endregion
        
        #region Contructors
        public EditWindowViewModel()
        {
            HasSaved = false;
        }
        #endregion
        
        private void OkButtonClick()
        {
            HasSaved = true;
        }
    }
}
