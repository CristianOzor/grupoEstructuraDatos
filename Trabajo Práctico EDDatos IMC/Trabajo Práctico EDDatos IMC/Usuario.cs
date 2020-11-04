using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_EDDatos_IMC
{
    class Usuario
    {
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private float altura;
        private float peso;
        private string diabetico;
        private string hipertenso;
        private string dieta;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Peso { get => peso; set => peso = value; }
        public string Diabetico { get => diabetico; set => diabetico = value; }
        public string Hipertenso { get => hipertenso; set => hipertenso = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dieta { get => dieta; set => dieta = value; }
        public int Id { get => id; set => id = value; }
    }
}
