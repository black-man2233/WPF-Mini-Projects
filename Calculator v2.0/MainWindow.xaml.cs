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

namespace Calculator_v2._0
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


        private double Regnefunktion(char regnTegn)
        {
            double tal1 = 0;
            double tal2 = 0;
            double result = 0;

            try
            {
                tal1 = double.Parse(tbTal1.Text);
                tal2 = double.Parse(tbTal2.Text);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Woops...");
            }

            if(regnTegn == '+')
            {
                result = tal1 + tal2;
            }
            
            if(regnTegn == '-')
            {
                result = tal1 - tal2;
            }
            
            if(regnTegn == '*')
            {
                result = tal1 * tal2;
            }
            
            if(regnTegn == '/')
            {
                result = tal1 / tal2;
            }

            return result;
        }

        public void Plus(object sender, RoutedEventArgs e)
        {
            sign.Content = " +";
            double resultat = Regnefunktion('+');
            tbResult.Text = resultat.ToString();
        }


        public void Minus(object sender, RoutedEventArgs e)
        {
            sign.Content = " -";
            double resultat = Regnefunktion('-');
            tbResult.Text = resultat.ToString();
        }

        public void Gange(object sender, RoutedEventArgs e)
        {
            sign.Content = " *";
            double resultat = Regnefunktion('*');
            tbResult.Text = resultat.ToString();
        }
        
        public void Divider(object sender, RoutedEventArgs e)
        {
            sign.Content = " /";
            double resultat = Regnefunktion('/');
            tbResult.Text = resultat.ToString();
        }

    }
}
