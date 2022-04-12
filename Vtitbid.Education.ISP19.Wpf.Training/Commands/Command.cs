using System;
using System.Windows.Input;

namespace Vtitbid.Education.ISP19.Wpf.Training.Commands
{
    public abstract class Command : ICommand
    {
        protected Action<object> _command;
        protected Predicate<object>? _predicate;
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            if (_predicate == null)
                return true;

            return _predicate(parameter);
        }

        public virtual void Execute(object? parameter)
        {
            _command(parameter);
        }

        protected virtual void OnCanExecuteChanged(object sender, EventArgs e)
        {
            CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
