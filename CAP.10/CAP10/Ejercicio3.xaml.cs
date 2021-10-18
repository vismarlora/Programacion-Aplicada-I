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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        class Poligono
        {
            public int cantidad, medidas, angulos;
            public Poligono(int c, int m, int a)
            {
                cantidad = c;

                medidas = m;

                angulos = a;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"Cantidad de lados del Poligono: {cantidad}\nMedidas de los lados del Poligono: {medidas}\nAngulos del Poligono: {angulos}");

                return sb.ToString();
            }
        }
        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Cantidad de lados del Poligono: ", "Lados", " ", 50, 0)),

                Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Medida de los lados del Poligono: ", "Medidas", " ", 50, 0)),

                Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite los Angulos del Poligono: ", "Angulo", " ", 50, 0)));

            PoligonosListBox.Items.Add(poligono.ToString());
        }
    }
}
