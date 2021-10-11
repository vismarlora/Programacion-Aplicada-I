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
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        public enum TiposNeumaticos
        {
            Neumaticos_Deportivos, Neumaticos_de_Invierno, Neumaticos_TodoTerreno, Neumaticos_de_Pista, Neumaticos_de_Verano
        }

        private void VerButton_Click(object sender, RoutedEventArgs e)
        {
            TiposNeumaticos neumaticos1 = TiposNeumaticos.Neumaticos_Deportivos;
            TiposNeumaticos neumaticos2 = TiposNeumaticos.Neumaticos_de_Invierno;
            TiposNeumaticos neumaticos3 = TiposNeumaticos.Neumaticos_TodoTerreno;
            TiposNeumaticos neumaticos4 = TiposNeumaticos.Neumaticos_de_Pista;
            TiposNeumaticos neumaticos5 = TiposNeumaticos.Neumaticos_de_Verano;
            


            string neumaticos = "" + neumaticos1.ToString() + "\n" + neumaticos2.ToString() + "\n" + neumaticos3.ToString() + "\n" + neumaticos4.ToString() + "\n" + neumaticos5.ToString();

            ListaListBox.Items.Add(neumaticos);
        }
    }
}
