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

namespace _2
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


        private void compute()
        {

            try
            {

                double first = double.Parse(First.Text);
                double second = double.Parse(Second.Text);

                if(first < second)
                {
                    Smallest.Content = $"Первое ({first})";
                }

                else if(first > second)
                {
                    Smallest.Content = $"Второе ({second})";
                }

                else
                {
                    Smallest.Content = "Меньшего нет (они равны)";
                }
            }

            catch
            {

            }

        }


        private void First_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void Second_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
