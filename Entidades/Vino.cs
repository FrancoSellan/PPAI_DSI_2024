using PPAI_DSI_2024.Datos;
using PPAI_DSI_2024.Entidades;
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
        private Varietal varietal;
        private Bodega bodega;
        private GeneradorDeDatos generadorDatos;

        // Constructor
        public Vino (double añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, int notaDeCataBodega, int precioARS, Varietal varietal, Bodega bodega)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.varietal = varietal;
            this.bodega = bodega;
            this.generadorDatos = new GeneradorDeDatos();
            
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
        public Varietal Varietal { get => varietal; set => varietal = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }
        public GeneradorDeDatos GeneradorDatos { get => generadorDatos; set => generadorDatos = value; }

        // Metodos
        //public bool tenesResenasDeTipoEnPeriodo()
        //{
        //    List<Reseña> resenas = generadorDatos.getResenas();
        //    for (int i = 0; i < resenas.Count; i++)
        //    {
        //        if (resenas[i].sosDePeriodo() && resenas[i].esPremium())
        //        {
        //            return true;
        //        } else
        //        {
        //            return false;
        //        }
        //    }
            
        //}
    }
}
