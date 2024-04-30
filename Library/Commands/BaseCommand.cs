using System.Windows.Input;

namespace Library.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public abstract void Execute(object? parameter);
    }
}
