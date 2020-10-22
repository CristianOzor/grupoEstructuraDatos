using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double indiceIMC(double pesoFuncion, int alturaFuncion)
            {
                double conversionAltura = (Convert.ToDouble(alturaFuncion))/100;
                double potenciaMasaCorp = Math.Pow(conversionAltura, 2);
                double resultadoIMC = pesoFuncion / potenciaMasaCorp;
                return resultadoIMC;

            }

            
            Console.WriteLine("Ingrese su altura en centímetros");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en kilogramos");
            double peso = double.Parse(Console.ReadLine());

            double calculoIMC = indiceIMC(peso, altura);
            Console.WriteLine("Su IMC es de {0}", calculoIMC);
            Console.ReadKey();
        }   
    }
}
