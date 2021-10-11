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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public int cantidad = 0;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            public int Id;

            public string Nombre;

            public float Precio;

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Id del Producto: {Id} \nNombre del Producto: {Nombre} \nPrecio del Producto: {Precio}");
                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            cantidad = Convert.ToInt32(CantidadTextBox.Text);
            Productos[] productos = new Productos[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                productos[i].Id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite el Id del Producto: {i + 1}", "Id del Producto ", " ", 50, 0));

                productos[i].Nombre = Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre del Producto: {i + 1}", "Nombre del Producto ", " ", 50, 0);

                productos[i].Precio = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Digite el Precio del Producto: {i + 1}", "Precio del Producto ", " ", 50, 0));

            }

            for (int i = 0; i < cantidad; i++)
            {

                MostrarListBox.Items.Add(productos[i].ToString());
            }
        }
    }
}
