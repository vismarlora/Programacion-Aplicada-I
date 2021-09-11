using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo_4
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
       
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int numbase = 0;
            int exponente = 0;
            int container = 1;
            int resultado = 1;

            String numero;
            String potencia;

            numero = this.NumeroTextBox.Text;
            potencia = this.PotenciaTextBox.Text;

            int.TryParse(numero, out numbase);
            int.TryParse(potencia, out exponente);


            //container = numbase;

            for (int i = 0; i < exponente; i++)
            {
                container = resultado;

                resultado = numbase * container;

            }

            this.PotenciaTextBox.Clear();
            this.NumeroTextBox.Clear();
            
            MessageBox.Show($"{resultado}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
