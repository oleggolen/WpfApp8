using System.Windows.Input;

namespace WpfApp8.ViewModels.Commands;

public class CommandAction : ICommand
{
    public bool CanExecute(object? parameter) => true;
    private readonly Action _commandAction;

    public CommandAction(Action action) => _commandAction = action;


    public void Execute(object? parameter) => _commandAction?.Invoke();


    public event EventHandler? CanExecuteChanged;
}