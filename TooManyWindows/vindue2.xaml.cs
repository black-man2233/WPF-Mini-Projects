using System;
using System.Windows;

namespace TooManyWindows
{
    /// <summary>
    /// Interaction logic for vindue2.xaml
    /// </summary>
    public partial class vindue2 : Window
    {

        public string Navn
        {
            get
            {
                return Tb_2.Text;
            }
            set
            {
                Tb_2.Text = value;
            }
        }

        public vindue2()
        {
            InitializeComponent();


        }

        private void Omdøb_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();

        }

        private void Fortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();

        }
    }
}
