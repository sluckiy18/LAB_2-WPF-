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

namespace LAB_2._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char oper;
        double result;
        double x;
        public MainWindow()
        {
            InitializeComponent();

          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (tb.Text=="0")
                tb.Text= (sender as Button)?.Content.ToString();
            else
            tb.Text += (sender as Button)?.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tb.Text.IndexOf(",") < 0)
                tb.Text += ",";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            x= Convert.ToDouble(tb.Text);
            oper = (sender as Button).Content.ToString()[0];
            tb.Text = "0";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            double y = Convert.ToDouble(tb.Text);
            
            result = 0;

            switch (oper)
            {
                case '+': result = x + y; break;
                case '-': result = x - y; break;
                case '*': result = x * y; break;
                case '/': result = x / y; break;
            }
            tb.Text = result.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tb.Clear();
            tb.Text = "0";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tb.Text = tb.Text.Substring(0,tb.Text.Length-1);
            if (tb.Text == "")
                tb.Text = "0";
        }
    }
}
