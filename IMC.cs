using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Class1
    {
        public string categoriaIMC(string sexoTipo, double numero)
        {
            string tipoCategoria = "";
            if (sexoTipo == "F")
            {
                if (numero < 20)
                {
                    tipoCategoria = "BAJO PESO";
                }
                else if (numero >= 20 && numero <= 23.9)
                {
                    tipoCategoria = "NORMAL";
                }
                else if (numero >= 24 && numero <= 28.9)
                {
                    tipoCategoria = "OBESIDAD LEVE";
                }
                else if (numero >= 29 && numero <= 37)
                {
                    tipoCategoria = "OBESIDAD SEVERA";
                }
                else
                {
                    tipoCategoria = "OBESIDAD MUY SEVERA";
                }
            }
            if (sexoTipo == "M")
            {
                if (numero < 20)
                {
                    tipoCategoria = "BAJO PESO";
                }
                else if (numero >= 20 && numero <= 24.9)
                {
                    tipoCategoria = "NORMAL";
                }
                else if (numero >= 25 && numero <= 29.9)
                {
                    tipoCategoria = "OBESIDAD LEVE";
                }
                else if (numero >= 30 && numero <= 40)
                {
                    tipoCategoria = "OBESIDAD SEVERA";
                }
                else
                {
                    tipoCategoria = "OBESIDAD MUY SEVERA";
                }

            }
            return tipoCategoria;

            string status = categoriaIMC("F", 24);
            Console.WriteLine("Su categoría dentro del IMC es de: {0}", status);
            Console.ReadLine();

        }
        
    }
}
