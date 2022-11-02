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

namespace Wpf_Chemeris_PR4
{
    /// <summary>
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Window11 window11 = new Window11();
            window11.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window10 window10 = new Window10();
            window10.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
        }
    }
}
