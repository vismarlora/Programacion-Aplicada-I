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
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
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
            public Poligono()
            {
                cantidad = 0;

                medidas = 0;

                angulos = 0;
            }
            public int Cantidad
            {
                get
                {
                    return cantidad;
                }

                set
                {
                    if (value <= 0)
                    {
                        cantidad = 1;
                    }
                    else
                    {
                        cantidad = value;
                    }
                }
            }
            public int Medidas
            {
                get
                {
                    return medidas;
                }

                set
                {
                    if (value <= 0)
                    {
                        medidas = 1;
                    }
                    else
                    {
                        medidas = value;
                    }
                }
            }
            public int Angulos
            {
                get
                {
                    return angulos;
                }

                set
                {
                    if (value <= 0)
                    {
                        angulos = 1;
                    }
                    else
                    {
                        angulos = value;
                    }
                }
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
            Poligono poligono = new Poligono();

            poligono.Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Cantidad de lados del Poligono: ", "Lados", " ", 50, 0));

            poligono.Medidas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Medida de los lados del Poligono: ", "Medidas", " ", 50, 0));

            poligono.Angulos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite los Angulos del Poligono: ", "Angulo", " ", 50, 0));

            PoligonosListBox.Items.Add(poligono.ToString());
        }
    }
}
