using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWPF.Command
{
    class RelayCommand : ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;
        bool canExecuteCache;

        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute, bool CanExecuteCache)
        {
            this.execute = Execute;
            this.canExecute = CanExecute;
            this.canExecuteCache = CanExecuteCache;
        }

        public bool CanExecute(object? parameter)
        {
            if (canExecute != null)
            {
                return true;
            }
            else
            {
                return CanExecute(parameter);
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                if(!canExecuteCache)
                {
                    CommandManager.RequerySuggested += value;   
                }
            }
            remove
            {
                if (!canExecuteCache)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }


        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
