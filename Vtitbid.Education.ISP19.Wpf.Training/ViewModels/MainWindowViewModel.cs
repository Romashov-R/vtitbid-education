using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using Vtitbid.Education.ISP19.Wpf.Training.Commands;
using Vtitbid.Education.ISP19.Wpf.Training.Views;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private UserControl _currentMainControl;        
        private readonly Dictionary<string, UserControl> _mainControls;

        public MainWindowViewModel()
        {
            _mainControls = new Dictionary<string, UserControl>();            
            _mainControls.Add("Students", new StudentsView());
            _mainControls.Add("Employees", new EmployeesView());
        }

        public ICommand ChangeMainControlCommand 
        {
            get => new SimpleCommand(controlName =>
            {
                CurrentMainControl = GetMainControlByName((string)controlName);
            });
        }

        private UserControl GetMainControlByName(string controlName)
        {
            UserControl userControl = null;
            
            switch(controlName)
            {
                case "Students": _mainControls.TryGetValue(controlName, out userControl); break;
                case "Employees": _mainControls.TryGetValue(controlName, out userControl); break;
            }

            return userControl;
        }

        public UserControl CurrentMainControl
        { 
            get => _currentMainControl;
            set => Set(ref _currentMainControl, value, nameof(CurrentMainControl));
        }
    }
}
