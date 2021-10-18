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

namespace CAP._10.CAP10
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

        class Estudiantes
        {
            public int codigo, edad;

            public string nombre, grado, seccion;
            public Estudiantes(int c, string n, int e, string g, string s)
            {
                codigo = c;

                nombre = n;

                edad = e;

                grado = g;

                seccion = s;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"Codigo: {codigo}\nNombre del Estudiante: {nombre}\nEdad: {edad}\nGrado: {grado}\nSeccion: {seccion}");

                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite el Codigo del Estudiante: ", "Codigo", " ", 50, 0)),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre del Estudiante: ", "Nombre", " ", 50, 0),

                int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Edad del Estudiante: ", "Edad", " ", 50, 0)),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite el Grado del Estudiante: ", "Grado", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite la Seccion del Estudiante: ", "Seccion", " ", 50, 0));

            MostrarListBox.Items.Add(estudiantes.ToString());
        }
    }
}
