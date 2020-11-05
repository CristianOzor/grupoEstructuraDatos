using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_EDDatos_IMC
{
    class CalculoIMC
    {
        public float CalculadoraIMC(Usuario usuario) {
            /*Función utilizada para calcular el IMC*/
            float calculodeIMC = (usuario.Peso)*10000 / (usuario.Altura * usuario.Altura);
            return calculodeIMC;
                                
        }
    }
}
