using System.Windows;
using System.Windows.Controls;

namespace Vtitbid.Education.ISP19.Wpf.Training.Controls
{
    public class NavigationButton : RadioButton
    {
        public string ControlIdentifier
        {
            get { return (string)GetValue(ControlIdentifierProperty); }
            set { SetValue(ControlIdentifierProperty, value); }
        }

        public Image Image
        {
            get { return (Image)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ControlIdentifierProperty =
            DependencyProperty.Register("ControlIdentifier", typeof(string), typeof(NavigationButton));

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(Image), typeof(NavigationButton));
    }
}
