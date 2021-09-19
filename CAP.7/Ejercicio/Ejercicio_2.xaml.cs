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
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        Hashtable diccionarioPalabra = new Hashtable();
        public Ejercicio_2()
        {
            InitializeComponent();
            PalabrasListView.Items.Add("Colecciones\nCiclo\nSentencia\nCadena\nVariable");
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            diccionarioPalabra.Add("colecciones", "Las colecciones son estructuras de datos que nos permiten guardar en su interior cualquier tipo de informacion.");

            diccionarioPalabra.Add("ciclo", "Un ciclo es una secuencia de instrucciones de codigo que se ejecuta repetidas veces, hasta que la condicion asignada a dicho ciclo deja de cumplirse.");

            diccionarioPalabra.Add("sentencia", "Las sentencias son elementos basicos en los que se divide el codigo en un lenguaje de programacion y nos permiten colocar instrucciones que nuestro programa pueda ejecutar, que son utilizadas para mostrar un mensaje.");

            diccionarioPalabra.Add("cadena", "Una cadena es una coleccion de caracteres, es decir, letras, numeros y signos y se delimita con comillas dobles.");

            diccionarioPalabra.Add("variable", "La variable es donde se guarda y se recupera datos que se utilizan en un programa.");

            DescripcionTextBox.Text = (String)diccionarioPalabra[PalabraTextBox.Text.ToLower()];
        }
    }
}
