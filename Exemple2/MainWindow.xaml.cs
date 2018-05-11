using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exemple2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Storyboard sb = new Storyboard();
            ColorAnimation ca1 =
            new ColorAnimation(
            Colors.Blue, Colors.Yellow,
            new Duration(new TimeSpan(0, 0, 10)));
            ca1.RepeatBehavior = RepeatBehavior.Forever;
            ca1.AutoReverse = true;
            Storyboard.SetTargetName(ca1, "brush1");
            Storyboard.SetTargetProperty(ca1,
            new PropertyPath(SolidColorBrush.ColorProperty));
            ColorAnimation ca2 =
            new ColorAnimation(Colors.Red, Colors.Green,
            new Duration(new TimeSpan(0, 0, 10)));
            ca2.RepeatBehavior = RepeatBehavior.Forever;
            ca2.AutoReverse = true;
            ca2.BeginTime = new TimeSpan(0, 0, 5);
            Storyboard.SetTargetName(ca2, "brush2");
            Storyboard.SetTargetProperty(ca2,
            new PropertyPath(
            SolidColorBrush.ColorProperty));
            sb.Children.Add(ca1);
            sb.Children.Add(ca2);
            sb.Begin(this);
        }
    }
}
