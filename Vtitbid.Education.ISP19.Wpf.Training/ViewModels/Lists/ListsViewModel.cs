using System.Collections.Generic;
using System.Windows.Controls;
using Vtitbid.Education.ISP19.Wpf.Training.Models;
using Vtitbid.Education.ISP19.Wpf.Training.Views.Lists;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels.Lists
{
    public class ListsViewModel : MenuViewModel
    {
        public ListsViewModel()
        {
            _controls = new Dictionary<MenuItemIdentifier, Control>()
            {
                [MenuItemIdentifier.ListsSpecialitites] = new SpecialititesUserControl()
            };

            Control = _controls[MenuItemIdentifier.ListsSpecialitites];
        }
    }
}
