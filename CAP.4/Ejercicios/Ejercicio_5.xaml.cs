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

namespace Capitulo_4.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class Ejercicio_5 : Window
    {
        public static int acum = 0;
        public static float promedio = 0, acumulador = 0;
        public static int joven = 0, grande = 0;

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (acumulador / acum);

            ResultadoListView.Items.Add("Promedio: ");
            ResultadoListView.Items.Add(promedio);

            ResultadoListView.Items.Add("Edad mas joven: ");
            ResultadoListView.Items.Add(joven);

            ResultadoListView.Items.Add("Edad mas grande: ");
            ResultadoListView.Items.Add(grande);
        }

        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            
            if (EdadTextBox.Text != "")
            {
                string edades = EdadTextBox.Text;
                int.TryParse(edades, out num);
               
                this.EdadListView.Items.Add(num);

                EdadTextBox.Text = "";
                acum++;
                acumulador += num;
                EdadTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Campo vacio...", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Error);
                EdadTextBox.Focus();
            }

            joven = grande = num;

            for (int i = 0; i < EdadListView.Items.Count; i++)
            {

                if (grande < Convert.ToInt32(EdadListView.Items[i]))
                {
                    grande = Convert.ToInt32(EdadListView.Items[i]);
                }
                else if (joven > Convert.ToInt32(EdadListView.Items[i]))
                {
                   joven = Convert.ToInt32(EdadListView.Items[i]);
                }
            }
        }
    }
}
