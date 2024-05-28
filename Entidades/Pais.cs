using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Pais
    {
        // Atributos
        private string nombre;

        // Constructor
        public Pais(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodos get y set
        public string Nombre { get => nombre; set => nombre = value; }


    }
}
