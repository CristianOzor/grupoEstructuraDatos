using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_EDDatos_IMC
{
    class Program //Utilizada para ejecutar el menu principal
    {
        static void Main(string[] args)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.desplegar();
        }
    }
}
