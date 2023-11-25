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

namespace _6
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
                int number = int.Parse(Number.Text);

                string result = "";

                if (number == 0)
                {
                    Result.Content = "Нулевое число";
                }

                else
                {
                    if (number > 0)
                    {
                        result += "Положительное ";
                    }
                    else
                    {
                        result += "Отрицательное ";
                    }


                    if (number % 2 == 0)
                    {
                        result += "чётное";
                    }
                    else
                    {
                        result += "нечётное";
                    }

                    Result.Content = $"{result} число";
                }

            }

            catch
            {
                Result.Content = "-";
            }
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
