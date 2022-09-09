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
    class MyClass : Window

    {
        //int Tal;
        public string Navn;
         
        public MyClass()
        {

            Debug.Write("Dette er Constructoren! \n");
            
        }
        ~MyClass()
        {
            if (Navn == null)
            {
                Debug.Write("Hej " + Navn + ", dette er Destructoren! \n");

            }

                GC.Collect();

        }
    }

}
