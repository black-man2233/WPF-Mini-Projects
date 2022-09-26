using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAtabaseAndUi
{

    //Grunden til dette, er at en almindelig liste ikke kan melde tilbage omkring ændringer til selve listen.Men det kan en ObservableCollection.Og så skal vi ikke selv opdatere vores brugerflade, hver gang vi laver ændringer til den lokale liste med de kommende insert, delete og update funktioner..

    public class DAL
    {
        private ObservableCollection<Person> DataBase; //Da vi ikk ehar adgang til en database
        //simulere vi med denne private liste

        private ObservableCollection<Person> _publicListe; // Dette er objektet med elemener vi "deler ud " til brugeren af vores class.

        //Constructiren generer data til falske database

        public DAL()
        {
            DataBase = new ObservableCollection<Person>();
            DataBase.Add(new Person(0, "Svend", "Bendt", 1234));
            DataBase.Add(new Person(1, "Bein", "Stagge", -987654321));
            DataBase.Add(new Person(2, "Turt", "Khorsen", 0));
            DataBase.Add(new Person(3, "Gill", "Bates", int.MaxValue));

            _publicListe = new ObservableCollection<Person>();

        }

        // Get henter data fra datasen og kopier det over i den lokale kopi
        public ObservableCollection<Person> Get()
        {
            _publicListe.Clear(); //Første tømmes den lokale kopi

            //så løber vi alle elementerne i databsen og overføre til lokal kopi

            foreach (Person p in DataBase)
            {
                _publicListe.Add(p);
            }
            return _publicListe;

        }

        //Commit indsætter vores lokae kopi af datai databasen
        public void Commit()
        {
            DataBase = new ObservableCollection<Person>(_publicListe);
        }



    }
}
