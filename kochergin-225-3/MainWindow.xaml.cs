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

namespace kochergin_225_3
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


        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                int digit_1 = int.Parse($"{Number.Text[0]}");
                int digit_2 = int.Parse($"{Number.Text[1]}");

                if ((digit_1 + digit_2) % 2 == 0)
                {
                    Sum.Content = "Чётна";
                }
                else
                {
                    Sum.Content = "Нечётна";
                }


            }
            catch
            {
                Sum.Content = "-";
            }

        }
    }
}
