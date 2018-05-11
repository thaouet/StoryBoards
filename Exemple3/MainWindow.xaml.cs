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

namespace Exemple3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartAnimation();
        }

        private void StartAnimation()
        {
            // Path1 animation:
            path1.Freeze(); // For performance benefits.
            PointAnimationUsingPath pa =
            new PointAnimationUsingPath();
            pa.PathGeometry = path1;
            pa.Duration = TimeSpan.FromSeconds(5);
            pa.RepeatBehavior = RepeatBehavior.Forever;
            circle1.BeginAnimation(
            EllipseGeometry.CenterProperty, pa);
           
            // Path2 animation:
            path2.Freeze(); // For performance benefits.
            DoubleAnimationUsingPath daPath =
            new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path2;
            daPath.Source = PathAnimationSource.X;
            circle2.BeginAnimation(
            Canvas.LeftProperty, daPath);
            daPath = new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path2;
            daPath.Source = PathAnimationSource.Y;
            circle2.BeginAnimation(
            Canvas.TopProperty, daPath);
            double nRotation = 360 * (224 + Math.Sqrt(225 * 225 + 88 * 88)) / 2 / Math.PI / 25;
            DoubleAnimation da = new DoubleAnimation(
            0, nRotation, TimeSpan.FromSeconds(5));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            da.AccelerationRatio = 0.6;
            da.DecelerationRatio = 0.4;
            circle2Rotate.BeginAnimation(
            RotateTransform.AngleProperty, da);
        }

        }
}
