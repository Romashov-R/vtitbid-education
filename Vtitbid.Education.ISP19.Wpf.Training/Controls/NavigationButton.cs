using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Vtitbid.Education.ISP19.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19.Wpf.Training.Controls
{
    public class NavigationButton : RadioButton
    {
        public static readonly DependencyProperty IconGeometryProperty =
            DependencyProperty.Register("IconGeometry", typeof(Geometry), typeof(NavigationButton));

        public static readonly DependencyProperty MenuItemIdentifierProperty =
            DependencyProperty.Register("MenuItemIdentifier", typeof(MenuItemIdentifier), typeof(NavigationButton), new PropertyMetadata(MenuItemIdentifier.None));

        public Geometry IconGeometry
        {
            get { return (Geometry)GetValue(IconGeometryProperty); }
            set { SetValue(IconGeometryProperty, value); }
        }

        public MenuItemIdentifier MenuItemIdentifier
        {
            get { return (MenuItemIdentifier)GetValue(MenuItemIdentifierProperty); }
            set { SetValue(MenuItemIdentifierProperty, value); }
        }
    }
}
