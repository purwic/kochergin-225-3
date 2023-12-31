﻿using System;
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

namespace _5
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
                double y = double.Parse(Y.Text);

                if (x > -23 && y > x && y < 0)
                {
                    Result.Content = "Да";
                }

                else if ((x == -23 && y >= x && y <= 0) || (x >= -23 && y == x && y <= 0) || (x >= -23 && y >= x && y == 0))
                {
                    Result.Content = "На границе";
                }

                else
                {
                    Result.Content = "Нет";
                }
            }

            catch
            {
                Result.Content = "-";
            }
        }


        private void Y_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
