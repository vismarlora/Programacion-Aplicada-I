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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void ObservarButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;

            int numero = int.Parse(NumeroTextBox.Text);

            for (int i = numero; i >= 1; i--)
            {
                factorial *= i;
            }
            MessageBox.Show($"El Factorial de {numero} es: {factorial}");
        }
    }
}
