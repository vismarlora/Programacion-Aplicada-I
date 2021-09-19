﻿using Capitulo_7.Ejercicio;
using System;
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

namespace Capitulo_7
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

        private void Ejercicio_I_7Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_1 ejer1 = new Ejercicio_1();
            ejer1.Show();
        }

        private void Ejercicio_II_7Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_2 ejer2 = new Ejercicio_2();
            ejer2.Show();
        }

        private void Ejercicio_V_7Menutem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_5 ejer5 = new Ejercicio_5();
            ejer5.Show();
        }
    }
}
