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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L05_recursion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Create a StackPanel to contain the shape.
            StackPanel myStackPanel = new StackPanel();
            myStackPanel.VerticalAlignment = VerticalAlignment.Bottom;

            //var rectangle = DrawRectangle();

            //rectangle.VerticalAlignment = VerticalAlignment.Bottom;
            // Add the shape to the StackPanel.
            myStackPanel.Children.Add(DrawRectangle());

            this.Content = myStackPanel;
        }

        private static Rectangle DrawRectangle()
        {
            // Create shape.
            var rectangle = new Rectangle();

            // Create color brush.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values.
            // Each value has a range of 0-255.
            var color = Colors.Gray;
            mySolidColorBrush.Color = color;
            //rectangle.Fill = mySolidColorBrush;
            rectangle.StrokeThickness = 2;
            rectangle.Stroke = mySolidColorBrush;

            // Set the width and height of the shape.
            rectangle.Width = 100;
            rectangle.Height = 100;
            rectangle.Margin = new Thickness(0, 10, 0, 10);
            return rectangle;
        }
    }
}