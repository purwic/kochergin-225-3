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

namespace _3
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
                double a1 = double.Parse(A1.Text);
                double a2 = double.Parse(A2.Text);
                double a3 = double.Parse(A3.Text);

                /*
                
                исключаем все ситуации когда равно, тогда всех возм комб вида (a1 R1 a2) && (a2 R2 a3) && (a3 R3 a1), где R1, R2, R3 - бинарные отношения, всего (верхняя оценка) 2^3 = 8
                a1 < a2 && a2 < a3 -> a1 < a3
                a1 > a2 && a2 > a3 -> a1 > a3
                тоесть всего надо проверить 8 - 2 = 6 возможных комбинаций

                */


                if (a1 == a2 || a2 == a3 || a1 == a3)
                {
                    Result.Content = $"Среднего нет";
                }



                else if ((a1 < a2 && a2 < a3) || (a1 > a2 && a2 > a3))
                {

                    Result.Content = $"Второе ({a2})";

                }

                // еще 4 комб.


                // где a1 < a2 && a2 > a3

                else if (a3 < a1 && a1 < a2)
                {

                    Result.Content = $"Первое ({a1})";

                }

                else if (a2 > a3 && a3 > a1)
                {

                    Result.Content = $"Третье ({a3})";

                }

                // где a1 > a2 && a2 < a3

                else if (a2 < a3 && a3 < a1)
                {

                    Result.Content = $"Третье ({a3})";

                }

                else if (a3 > a1 && a1 > a2)
                {

                    Result.Content = $"Первое ({a1})";

                }


            }

            catch
            {
                Result.Content = "-";
            }

        }

        private void A1_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void A2_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void A3_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
