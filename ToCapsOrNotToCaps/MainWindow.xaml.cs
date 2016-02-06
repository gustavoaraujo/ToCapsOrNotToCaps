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

namespace ToCapsOrNotToCaps
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void caps_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.ToUpper();
        }

        private void notcaps_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.ToLower();
        }

        private void sobre_Click(object sender, RoutedEventArgs e)
        {
            using (AboutBox1 about = new AboutBox1())
                about.ShowDialog();
        }
    }
}
