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

namespace W1501PreGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMoveLeft(object sender, RoutedEventArgs e)
        {
            int x = Grid.GetColumn(Ball);
            if (x < 1) 
                return;
            Grid.SetColumn(Ball, x - 1);
        }
        private void OnMoveRight(object sender, RoutedEventArgs e)
        {
            int x = Grid.GetColumn(Ball);
            if (x > Board.ColumnDefinitions.Count - 2)
                return;
            Grid.SetColumn(Ball, x + 1);
        }
        private void OnMoveUp(object sender, RoutedEventArgs e)
        {
            int y = Grid.GetRow(Ball);
            if (y < 1)
                return;
            Grid.SetRow(Ball, y - 1);
        }
        private void OnMoveDown(object sender, RoutedEventArgs e)
        {
            int y = Grid.GetRow(Ball);
            if (y > Board.RowDefinitions.Count - 3)
                return;
            Grid.SetRow(Ball, y + 1);
        }
    }
}
