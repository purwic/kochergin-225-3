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

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void compute()
        {

            try
            {

                double x = double.Parse(X.Text);
                double k = double.Parse(K.Text);

                if (k == 3)
                {
                    Y.Content = $"{Math.Sin(x) + 2}";
                }

                else if (k == 20)
                {
                    Y.Content = $"{Math.Cos(Math.Pow(x, 2))}";
                }

                else if (k == 10 || k == 15)
                {
                    Y.Content = $"{Math.Tan(x) + Math.Sin(x)}";
                }

                else
                {
                    Y.Content = "Не определён";
                }
            }

            catch
            {
                Y.Content = "-";
            }

        }
        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void K_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
