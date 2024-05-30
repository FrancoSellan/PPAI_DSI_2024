using PPAI_DSI_2024.Controlador;
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
        private GestorGenerarRankingDeVinos gestor;
        public List<Reseña> resenas;
        private List<Reseña> resenasFiltradas;
        private Bodega bodega;
        private Varietal varietal;

        // Constructor
        public Vino (double añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, int notaDeCataBodega, int precioARS, List<Reseña> resenas, Bodega bodega, Varietal varietal)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.resenas = resenas;
            this.bodega = bodega;
            this.varietal = varietal;
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
        public List<Reseña> Resenas { get => resenas; set => resenas = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }
        public Varietal Varietal { get => varietal; set => varietal = value; }

        // Metodos
        public bool tenesResenaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            

            for (int i = 0; i < resenas.Count; i++)
            {
                if (resenas[i].SosDePeriodo(fechaDesde, fechaHasta) && resenas[i].essPremium())
                {
                    return true;
                }

            }
            return false;
        }

        public bool validarFechaResena(DateTime fechaResena)
        {
            if (gestor.validarFechaResena(fechaResena))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getPrecio()
        {
            return precioARS;
        }

        public void buscarInforBodega(List<string> vinoParaExcel)
        {

            string nombreBodega = bodega.getNombre();
            vinoParaExcel.Add(nombreBodega);
            bodega.obtenerRegionYPais(vinoParaExcel);

        }

        public string buscarVarietal()
        {
            string descripcion = varietal.getDescripcion();
            return descripcion;
        }

        public int calcularPuntajeDeSomellierEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            int cantResenas = 0;
            int sumaPuntajes = 0;
            for (int i = 0; i < resenas.Count; i++)
            {
                if (resenas[i].SosDePeriodo(fechaDesde, fechaHasta) && resenas[i].SosDeSomellier())
                {
                    cantResenas++;
                    sumaPuntajes += resenas[i].getPuntaje();
                    
                } 
            }

            int promedio = calcularPuntajePromedio(sumaPuntajes, cantResenas);

            return promedio;
           
        }

        public int calcularPuntajePromedio(int sumaPuntajes, int cantResenas)
        {
            int promedio = sumaPuntajes / cantResenas;
            return promedio;
        }
    }
}
