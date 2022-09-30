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
using TwoWayTest;

namespace TwoWaysTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> Personer = new ObservableCollection<Person>();
        Person person = new Person(12, "Svend", "Bendt", 123);

        //Main Window 
        public MainWindow()
        {
            InitializeComponent();

            Personer.Add(person);
            Personer.Add(new Person(0, "Bein", "Stagge", -987654321));
            Personer.Add(new Person(1, "Turt", "Khorsen", 0));


           // this.DataContext = Personer;



        }

        //Vis Data button
        private void btnVisData_Click(object sender, RoutedEventArgs e)
        {
            string PersonData = $"{person.Fornavn} {person.Efternavn} har en formue på {person.Formue} Kr.";

            MessageBox.Show(PersonData);
        }

        //Update button
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Personer.Add(new Person(2, "Gill", "Bates", int.MaxValue));

        }
    }
}
