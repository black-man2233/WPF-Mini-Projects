using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // Tilføjes i toppen af din C# fil!
using System.Runtime.CompilerServices;

namespace TwoWayTest
{

    class Person : INotifyPropertyChanged
    {
        public int ID;
        //fornanv properti
        private string _fornavn;
        public string Fornavn
        {
            get
            {
                return _fornavn;
            }
            set
            {
                _fornavn = value;
                OnPropertyChanged("Fornavn");
            }
        }
        //Eftervnan properti
        private string _efternavn;
        public string Efternavn
        {
            get
            {
                return _efternavn;
            }
            set
            {
                _efternavn = value;
                OnPropertyChanged("Efternavn");

            }
        }
        //formue properti
        private int _formue;
        public int Formue
        {
            get
            {
                return _formue;
            }
            set
            {
                _formue = value;
                OnPropertyChanged("Formue");
            }
        }

        public Person(int ID, string Fornavn, string Efternavn, int Formue)
        {
            this.ID = ID;
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Formue = Formue;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyNavn)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyNavn));
            }
        }
    }



}
