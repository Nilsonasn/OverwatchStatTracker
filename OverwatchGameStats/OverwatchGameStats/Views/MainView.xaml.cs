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
using System.Windows.Shapes;

namespace OverwatchGameStats.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void DisablePickers(object sender, RoutedEventArgs e)
        {
            CheckBox tempBox = sender as CheckBox;
            if(CurrentTime.IsChecked == true)
            {
                GameData_GameDate.IsEnabled = false;
                cBoxHr.IsEnabled = false;
                cBoxMin.IsEnabled = false;
            }
            else
            {
                GameData_GameDate.IsEnabled = true;
                cBoxHr.IsEnabled = true;
                cBoxMin.IsEnabled = true;
            }
        }
    }
}
