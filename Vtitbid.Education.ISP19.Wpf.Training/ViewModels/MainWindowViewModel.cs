using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using Vtitbid.Education.ISP19.Wpf.Training.Commands;
using Vtitbid.Education.ISP19.Wpf.Training.Controls;
using Vtitbid.Education.ISP19.Wpf.Training.Models;
using Vtitbid.Education.ISP19.Wpf.Training.Views;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private UserControl _currentMainControl;        
        private MenuItemIdentifier _currentMainControlIdentifier;
        private readonly Dictionary<MenuItemIdentifier, UserControl> _mainControls;

        public MenuItemIdentifier CurrentMainControlIdentifier
        {
            get => _currentMainControlIdentifier;
            set => Set(ref _currentMainControlIdentifier, value, nameof(CurrentMainControlIdentifier));
        }

        public UserControl CurrentMainControl
        {
            get => _currentMainControl;
            set => Set(ref _currentMainControl, value, nameof(CurrentMainControl));
        }

        public ICommand ChangeMainControlCommand
        {
            get => new SimpleCommand(id =>
            {
                if (!_mainControls.TryGetValue((MenuItemIdentifier)id, out var userControl))
                    return;
                CurrentMainControl = userControl;
            });
        }

        public MainWindowViewModel()
        {
            _mainControls = new Dictionary<MenuItemIdentifier, UserControl>();            
            _mainControls.Add(MenuItemIdentifier.Students, new StudentsView());
            _mainControls.Add(MenuItemIdentifier.Employees, new EmployeesView());
        }
    }
}
