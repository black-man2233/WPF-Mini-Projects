﻿using System;
using System.Collections.Generic;
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

namespace ClassAct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyClass myClass = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_btn(object sender, RoutedEventArgs e)
        {
            myClass = new MyClass();
            myClass.Navn = "Kevin";
            Text_Box.Text = myClass.Navn;
        }

        private void Destroy_btn(object sender, RoutedEventArgs e)
        {
            myClass = null;
            GC.Collect();

        }
    }
}
