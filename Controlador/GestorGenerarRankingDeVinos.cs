﻿using PPAI_DSI_2024.Entidades;
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
        private Vino vinoEj;
        private Bodega BodegaVino;
        private RegionVitivinicola regionBodega;
        private Pais paisBodega;
        private Varietal varietalVino;
        private float puntajeSomelliers;

        // Constructor
        public GestorGenerarRankingDeVinos (PantallaGenerarRankingDeVinos pantalla, DateTime fechaDesde, DateTime fechaHasta, string tipoResena, string tipoVisualizacion)
        {
            this.pantalla = pantalla;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tipoResena = tipoResena;
            this.tipoVisualizacion = tipoVisualizacion;
            //this.vinoEj = vino;
            //this.BodegaVino = BodegaVino;
            //this.regionBodega = regionBodega;
            //this.paisBodega = paisBodega;
            //this.varietalVino = varietalVino;
            //this.puntajeSomelliers = puntajeSomelliers;
        }

        // Metodos get y set
        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public string TipoResena { get => tipoResena; set => tipoResena = value; }
        public string TipoVisualizacion { get => tipoVisualizacion; set => tipoVisualizacion = value; }
        public Bodega NombreBodegaVino { get => BodegaVino; set => BodegaVino = value; }
        public RegionVitivinicola RegionBodega { get => regionBodega; set => regionBodega = value; }
        public Pais PaisBodega { get => paisBodega; set => paisBodega = value; }
        public Varietal VarietalVino { get => varietalVino; set => varietalVino = value; }
        public float PuntajeSomelliers { get => puntajeSomelliers; set => puntajeSomelliers = value; }
        public Vino VinoEj { get => vinoEj; set => vinoEj = value; }
        public PantallaGenerarRankingDeVinos Pantalla { get => pantalla; set => pantalla = value; }

        public void opcionGenerarRankingDeVinos(PantallaGenerarRankingDeVinos pantalla)
        {
            pantalla.pedirDatosRanking();
        }

        public void tomarSeleccionFechaDesdeYHasta()
        {
            fechaDesde = pantalla.tomarFechaDesde();
            fechaHasta = pantalla.tomarFechaHasta();
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

            if (fechaDesde != null && (fechaHasta > fechaDesde) && tipoResena == "De somellier" && tipoVisualizacion == "Excel")
            {
                MessageBox.Show("Reporte confirmado!");
            } else
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            
        }
    }
}