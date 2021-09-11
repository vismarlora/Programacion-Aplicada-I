﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEjercicios5.Ejercicios.NumeroEnLetras
{
    public class Conversion
    {
        public string enletras(string num)
        {
            string residuo;
            string decim = "";
            double numero;
            int decimales;
            Int64 entero;

            try
            {
                numero = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(numero));

            decimales = Convert.ToInt32(Math.Round((numero - entero) * 100, 2));

            if (decimales > 0)
            {
                decim = " con " + decimales.ToString() + "/100";
            }

            residuo = toText(Convert.ToDouble(entero)) + decim;
            return residuo;
        }

        private string toText(double value)
        {
            string Num2Text = "";

            value = Math.Truncate(value);

            if (value == 0) Num2Text = "Cero";

            else if (value == 1) Num2Text = "Uno";

            else if (value == 2) Num2Text = "Dos";

            else if (value == 3) Num2Text = "Tres";

            else if (value == 4) Num2Text = "Cuatro";

            else if (value == 5) Num2Text = "Cinco";

            else if (value == 6) Num2Text = "Seis";

            else if (value == 7) Num2Text = "Siete";

            else if (value == 8) Num2Text = "Ocho";

            else if (value == 9) Num2Text = "Nueve";

            else if (value == 10) Num2Text = "Diez";

            else if (value == 11) Num2Text = "Once";

            else if (value == 12) Num2Text = "Doce";

            else if (value == 13) Num2Text = "Trece";

            else if (value == 14) Num2Text = "Catorce";

            else if (value == 15) Num2Text = "Quince";

            else if (value < 20) Num2Text = "Dieci " + toText(value - 10);

            else if (value == 20) Num2Text = "Veinte";

            else if (value < 30) Num2Text = "Veinti  " + toText(value - 20);

            else if (value == 30) Num2Text = "Treinta";

            else if (value == 40) Num2Text = "Cuarenta";

            else if (value == 50) Num2Text = "Cincuenta";

            else if (value == 60) Num2Text = "Sesenta";

            else if (value == 70) Num2Text = "Setenta";

            else if (value == 80) Num2Text = "Ochenta";

            else if (value == 90) Num2Text = "Noventa";

            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " y " + toText(value % 10);

            else if (value == 100) Num2Text = "Cien";

            else if (value < 200) Num2Text = "Ciento " + toText(value - 100);

            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + " Cientos";

            else if (value == 500) Num2Text = "Quinientos";

            else if (value == 700) Num2Text = "Seteciento";

            else if (value == 900) Num2Text = "Novecientos";

            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);

            else if (value == 1000) Num2Text = "Mil";

            else if (value < 2000) Num2Text = "Mil " + toText(value % 1000);

            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " Mil";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "Un Millon";

            else if (value < 2000000) Num2Text = "Un Millon " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " Millones ";

                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "Un Billon";

            else if (value < 2000000000000) Num2Text = "Un Billon " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " Billones";

                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }
    }
}
