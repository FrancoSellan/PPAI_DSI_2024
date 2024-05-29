using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Varietal
    {
        // Atributos
        private string descripcion;
        private double porcentajeComposicion;
        
        // Constructor
        public Varietal (string descripcion, double porcentajeComposicion)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
        }

        // Metodos get y set
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PorcentajeComposicion { get => porcentajeComposicion; set => porcentajeComposicion = value; }

        // Metodos
        public string getDescripcion()
        {
            return descripcion;
        }
    }
}
