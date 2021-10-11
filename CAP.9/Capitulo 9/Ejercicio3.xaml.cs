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

namespace CAP._9.Capitulo_9
{
    /// <summary>
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        public struct Dueno
        {
            string Nombre, Cedula, Telefono;
            public Dueno(string nombre, string cedula, string telefono)
            {
                Cedula = cedula;
                Nombre = nombre;
                Telefono = telefono;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"\nDueño: {Nombre} \nCedula: {Cedula} \nTelefono: {Telefono}");

                return sb.ToString();
            }
        }
        public struct Mascota
        {
            string Nombre, Raza, Sexo;

            public Dueno Propietario;

            public Mascota(string nombreM, string raza, string sexo, string nombreD, string cedula, string telefono)
            {
                Nombre = nombreM;
                Raza = raza;
                Sexo = sexo;

                Propietario = new Dueno(nombreD, cedula, telefono);
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"Nombre de la Mascota: {Nombre} \nRaza: { Raza} \nSexo: {Sexo} \n");

                sb.Append(Propietario.ToString());

                return sb.ToString();
            }
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Mascota mascota = new Mascota(Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre de la Mascota: ", "Nombre de la Mascota ", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"De que Raza es la Mascota: ", "Raza de la Mascota ", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite el Sexo de la Mascota: ", "Sexo de la Mascota ", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre del Dueño: ", "Nombre del Dueño ", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite la Cedula del Dueño: ", "Cedula del Dueño ", " ", 50, 0),

                Microsoft.VisualBasic.Interaction.InputBox($"Digite el Telefono del Dueño: ", "Telefono del Dueño ", " ", 50, 0));

            MostrarListBox.Items.Add(mascota.ToString());
        }
    }
}
