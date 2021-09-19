using Capitulo_6.Ejercicios;
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

namespace Capitulo_6
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

        private void Ejercicio_I_6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_1 ejercicio =  new Ejercicio_1();
            ejercicio.Show();
        }

        private void Ejercicio_II_6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_2 ejercicio2 = new Ejercicio_2();
            ejercicio2.Show();
        }

        private void Ejercicio_III_6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_3 ejercicio3 = new Ejercicio_3();
            ejercicio3.Show();
        }

        private void Ejercicio_IV_6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_4 ejercicio4 = new Ejercicio_4();
            ejercicio4.Show();
        }

        private void Ejercicio_V_6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_5 ejercicio5 = new Ejercicio_5();
            ejercicio5.Show();
        }
    }
}
