using CAP._8.Capitulo_8;
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

namespace CAP._8
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

        private void Ejercicio3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void Ejercicio5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }
    }
}
