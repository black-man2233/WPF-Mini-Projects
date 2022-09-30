using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DAtabaseAndUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> Personer = new ObservableCollection<Person>();

        //Main Window 
        public MainWindow()
        {
            InitializeComponent();

            Tabelen.ItemsSource = "";

            //this.DataContext = Personer;
        }

        //Vis Data button
        //private void btnVisData_Click(object sender, RoutedEventArgs e)
        //{
        //    string PersonData = $"{Personer.Fornavn} {person.Efternavn} har en formue på {person.Formue} Kr.";

        //    MessageBox.Show(PersonData);
        //}

        //Update button
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {


        }

   
    }
}
