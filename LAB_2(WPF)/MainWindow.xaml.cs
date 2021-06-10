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

namespace LAB_2_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
       List<double>list = new List<double>();

        Func<double, double> rb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbSin_Checked(object sender, RoutedEventArgs e)
        {
            rb = Math.Sin;
        }

        private void rbCos_Checked(object sender, RoutedEventArgs e)
        {
            rb = Math.Cos;
        }

        private void rbTg_Checked(object sender, RoutedEventArgs e)
        {
            rb = Math.Tan;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
   
            string str;
            double result = 0;
            double x = Convert.ToDouble(tb1.Text);
            double fx = rb(x);
            double m = Convert.ToDouble(tb2.Text);

            

            if (m > -1 & m < x)
            {
                str = "Ветвь 1: -1<m<х";
                result = Math.Sin(5 * fx + 3 * m * Math.Abs(fx));
            }

            else if (x < m)
            {
                str = "Ветвь 2: х<m";
                result = Math.Cos(3 * fx + 5 * m * Math.Abs(fx));
            }

            else if (x == m)
            {
                str = "Ветвь 3: х=m";
                result = Math.Pow((fx + m), 2);
            }
            else
            {
                str = "значение не определено";
            }

           

            list.Add(result);

            double a = list.Max();
            double b = list.Min();

            lbl.Content = result.ToString() + '\n';
            lbl.Content += str;
            if (cbMax.IsChecked == true)
            { lbl.Content += $"\n max={a:0.#####}"; }
            if (cbMin.IsChecked == true)
            { lbl.Content += $"\nmin={b:0.#####}"; }


        }
            
       
        
    }
}
