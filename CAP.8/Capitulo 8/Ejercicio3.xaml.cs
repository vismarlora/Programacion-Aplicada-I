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

namespace CAP._8.Capitulo_8
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

        public String Formato;
        private void MostrarHorayFechaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DateTime.Now.Hour > 12)
            {
                Formato = String.Format("La Hora actual es: {0: hh:mm} PM y la Fecha actual es: {0: dd/MM/yyyy} ", DateTime.Now);
                MessageBox.Show(Formato, "Hora y Fecha Actual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Formato = String.Format("La Hora actual es: {0: hh:mm} AM y la Fecha actual es: {0: dd/MM/yyyy} ", DateTime.Now);
                MessageBox.Show(Formato, "Hora y Fecha Actual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
