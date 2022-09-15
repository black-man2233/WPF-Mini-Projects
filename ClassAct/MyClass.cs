using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassAct 
{
    class MyClass : MainWindow

    {
        
        public int Tal { get; private set; }
        public string Navn { get; private set; }
        public MyClass()
        {
            Debug.Write("Dette er Default Constructoren!");
        }

        public MyClass(int tal, string navn)
        {
            Tal = tal;
            Navn = navn;
            Debug.Write("Dette er Non-default Constructoren!");
        }

    }

}
