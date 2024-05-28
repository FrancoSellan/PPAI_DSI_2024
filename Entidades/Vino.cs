using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Vino
    {
        // Atributos
        private double añada;
        private DateTime fechaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private int notaDeCataBodega;
        private int precioARS;

        // Constructor
        public Vino (double añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, int notaDeCataBodega, int precioARS)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
        }

        public Vino ()
        {

        }

        // Metodos get y set
        public double Añada { get => añada; set => añada = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }

        //public void cargarVinos()
        //{
        //    for (int i = 0; i == 5; i++)
        //    {
        //        Vino vino[i] = new Vino();
        //    }
        //}
    }
}
