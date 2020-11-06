using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_EDDatos_IMC
{
    class Menu_Principal
    {
        private int opcion;
        private List<Usuario> ListaUsuarios;
        private int numid;

        public void desplegar() {
            ListaUsuarios = new List<Usuario>();

            do
            {
                do
                {
                    Console.WriteLine(" -TRABAJO PRACTICO GRUPAL ESTRUCTURA DE DATOS- ");
                    Console.WriteLine(" ---- GRUPO 4: OZOR, STROLLO, VALENZUELA ---- ");
                    Console.WriteLine(" -------------- IFTS 18 - 2020 -------------- ");
                    Console.WriteLine(" -------------------------------------------- ");
                    Console.WriteLine(" ------ BIENVENIDO AL CALCULADOR DE IMC ----- "); //BIENVENIDA AL PROGRAMA
                    Console.WriteLine(" -------------- MENU PRINCIPAL -------------- ");
                    Console.WriteLine("1. - INGRESAR USUARIO NUEVO  ");
                    Console.WriteLine("2. - BUSCAR USUARIO EXISTENTE ");
                    Console.WriteLine("3. - ELIMINAR USUARIO EXISTENTE ");
                    Console.WriteLine("4. - MOSTRAR LISTADO DE USUARIOS ");
                    Console.WriteLine("5. - CALCULAR IMC ");
                    Console.WriteLine("6. - RECOMENDAR DIETA ");
                    Console.WriteLine("7. - OBTENER COMPROBANTE");
                    Console.WriteLine("8. - SALIR ");
                    Console.WriteLine("Seleccione la opcion deseada (1 a 8):");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //SI LA OPCION ES INVALIDA:
                    if (opcion < 1 || opcion > 8) 
                    {
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("OPCION INVALIDA - VUELVA A INGRESAR UNA OPCION VALIDA (1 a 7)");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("");
                    }


                } while (opcion <1 || opcion >8);

                switch (opcion) {
                    case 1: {
                            /*INDICADO PARA INGRESAR UN NUEVO USUARIO*/

                            Usuario NuevoUsuario = new Usuario();
                            Console.WriteLine("-------------");

                            NuevoUsuario.Id = numid++;
                            Console.WriteLine("ID:" + NuevoUsuario.Id);

                            Console.Write("DNI:");
                            NuevoUsuario.Dni = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Nombre:");
                            NuevoUsuario.Nombre = Console.ReadLine();

                            Console.Write("Apellido:");
                            NuevoUsuario.Apellido = Console.ReadLine();

                            string nuevosexo;
                            do
                            {
                                Console.Write("Sexo (F/M):");
                                nuevosexo = Console.ReadLine();
                                if (nuevosexo == "F" || nuevosexo == "M")
                                {
                                    NuevoUsuario.Sexo = nuevosexo;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" Por favor, ingrese la letra F: Femenino o M: Masculino");
                                }
                            } while (nuevosexo != "F" || nuevosexo != "M");

                            Console.Write("Edad (años):");
                            NuevoUsuario.Edad = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Altura (cm):");
                            NuevoUsuario.Altura = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Peso (kg):");
                            NuevoUsuario.Peso = Convert.ToInt32(Console.ReadLine());

                            string nuevodiabetico;
                            do
                            {
                                Console.Write("Diabetico (S/N):");
                                nuevodiabetico = Console.ReadLine();
                                if (nuevodiabetico == "S" || nuevodiabetico == "N")
                                {
                                    NuevoUsuario.Diabetico = nuevodiabetico;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" Por favor, ingrese la letra S: Si es DIABETICO o N: Si No es DIABETICO");
                                }
                            } while (nuevodiabetico != "S" || nuevodiabetico != "N");

                            string nuevohipertenso;
                            do
                            {
                                Console.Write("Hipertenso (S/N):");
                                nuevohipertenso = Console.ReadLine();
                                if (nuevohipertenso == "S" || nuevohipertenso == "N")
                                {
                                    NuevoUsuario.Hipertenso = nuevohipertenso;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" Por favor, ingrese la letra S: Si es HIPERTENSO o N: Si No es HIPERTENSO");
                                }
                            } while (nuevohipertenso != "S" || nuevohipertenso != "N");


                            ListaUsuarios.Add(NuevoUsuario);



                            Console.WriteLine("-------------");
                            Console.WriteLine("");
                            break;
                        }
                    case 2:
                        {
                            /*INDICADO PARA BUSCAR UN USUARIO EXISTENTE*/

                            Console.WriteLine("Escriba el Id del usuario a buscar:");
                            int idBuscar = Convert.ToInt32(Console.ReadLine());

                            foreach (Usuario u in ListaUsuarios)
                            {

                                if (u.Id == idBuscar)
                                {
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("Id:" + u.Id);
                                    Console.WriteLine("DNI:" + u.Dni);
                                    Console.WriteLine("Nombre:" + u.Nombre);
                                    Console.WriteLine("Apellido:" + u.Apellido);
                                    Console.WriteLine("Sexo:" + u.Sexo);
                                    Console.WriteLine("Altura:" + u.Altura);
                                    Console.WriteLine("Peso:" + u.Peso);
                                    Console.WriteLine("Diabetico:" + u.Diabetico);
                                    Console.WriteLine("Hipertenso:" + u.Hipertenso);
                                    Console.WriteLine("Edad:" + u.Edad);
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("");

                                    break;

                                }

                                else if (u.Id != idBuscar)
                                {

                                    Console.WriteLine("Usuario no encontrado, intente ingresando nuevamente");
                                    Console.WriteLine("");
                                }






                            }


                        }

                        break;

                    case 3:
                        {
                            /*INDICADO PARA ELIMINAR EL USUARIO EXISTENTE*/

                            int eliminarid;
                            Console.WriteLine("Ingrese el ID del usuario a eliminar:");
                            eliminarid = Convert.ToInt32(Console.ReadLine());

                            ListaUsuarios.RemoveAll(u => u.Id == eliminarid);


                            break;

                        }


                    case 4:
                        {
                            /*INDICADO PARA MOSTRAR EL LISTADO DE USUARIOS*/
                            foreach (Usuario u in ListaUsuarios)
                            {
                                Console.WriteLine("-------------");
                                Console.WriteLine("Id:" + u.Id);
                                Console.WriteLine("DNI:" + u.Dni);
                                Console.WriteLine("Nombre:" + u.Nombre);
                                Console.WriteLine("Apellido:" + u.Apellido);
                                Console.WriteLine("Sexo:" + u.Sexo);
                                Console.WriteLine("Altura:" + u.Altura);
                                Console.WriteLine("Peso:" + u.Peso);
                                Console.WriteLine("Diabetico:" + u.Diabetico);
                                Console.WriteLine("Hipertenso:" + u.Hipertenso);
                                Console.WriteLine("Edad:" + u.Edad);

                                CalculoIMC cIMC = new CalculoIMC();
                                Console.WriteLine("IMC:" + cIMC.CalculadoraIMC(u));

                                Console.WriteLine("-------------");
                                Console.WriteLine("");
                            }
                            break;
                        }

                    case 5:
                        {
                            /*INDICADO PARA CALCULAR EL IMC*/
                            Console.WriteLine("Por favor, ingrese la id del usuario que desea calcular el IMC:");
                            var dato = Console.ReadLine();
                            CalculoIMC cIMC = new CalculoIMC();
                            Console.WriteLine("El Indice de Masa Corporal IMC para el usuario seleccionado es:");
                            Console.WriteLine(cIMC.CalculadoraIMC(ListaUsuarios[int.Parse(dato)]));

                            break;
                        }
                    case 6:
                        {
                            /*INDICADO PARA RECOMENDAR DIETA*/
                            Console.WriteLine("Por favor, ingrese la id del usuario para realizar su consulta:");
                            int iduser = Convert.ToInt32(Console.ReadLine());

                            foreach (Usuario u in ListaUsuarios)
                            {

                                if (u.Id == iduser)
                                {

                                    CalculoIMC cIMC = new CalculoIMC();
                                    Console.WriteLine("IMC:" + cIMC.CalculadoraIMC(u));

                                    if (cIMC.CalculadoraIMC(u) < 18.5)
                                    {
                                        Stack miPilaBajoPeso = new Stack();
                                        miPilaBajoPeso.Push("Leche entera y semidesnatada");
                                        miPilaBajoPeso.Push("Quesos frescos");
                                        miPilaBajoPeso.Push("Yogurt entero con o sin fruta");
                                        miPilaBajoPeso.Push("Pollo y pavo, cerdo, ternera, conejo");
                                        miPilaBajoPeso.Push("Higado");
                                        miPilaBajoPeso.Push("Pescados Blancos como merluza");
                                        miPilaBajoPeso.Push("Pescados azules tipo Salmón, Caballa y Sardinas. También Ahumados");
                                        miPilaBajoPeso.Push("Huevos");
                                        miPilaBajoPeso.Push("Pan Blanco, pastas, arroces y cereales ");
                                        miPilaBajoPeso.Push("Verduras y hortalizas");
                                        miPilaBajoPeso.Push("Palta y aceitunas");
                                        miPilaBajoPeso.Push("Legumbres");
                                        miPilaBajoPeso.Push("Frutas y frutos secos");
                                        miPilaBajoPeso.Push("Aceite de oliva virgen y de otras semillas");
                                        miPilaBajoPeso.Push("Zumos de frutos y hortalizas");



                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = BAJO PESO ");
                                        Console.WriteLine(" Para la informacion que ingresó: ");
                                        Console.WriteLine(" Altura: " + u.Altura + "cm ");
                                        Console.WriteLine(" Peso: " + u.Peso + " kg ");
                                        Console.WriteLine("" + u.Nombre + " su IMC es " + cIMC.CalculadoraIMC(u) + "; lo que indica que su peso está en la categoria de BAJO PESO.");
                                        Console.WriteLine(" Malas noticias! Tu peso no es saludable, se encuentra muy delgada/o.");
                                        Console.WriteLine(" Usted deberia realizar una consulta con su medico, para establecer las posibles causas del bajo peso.");
                                        Console.WriteLine(" Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");

                                        Console.WriteLine("Dietas recomendadas");
                                        Console.WriteLine("...............................");
                                        for (byte i = 0; i < 15; i++)
                                        {
                                            string bajoP = (string)miPilaBajoPeso.Pop();
                                            Console.WriteLine(bajoP);
                                        }
                                        Console.WriteLine("...............................");
                                        Console.ReadKey();

                                    }
                                    else if (cIMC.CalculadoraIMC(u) >= 18.5 && cIMC.CalculadoraIMC(u) <= 24.9)
                                    {
                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = NORMAL / ACEPTABLE / ADECUADO ");
                                        Console.WriteLine(" Para la información que ingresó: ");
                                        Console.WriteLine(" Altura:" + u.Altura + " cm ");
                                        Console.WriteLine(" Peso:" + u.Peso + " kg ");
                                        Console.WriteLine("" + u.Nombre + " su IMC es " + cIMC.CalculadoraIMC(u) + "; lo que indica que su peso está en la categoría de NORMAL.");
                                        Console.WriteLine(" Muy buena noticia!! Tienes un PESO IDEAL. SIGUE ASI!!! ");
                                        Console.WriteLine(" Mantener un peso saludable puede reducir el riesgo de enfermedades crónicas asociadas al sobrepeso y la obesidad.");
                                        Console.WriteLine(" Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");
                                    }
                                    else if (cIMC.CalculadoraIMC(u) >= 25 && cIMC.CalculadoraIMC(u) <= 29.9)
                                    {
                                        Queue miColaPesoAlto = new Queue();
                                        miColaPesoAlto.Enqueue("Carnes: buey, ternera, caballo, cerdo magro, carnes desgrasadas en general");
                                        miColaPesoAlto.Enqueue("Aves: pollo, pavo");
                                        miColaPesoAlto.Enqueue("Pescados, moluscos, crustáceos");
                                        miColaPesoAlto.Enqueue("Leche desnatada y semidesnatada. Yogures naturales. Quesos frescos desnatados");
                                        miColaPesoAlto.Enqueue("Verduras en general");
                                        miColaPesoAlto.Enqueue("Frutas frescas");
                                        miColaPesoAlto.Enqueue("Café. Té. Infusiones");
                                        miColaPesoAlto.Enqueue("Aguas minerales");
                                        miColaPesoAlto.Enqueue("Especias. Condimentos");



                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = SOBREPESO ");
                                        Console.WriteLine(" Para la información que ingresó: ");
                                        Console.WriteLine(" Altura:" + u.Altura + " cm "); ;
                                        Console.WriteLine(" Peso:" + u.Peso + " kg ");
                                        Console.WriteLine("" + u.Nombre + " su IMC es " + cIMC.CalculadoraIMC(u) + "; lo que indica que su peso está en la categoría de SOBREPESO.");
                                        Console.WriteLine(" Tené cuidado! Padeces de SOBREPESO, tu salud es moderada.");
                                        Console.WriteLine(" Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\n tales como hipertensión arterial, diabetes y colesterol alto.");
                                        Console.WriteLine(" Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal)");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");

                                        Console.WriteLine("Dietas recomendadas");
                                        Console.WriteLine("...............................");
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            string pesoA = (string)miColaPesoAlto.Dequeue();
                                            Console.WriteLine(pesoA);
                                        }
                                        Console.WriteLine("...............................");
                                        Console.ReadKey();
                                    }

                                    else if (cIMC.CalculadoraIMC(u) >= 30 && cIMC.CalculadoraIMC(u) <= 34.9)
                                    {
                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = OBESIDAD GRADO 1");
                                        Console.WriteLine("Para la informacion que ingresó:");
                                        Console.WriteLine("Altura:" + u.Altura + "cm");
                                        Console.WriteLine("Peso:" + u.Peso + "kg");
                                        Console.WriteLine("" + u.Nombre + " su IMC es " + cIMC.CalculadoraIMC(u) + "; lo que indica que su peso está en la categoria de OBESIDAD.");
                                        Console.WriteLine("Malas noticias! Tienes OBESIDAD, tu riesgo de salud es alto.");
                                        Console.WriteLine("Las personas que tienen sobrepeso o son obesas tienen un mayor riesgo de afecciones crónicas,\n tales como hipertensión arterial, diabetes y colesterol alto.");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");
                                    }

                                    else if (cIMC.CalculadoraIMC(u) >= 40 && cIMC.CalculadoraIMC(u) < 50)
                                    {
                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = OBESIDAD GRADO 3");
                                        Console.WriteLine(" Para la informacion que ingresó: ");
                                        Console.WriteLine(" Altura:" + u.Altura + " cm ");
                                        Console.WriteLine(" Peso:" + u.Peso + " kg ");
                                        Console.WriteLine("" + u.Nombre + " tenemos malas noticias, su IMC es " + cIMC.CalculadoraIMC(u) + "!; Padeces de obesidad morbida, Tu riesgo en salud es extremadamente alto\n");
                                        Console.WriteLine(" Por favor, contacta a tu medico y/o nutricionista para elaborar un plan y mejorar tu salud!!! ");
                                        Console.WriteLine(" Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) ");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");

                                    }

                                    else if (cIMC.CalculadoraIMC(u) >= 35.0 && cIMC.CalculadoraIMC(u) <= 40)
                                    {
                                        Console.WriteLine("-------------");
                                        Console.WriteLine(" Categoria = OBESIDAD GRADO 2 ");
                                        Console.WriteLine(" Para la informacion que ingresó: ");
                                        Console.WriteLine(" Altura: " + u.Altura + " cm ");
                                        Console.WriteLine(" Peso: " + u.Peso + " kg ");
                                        Console.WriteLine("" + u.Nombre + " tenemos malas noticias, su IMC es " + cIMC.CalculadoraIMC(u) + "!; Padeces de obesidad grado 2, Tu riesgo en salud es extremadamente alto\n ");
                                        Console.WriteLine(" Por favor, contacta a tu medico y/o nutricionista para elaborar un plan y mejorar tu salud!!! ");
                                        Console.WriteLine(" Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) ");
                                        Console.WriteLine("");
                                        Console.WriteLine("-------------");

                                    }

                                }

                            }

                        

                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Por favor, ingrese la id del usuario para imprimir su comprobante:");
                            int iduser = Convert.ToInt32(Console.ReadLine());

                            foreach (Usuario u in ListaUsuarios)
                            {

                                if (u.Id == iduser)
                                {
                                    CalculoIMC cIMC = new CalculoIMC();

                                    string myFile = @"ComprobanteIMC.txt";
                                    //Se crea una excepción al error input/output para que el programa no se rompa y siga corriendo
                                    try
                                    {
                                        //valida si el archivo no existe lo crea
                                        if (!File.Exists(myFile)) 
                                        {
                                            //Se crea el archivo con el nombre indicado. Esta en modo escritura sw
                                            using (StreamWriter sw = File.CreateText(myFile))
                                            {
                                                sw.WriteLine("Información importante para su nutricionista");
                                                sw.WriteLine("");
                                                sw.WriteLine("-------------------------------------------------");
                                                sw.WriteLine("DNI: {0}", u.Dni);
                                                sw.WriteLine("Apellido: {0}", u.Apellido);
                                                sw.WriteLine("Nombre: {0}", u.Nombre);
                                                sw.WriteLine("Edad: {0}", u.Edad);
                                                sw.WriteLine("Altura: {0}cm", u.Altura);
                                                sw.WriteLine("Peso: {0}kg", u.Peso);
                                                sw.WriteLine("IMC: {0}", cIMC.CalculadoraIMC(u));
                                                sw.WriteLine("Diabetico: {0}", u.Diabetico);
                                                sw.WriteLine("Hipertenso {0}", u.Hipertenso);
                                                sw.WriteLine("-------------------------------------------------");
                                                sw.WriteLine("");
                                                sw.WriteLine("Nutricionista recomendado");
                                                sw.WriteLine("Dr. Homero Simpson");
                                                sw.WriteLine("Av. Siempreviva 742");
                                                sw.WriteLine("0800-666-DIETA");
                                                sw.Close();
                                            }
                                        }
                                    }
                                    catch (Exception IO)
                                    {
                                        Console.WriteLine("Error al manipular el archivo " + IO.Message);
                                    }
                                }
                                    
                            }
                            break;
                        }
                    case 8:
                        {
                            /*INDICADO PARA SALIR DEL PROGRAMA*/

                            Console.WriteLine(" Gracias por Utilizar la aplicacion CALCULADORA DE IMC!!! TE ESPERAMOS DE NUEVO!!!");
                            Console.ReadLine();
                            break;
                        }

                }




            } while (opcion !=8);
        
        }
    }
}
