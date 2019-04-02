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

namespace Clicker
{
    
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int PointsCount = 0;
        public static int PointsAdder = 1;

        private void SetPoints()
        {
            PointsLabel.Content = $"Ilość punktów: {PointsCount}";
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickerButton_Click(object sender, RoutedEventArgs e)
        {
            PointsCount += PointsAdder;
            SetPoints();
        }
    }
}
