using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo_7.Ejercicio
{
    /// <summary>
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class Ejercicio_5 : Window
    {
        Hashtable agenda = new Hashtable();
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            agenda.Add(NombreTextBox.Text, NumeroTextBox.Text);

            NumeroTextBox.Text = "";

            NombreTextBox.Text = "";
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            BusquedaTextBox.Text = (String)agenda[Convert.ToString(NombreTextBox.Text)];
        }
    }
}
