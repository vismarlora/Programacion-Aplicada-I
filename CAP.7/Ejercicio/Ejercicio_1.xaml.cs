using System;
using System.Collections;
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

namespace Capitulo_7.Ejercicio
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        ArrayList notas = new ArrayList();
        public static int minimo = 1, maximo = 1, contador = 0;

        public static float promedio = 0.00f, AcumuladorSuma = 0;
        public Ejercicio_1()
        {
            InitializeComponent();
        }
        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0; 

            n = ToInt(CalificacionTextBot.Text);

            if (CalificacionTextBot.Text != "")
            {
                notas.Add(ToInt(CalificacionTextBot.Text));

                CalificacionTextBot.Text = "";

                contador++;

                AcumuladorSuma += n;

                CalificacionTextBot.Focus();

            }
            else
            {
                MessageBox.Show("ERROR! Debe llenar los campos...", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Error);

                CalificacionTextBot.Focus();
            }

            minimo = maximo = n; 

            foreach (int i in notas)
            {
                if (maximo < i)
                {
                    maximo = i;
                }
                else if (minimo > i)
                {
                    minimo = i;
                }
            }

        }

        private void ResultadosButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (AcumuladorSuma / contador);

            ResultadosListView.Items.Add("El promedio es: ");
            ResultadosListView.Items.Add(promedio);

            ResultadosListView.Items.Add("La calificación máxima es: ");
            ResultadosListView.Items.Add(maximo);

            ResultadosListView.Items.Add("La calificación mínima es: ");
            ResultadosListView.Items.Add(minimo);

            foreach (int i in notas)
            {
                NotasListView.Items.Add(i);
            }
        }
    }
}
