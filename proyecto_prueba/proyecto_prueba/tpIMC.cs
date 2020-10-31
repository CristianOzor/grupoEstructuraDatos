using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double indiceIMC(double pesoFuncion, int alturaFuncion)
            {
                double conversionAltura = (Convert.ToDouble(alturaFuncion)) / 100;
                double potenciaMasaCorp = Math.Pow(conversionAltura, 2);
                double resultadoIMC = pesoFuncion / potenciaMasaCorp;
                return resultadoIMC;

            }
            
                Console.WriteLine("--- Bienvenido al CALCULADOR DE IMC ---"); ///BIENVENIDA AL PROGRAMA
                Console.WriteLine("---MENU PRINCIPAL---");

                Console.WriteLine("1-Ingresar con usuario existente.\n2-Registrar nuevo usuario.");
                int usuario = int.Parse(Console.ReadLine());
                
                if (usuario == 1)
            {
                Console.WriteLine("Ingrese usuario: ");
                string nombreUsuario = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese contraseña de 4 numeros: ");
                Console.ReadLine();

                Console.WriteLine("    Bienvenido {0} !!", nombreUsuario);

            }                
                if (usuario == 2)
            {
                Console.WriteLine("Ingrese correo electronico: ");
                Console.ReadLine();
                Console.WriteLine("Nombre completo: ");
                Console.ReadLine();
                Console.WriteLine("Nombre de usuario: ");
                string nuevoUsuario = Convert.ToString(Console.ReadLine());
                              
                
                Console.WriteLine("Ingrese contraseña: ");
                int contraseña = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Repita contraseña: ");
                int contraseñaNueva = Convert.ToInt32(Console.ReadLine());
                while (contraseña != contraseñaNueva)
                {
                    Console.WriteLine("Las contraseñas no coinciden, repita nuevamente: ");
                    int Validar = Convert.ToInt32(Console.ReadLine());
                    
                    if (contraseña == Validar)
                    {
                        Console.WriteLine("    Bienvenido {0} !!", nuevoUsuario);
                        break;
                    }
                }
                                                                    
            }             
                ///Console.WriteLine("Bienvenido : ");///Ingreso de Datos
                ///string nombre = Convert.ToString(Console.ReadLine());
                ///Console.WriteLine("Ingrese su sexo por favor.. M - F");
                ///string sexo = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingresa tu edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su altura en centímetros:");
                int altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su peso en kilogramos:");
                double peso = double.Parse(Console.ReadLine());

                double calculoIMC = indiceIMC(peso, altura);///Calculo de IMC
                ///Console.WriteLine("Su IMC es de {0}", calculoIMC);          

                Console.ReadKey();

            string categoriaIMC(/*string sexoTipo,*/double numero)
            {
                string tipoCategoria = "";
                ///if (sexoTipo == "F")
                {
                    if (numero < 18.5)
                    {
                        tipoCategoria = "BAJO PESO";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de BAJO PESO.", calculoIMC);
                        Console.WriteLine("Malas noticias! Tu peso no es saludable, estas muy delgada.");
                        Console.WriteLine("Usted deberia realizar una consulta con su medico, para establecer las posibles causas del bajo peso.");
                    }
                    else if (numero >= 18.5 && numero <= 24.9)
                    {
                        tipoCategoria = "NORMAL";
                        Console.WriteLine("Para la información que ingresó:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoría de NORMAL.", calculoIMC);
                        Console.WriteLine("Muy buena noticia!! Tienes un PESO IDEAL.");
                        Console.WriteLine("Mantener un peso saludable puede reducir el riesgo de enfermedades crónicas asociadas al sobrepeso y la obesidad.");
                    }
                    else if (numero >= 25 && numero <= 29.9)
                    {
                        tipoCategoria = "SOBREPESO";
                        Console.WriteLine("Para la información que ingresó:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoría de SOBREPESO.", calculoIMC);
                        Console.WriteLine("Tené cuidado! Padeces de SOBREPESO, tu salud es moderada.");
                        Console.WriteLine("Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\ntales como hipertensión arterial, diabetes y colesterol alto.");
                    }
                    else if (numero >= 30 && numero <= 37)
                    {
                        tipoCategoria = "OBESIDAD";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm.", altura);
                        Console.WriteLine("Peso:{0}kg.", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de OBESIDAD.", calculoIMC);
                        Console.WriteLine("Malas noticias! Tienes OBESIDAD, tu riesgo de salud es alto.");
                        Console.WriteLine("Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\ntales como hipertensión arterial, diabetes y colesterol alto.");
                    }
                    
                }
                /*if (sexoTipo == "M")
                {
                    if (numero < 18.5)
                    {
                        tipoCategoria = "BAJO PESO";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de BAJO PESO", calculoIMC);
                        Console.WriteLine("Malas noticias {0}! Tu peso no es saludable, estas muy delgado.", nombre);
                        Console.WriteLine("Usted deberia realizar una consulta con su medico, para establecer las posibles causas del bajo peso.");
                    }
                    else if (numero >= 18.5 && numero <= 24.9)
                    {
                        tipoCategoria = "NORMAL";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de NORMAL", calculoIMC);
                        Console.WriteLine("Muy buena noticia {0}!! Tienes un PESO IDEAL", nombre);
                        Console.WriteLine("Mantener un peso saludable puede reducir el riesgo de enfermedades crónicas asociadas al sobrepeso y la obesidad.");
                    }
                    else if (numero >= 25 && numero <= 29.9)
                    {
                        tipoCategoria = "SOBREPESO";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de SOBREPESO", calculoIMC);
                        Console.WriteLine("Ten cuidado {0}! Padeces de SOBREPESO, tu salud es moderada", nombre);
                        Console.WriteLine("Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\n tales como hipertensión arterial, diabetes y colesterol alto.");
                    }
                    else if (numero >= 30 && numero <= 37)
                    {
                        tipoCategoria = "OBESIDAD";
                        Console.WriteLine("Para la informacion que ingreso:");
                        Console.WriteLine("Estatura:{0}cm", altura);
                        Console.WriteLine("Peso:{0}kg", peso);
                        Console.WriteLine("Su IMC es {0}, lo que indica que su peso esta en la categoria de OBESIDAD", calculoIMC);
                        Console.WriteLine("Malas noticias {0}! Tienes OBESIDAD, tu riesgo de salud es alto", nombre);
                        Console.WriteLine("Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\n tales como hipertensión arterial, diabetes y colesterol alto.");
                    }
                    
                }*/
                Console.ReadKey();
                return tipoCategoria;
                
            }
            categoriaIMC(/*sexo,*/calculoIMC);

            ///
            ///string dietas()
            {

            }
            Console.WriteLine("Si desea recibir recomendaciones de dietas presione 1, para salir 0 !");
            int pregunta = Convert.ToInt32(Console.ReadLine());

            if (pregunta == 1)
            {
                Console.WriteLine("--- Bienvenido a Dietas Saludables ---");
                Console.WriteLine("Digite el numero correspondiente al grado en que se encuentra.\n1-SOBREPESO\n2-OBESIDAD");
                int grado = Convert.ToInt32(Console.ReadLine());
                ///Console.WriteLine("Es diabético?\n1-Si\n2-No");
                ///int pregDiabetico = Convert.ToInt32(Console.ReadLine());
                                                
                if (grado == 1)
                {
                ///Console.WriteLine("Nuestra dieta recomendada esta basada en los siguientes alimentos:\n1-")    
                }
                else if (grado == 2)
                {

                }
                
            }
            if (pregunta == 0)
            {
                Console.WriteLine("--- Muchas Gracias ---");
                
            }
            





        }
    }
     
}









