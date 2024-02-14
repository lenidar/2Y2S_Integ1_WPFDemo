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

namespace _2Y2S_Integ1A_WPFDemo
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            string message = "Please enter your name!";
            if(tbUserInput.Text.Length > 0)
            {
                MessageBox.Show($"Hello there {tbUserInput.Text}");
                message = $"Hello there {tbUserInput.Text}";
            }
            else
            {
                //MessageBox.Show("Please enter your name!");
            }
            lblMessage.Content = message;
            myWindow.Title = message;
        }
    }
}
