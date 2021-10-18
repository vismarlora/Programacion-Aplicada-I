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

namespace CAP._12.CAP12
{
    /// <summary>
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ObservarButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;

            int numero = int.Parse(NumeroTextBox.Text);

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine("Ha entrado a la Funcion");

                factorial *= i;

                Console.WriteLine("Ha salido de la funcion, y Factorial es en la entrada" + i + factorial);
            }
            MessageBox.Show($"El Factorial de {numero} es: {factorial}");
        }
    }
}
