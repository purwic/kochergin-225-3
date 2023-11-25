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

namespace _7
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

                if (!(1 <= number && number <= 999))
                {
                    throw new ArgumentOutOfRangeException();
                }

                else
                {

                    if (number % 2 == 0)
                    {
                        result += "Чётное ";
                    }
                    else
                    {
                        result += "Нечётное ";
                    }

                    if ($"{number}".Length == 1)
                    {
                        result += "однозначное";
                    }
                    
                    else if ($"{number}".Length == 2)
                    {
                        result += "двузначное";
                    }

                    else if ($"{number}".Length == 3)
                    {
                        result += "трёхзначное";
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
