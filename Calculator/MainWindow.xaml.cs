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

namespace Calculator
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
        public void Plus(object sender, RoutedEventArgs e)
        {

            double tal1 = 0;
            double tal2 = 0;
            double result = 0;

            try
            {
                tal1 = double.Parse(tbTal1.Text);
                tal2 = double.Parse(tbTal2.Text);
                result= tal1+tal2;
                TbResult.Text= result.ToString();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Woops...");
            }
            TbResult.Text = result.ToString();

        }
    }
}
