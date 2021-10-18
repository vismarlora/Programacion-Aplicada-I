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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        class Inventario
        {
            public int codigo, existencia;

            public string producto, descripcion;
            

            public Inventario(int c, string p, string d, int e)
            {
                codigo = c;

                producto = p;

                descripcion = d;

                existencia = e;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"Codigo del Producto: {codigo}\nNombre del Producto: {producto}\nDescripcion del Producto: {descripcion}\nExistencia del Producto: {existencia}");

                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite el Codigo del Producto: ", "Codigo del Producto", " ", 50, 0)),

               Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre del Producto: ", "Nombre del Producto", " ", 50, 0),

               Microsoft.VisualBasic.Interaction.InputBox($"Digite la Descripcion del Producto: ", "Descripcion del Producto", " ", 50, 0),

               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Existencia del Producto: ", "Existencia del Producto", " ", 50, 0)));

            MostrarListBox.Items.Add(inventario.ToString());
        }
    }
}
