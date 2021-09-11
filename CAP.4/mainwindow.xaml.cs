using Capitulo_4.Ejercicios;
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

namespace Capitulo_4
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

        private void Ejercicio1Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_1 ejc1 = new Ejercicio_1();
            ejc1.Show();
        }

        private void Ejercicio2Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_2 ejc2 = new Ejercicio_2();
            ejc2.Show();
        }

        private void Ejercicio5Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_5 ejc5 = new Ejercicio_5();
            ejc5.Show();
        }
    }
}
