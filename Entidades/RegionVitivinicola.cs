using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class RegionVitivinicola
    {
        // Atributos
        private string descripcion;
        private string nombre;
        private Provincia provincia;

        // Constructor
        public RegionVitivinicola (string descripcion, string nombre, Provincia provincia)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
            this.provincia = provincia;
        }

        // Metodos get y set
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }

        // Metodos
        public string getNombre()
        {
            return nombre;
        }

        public void obtenerPais(List<string> vinoParaExcel)
        {
            provincia.obtenerPais(vinoParaExcel);
        }
    }

    
}
