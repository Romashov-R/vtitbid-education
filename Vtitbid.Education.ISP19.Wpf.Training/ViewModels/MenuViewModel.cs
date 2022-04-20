using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using Vtitbid.Education.ISP19.Wpf.Training.Commands;
using Vtitbid.Education.ISP19.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels
{
    public abstract class MenuViewModel : ViewModel
    {
        protected Dictionary<MenuItemIdentifier, Control> _controls;
        protected Control _control;

        public Control Control 
        { 
            get => _control; 
            set => Set(ref _control, value, nameof(Control)); 
        }

        public ICommand ChangeControlCommand 
        {
            get => new SimpleCommand(id =>
            {
                if (!_controls.TryGetValue((MenuItemIdentifier)id, out Control control))
                    return;
                Control = control;
            });
        }
    }
}
