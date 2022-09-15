using System.Windows;
using System.Windows.Controls;

namespace TooManyWindows
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vindue2 vindue = new vindue2();
            vindue.Navn = "Kevin";
            vindue.ShowDialog();
            vindue.Tb_2.Text = vindue.Navn;


            if (vindue.DialogResult == true)
            {
                Tb_1.Text = "Hej med dig " + vindue.Navn;
            }
            else
            {
                Tb_1.Text = $"Du hedder stadig {vindue.Navn}";
            }



        }
    }
}
