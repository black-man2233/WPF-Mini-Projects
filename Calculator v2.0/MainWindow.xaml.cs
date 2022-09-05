using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        enum Regnetegn
        {
            Plus,
            Minus,
            Divider,
            Gange
        }

        /// <summary>
        /// Denne funktion henter udgiver resultat af textblockerne i plus, minu, gange og dividering
        /// </summary>
        /// <param name="regnTegn"></param>
        /// <returns></returns>
        private double Regnefunktion(Regnetegn regnTegn)
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

            if(regnTegn == Regnetegn.Plus)
            {
                result = tal1 + tal2;
            }
            
            if(regnTegn == Regnetegn.Minus)
            {
                result = tal1 - tal2;
            }
            
            if(regnTegn == Regnetegn.Gange)
            {
                result = tal1 * tal2;
            }
            
            if(regnTegn == Regnetegn.Divider)
            {
                result = tal1 / tal2;
            }

            return result;
        }

        //Plus knappen trykkes
        public void Plus(object sender, RoutedEventArgs e)
        {
            sign.Content = " +";

            double resultat = Regnefunktion(Regnetegn.Plus);
            tbResult.Text = resultat.ToString();
        }

        //Minus knappen trykkes
        public void Minus(object sender, RoutedEventArgs e)
        {
            sign.Content = " -";
            double resultat = Regnefunktion(Regnetegn.Minus);
            tbResult.Text = resultat.ToString();
        }

        //Gange knappen trykkes
        public void Gange(object sender, RoutedEventArgs e)
        {
            sign.Content = " *";
            double resultat = Regnefunktion(Regnetegn.Gange);
            tbResult.Text = resultat.ToString();
        }

        //Dividere knappen trykkes
        public void Divider(object sender, RoutedEventArgs e)
        {
            sign.Content = " /";
            double resultat = Regnefunktion(Regnetegn.Divider);
            tbResult.Text = resultat.ToString();
        }

    }
}
