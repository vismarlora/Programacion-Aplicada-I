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

namespace Capitulo_4
{
    /// <summary>
    /// Interaction logic for PantallaPrincipal.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        int num = 0;
        int resultado = 0;
        public Ejercicio_1()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            String numero;

            numero = this.NumeroTextBox.Text;

            num = Convert.ToInt32(numero);

            this.TablaListView.Items.Clear();

            
                for (int i = 1; i <= 10; i++)
                {
                    resultado = i * num;
                    this.TablaListView.Items.Add($"{num} X {i} = {resultado} ");
                }
           


        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            this.NumeroTextBox.Clear();
            this.TablaListView.Items.Clear();
        }

    }
}
