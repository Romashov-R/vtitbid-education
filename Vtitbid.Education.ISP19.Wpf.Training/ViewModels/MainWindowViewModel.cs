using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Vtitbid.Education.ISP19.Wpf.Training.Models;
using Vtitbid.Education.ISP19.Wpf.Training.Views.Lists;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels
{
    public class MainWindowViewModel : MenuViewModel
    {
        public MainWindowViewModel()
        {
            _controls = new Dictionary<MenuItemIdentifier, Control>()
            {
                [MenuItemIdentifier.MainLists] = new ListsUserControl()
            };
            
            Control = _controls[MenuItemIdentifier.MainLists];
        }
    }
}
