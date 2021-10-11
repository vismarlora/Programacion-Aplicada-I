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
using System.Windows.Shapes;

namespace CAP._8.Capitulo_8
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
        private void MostrarCadenasButton_Click(object sender, RoutedEventArgs e)
        {
            string cadena1 = "";
            string cadena2 = "";

            cadena1 = Cadena1TextBox.Text;
            cadena2 = Cadena2TextBox.Text;

            string ordenarcad1 = new string(cadena1.OrderBy(x => x).ToArray());
            string ordenarcad2 = new string(cadena2.OrderBy(x => x).ToArray());

            MessageBox.Show($"La cadena 1: {cadena1} ordenada alfabeticamente es: {ordenarcad1}" +
                $"\nLa cadena 2: {cadena2} ordenada alfabeticamente es: {ordenarcad2}",
                "Cadenas Ordenadas Alfabeticamente", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
