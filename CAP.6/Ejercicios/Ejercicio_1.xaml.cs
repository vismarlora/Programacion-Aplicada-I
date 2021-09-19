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

namespace Capitulo_6.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        int cantidad, curso = 0;

        static float[][] calificaciones; 


        public static float suma = 0.0f, promedio = 0.0f;

        public static int contador = 0;
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
        private void AgregarCursoButton_Click(object sender, RoutedEventArgs e)
        {
            curso = ToInt(CursosTextBox.Text);

            calificaciones = new float[curso][];

            for (int i = 0; i < curso; i++)
            {
                cantidad = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Digite la cantidad de estudiantes del aula {i + 1}", " Cantidad de Estudiantes ", " ", 50, 0));
                calificaciones[i] = new float[cantidad];
                
                contador += cantidad;
                cantidad += cantidad;

            }

            CursosTextBox.Text = "";
        }
        private void AregarCalificaionesButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < curso; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Digite la calificación del estudiante {j + 1}  de la aula {i + 1}", "Calificaciones Estudiantes", " ", 50, 0));
                    suma += calificaciones[i][j];
                }
            }

        }

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = suma / contador;

            ResultadosListView.Items.Add("El promedio es: ");
            ResultadosListView.Items.Add(promedio);
        }
    }
}
