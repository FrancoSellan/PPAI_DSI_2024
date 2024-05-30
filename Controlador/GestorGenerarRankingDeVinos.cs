using PPAI_DSI_2024.Boundary;
using PPAI_DSI_2024.Datos;
using PPAI_DSI_2024.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_2024.Controlador
{
    public class GestorGenerarRankingDeVinos
    {
        // Atributos
        private PantallaGenerarRankingDeVinos pantalla;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string tipoResena;
        private string tipoVisualizacion;
        private GeneradorDeDatos generadorDatos;
        private interfazExcel pantallaExcel;
        private Vino vino;
        private string nombreBodega;
        private string region;
        private string pais;
        private string varietal;
        private int puntaje;
        

        // Constructor
        public GestorGenerarRankingDeVinos (PantallaGenerarRankingDeVinos pantalla, DateTime fechaDesde, DateTime fechaHasta, string tipoResena, string tipoVisualizacion, interfazExcel pantallaExcel)
        {
            this.pantalla = pantalla;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tipoResena = tipoResena;
            this.tipoVisualizacion = tipoVisualizacion;      
            this.generadorDatos = new GeneradorDeDatos();
            this.pantallaExcel = pantallaExcel;
        }

        // Metodos get y set
        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public string TipoResena { get => tipoResena; set => tipoResena = value; }
        public string TipoVisualizacion { get => tipoVisualizacion; set => tipoVisualizacion = value; }
        public PantallaGenerarRankingDeVinos Pantalla { get => pantalla; set => pantalla = value; }
        public interfazExcel PantallaExcel { get => pantallaExcel; set => pantallaExcel = value; }

        public void opcionGenerarRankingDeVinos(PantallaGenerarRankingDeVinos pantalla)
        {
            pantalla.solicitarSeleccionFechaDesdeYHasta();
        }

        public void tomarSeleccionFechaDesdeYHasta()
        {
            if (pantalla.validarFechas())
            {
                fechaDesde = pantalla.tomarFechaDesde();
                fechaHasta = pantalla.tomarFechaHasta();
            } else
            {
                MessageBox.Show("Ingrese un periodo correcto");
            }
            
        }


        public void tomarTipoResena()
        {
            tipoResena = pantalla.tomarTipoResena();
        }

        public void tomarTipoVisualizacion()
        {
            tipoVisualizacion = pantalla.tomarTipoVisualizacion();
        }

        public void tomarConfirmacionGenReporte()
        {
            tomarSeleccionFechaDesdeYHasta();
            tomarTipoResena();
            tomarTipoVisualizacion();
            if (pantalla.validarFechas() && tipoResena == "De somellier" && tipoVisualizacion == "Excel")
            {
                MessageBox.Show("Reporte confirmado!");
                pantalla.LimpiarDatos();
               buscarVinosConResenasEnPeriodo(fechaDesde, fechaHasta);
            }  else if (tipoResena != "De somellier" && tipoVisualizacion != "Excel")
            {
                MessageBox.Show("No hay reseñas ni visualizacion disponibles");
            } else if (tipoVisualizacion != "Excel")
            {
                MessageBox.Show("No hay tipo de visualizacion disponible");
            } else if (tipoResena != "De somellier")
            {
                MessageBox.Show("No hay reseñas disponibles");
            } else if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("Ingrese un periodo correcto");
            }
            
        }

        public void buscarVinosConResenasEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<List<string>> vinosParaExcel = new List<List<string>>();
            List<Vino> vinosQueCumplenFiltros = new List<Vino>();
            List<Vino> vinos = generadorDatos.getVinos();
            for (int i = 0; i < vinos.Count; i++)
            {
                if (vinos[i].tenesResenaEnPeriodo(fechaDesde, fechaHasta))
                {
                    List<string> vinoParaExcel = new List<string>();
                    vinosQueCumplenFiltros.Add(vinos[i]);
                    string nombreVino = vinos[i].getNombre();
                    int precioVino = vinos[i].getPrecio();
                    vinoParaExcel.Add(nombreVino);
                    vinoParaExcel.Add(precioVino.ToString());
                    vinos[i].buscarInforBodega(vinoParaExcel);
                    string descVarietal = vinos[i].buscarVarietal();
                    vinoParaExcel.Add(descVarietal);
                    vinosParaExcel.Add(vinoParaExcel);

                }

            }
            calcularPuntajeDeSomellierEnPeriodo(vinosParaExcel, vinosQueCumplenFiltros);          
        }

        public void calcularPuntajeDeSomellierEnPeriodo(List<List<string>> vinosParaExcel, List<Vino> vinosQueCumplenFiltros)
        {
            for (int i =0; i < vinosQueCumplenFiltros.Count; i++)
            {
                int puntajeResena = vinosQueCumplenFiltros[i].calcularPuntajeDeSomellierEnPeriodo(fechaDesde, fechaHasta);
                vinosParaExcel[i].Add(puntajeResena.ToString());
                
            }

            ordenarVinos(vinosParaExcel);
            pantalla.mostrarVinos(vinosParaExcel);
        }

        public void ordenarVinos(List<List<string>> vinosParaExcel)
        {
            for (int i = 0; i < vinosParaExcel.Count - 1; i++)
            {
                for (int j = 0; j < vinosParaExcel.Count - 1 - i; j++)
                {
                    int puntaje1 = int.Parse(vinosParaExcel[j].Last());
                    int puntaje2 = int.Parse(vinosParaExcel[j + 1].Last());

                    if (puntaje1 < puntaje2)
                    {
                        // Intercambiar las sublistas
                        List<string> temp = vinosParaExcel[j];
                        vinosParaExcel[j] = vinosParaExcel[j + 1];
                        vinosParaExcel[j + 1] = temp;
                    }
                }
            }

        }

        public void exportarExcel()
        {
            pantallaExcel.exportarExcel();
            pantalla.confirmarExportacion();
            finCU();
        }

        public bool validarFechaResena(DateTime fechaResena)
        {
            tomarSeleccionFechaDesdeYHasta();
            if (fechaDesde < fechaResena && fechaResena < fechaHasta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void finCU()
        {
            pantalla.Close();
        }
    }
}
