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

namespace WPF_PasswordBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string mask;
        string buffer = null;
        int max = 0;
        int change = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buffer = TextBox.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = buffer;
            buffer = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PasswordBox.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Mask.SelectedIndex == 0)
            {
                PasswordBox.PasswordChar = (mask = "*")[0];
            }
            if (Mask.SelectedIndex == 1)
            {
                PasswordBox.PasswordChar = (mask = "#")[0];
            }
            if (Mask.SelectedIndex == 2)
            {
                PasswordBox.PasswordChar = (mask = "?")[0];
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            change++;
            Change.Content = change;
        }


        private void MaxLength_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MaxLength.Text == String.Empty)
            {
                max = 255;
                CurrentMax.Content = "Unlimited";
            }
            else
            {
                CurrentMax.Content = MaxLength.Text;
                PasswordBox.MaxLength = Convert.ToInt32(MaxLength.Text);
                TextBox.MaxLength = Convert.ToInt32(MaxLength.Text);
            }
        }
    }
}
