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

namespace _2Y2S_Integ1A_WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _nameInput = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
            if(tbUserInput.Text.Length > 0)
            {
                _nameInput = tbUserInput.Text;
                MessageBox.Show($"Welcome to my first application {_nameInput}");
                lblMessage.Content = $"Welcome to my first application {_nameInput}";
                myWindow.Title = $"Welcome to my first application {_nameInput}";

            }
        }
    }
}
