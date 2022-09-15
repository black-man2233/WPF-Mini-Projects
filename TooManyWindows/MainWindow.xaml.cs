using System.Windows;
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

            /*med .Show, kan man navigere mellem alle vinduer
            //vindue.Show();
            derimod med .ShowDialog kan man ikke gå til den første vindue hvis man ikke har lukket det nuværende vidnue*/

            vindue.ShowDialog();
            vindue.Tb_2.Text = vindue.Navn;


        }
    }
}
