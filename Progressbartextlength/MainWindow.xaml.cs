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

namespace Progressbartextlength
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double maxLength = 30;
        bool isRendered = false;

        public MainWindow()
        {
            InitializeComponent();
            isRendered = true;
            pbStatus.Minimum = 0;
            pbStatus.Maximum = 100;
            Textbox.Text = "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!isRendered)
            {
                return;
            }
            if (Textbox.Text.Length == 0)
            {
                pbStatus.IsIndeterminate = true;
                pbStatus.Value = Textbox.Text.Length;
            }
            if (Textbox.Text.Length > 0)
            {
                pbStatus.Value = Textbox.Text.Length * 3.333333333333;
                pbStatus.IsIndeterminate = false;
            }
            if (Textbox.Text.Length <= maxLength)
            {
                pbStatus.Foreground = Brushes.Green;

            }
            if (Textbox.Text.Length > maxLength)
            {
                pbStatus.Foreground = Brushes.Red;
            }
        }
    }
}
