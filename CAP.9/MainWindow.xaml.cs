using CAP._9.Capitulo_9;
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

namespace CAP._9
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

        private void Ejercicio1MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void Ejercicio3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void Ejercicio4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }
    }
}
