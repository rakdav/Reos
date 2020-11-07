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

namespace reostats
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            R1.IsEnabled = false;
            R2.IsEnabled = false;
            R3.IsEnabled = false;
        }

        private void cb1_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.IsChecked == true) R1.IsEnabled = true;
            else R1.IsEnabled = false;
        }

        private void cb2_Click(object sender, RoutedEventArgs e)
        {
            if (cb2.IsChecked == true) R2.IsEnabled = true;
            else R2.IsEnabled = false;
        }

        private void cb3_Click(object sender, RoutedEventArgs e)
        {
            if (cb3.IsChecked == true) R3.IsEnabled = true;
            else R3.IsEnabled = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                double r1, r2, r3;
                double R = 0;
                if (cb1.IsChecked == true)
                {
                    r1 = double.Parse(R1.Text);
                    R += r1;
                }

                if (cb2.IsChecked == true)
                { 
                    r2 = double.Parse(R2.Text);
                    R += r2;
                }

                if (cb3.IsChecked == true)
                {
                    r3 = double.Parse(R3.Text);
                    R += r3;
                }
                Result.Text = "Соединение последовательное\n" + "Общее сопротивление:" + R+" Oм";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
