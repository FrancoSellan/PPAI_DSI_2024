using PPAI_DSI_2024.Boundary;
using PPAI_DSI_2024.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_2024
{
    public partial class PantallaGenerarRankingDeVinos : Form
    {

        // Atributos 
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string tipoResena;
        private string tipoVisualizacion;
        private GestorGenerarRankingDeVinos gestor;
        

        // Constructor
        public PantallaGenerarRankingDeVinos (DateTime fechaDesde, DateTime fechaHasta, string tipoResena, string tipoVisualizacion, interfazExcel pantallaExcel)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tipoResena = tipoResena;
            this.tipoVisualizacion = tipoVisualizacion;
            
        }

        // Metodos get y set
        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public string TipoResena { get => tipoResena; set => tipoResena = value; }
        public string TipoVisualizacion { get => tipoVisualizacion; set => tipoVisualizacion = value; }
        

        public PantallaGenerarRankingDeVinos()
        {
            habilitarVentana();
        }
        public void habilitarVentana()
        {
            InitializeComponent();
        }

        private void PantallaGenerarRankingDeVinos_Load(object sender, EventArgs e)
        {
            interfazExcel pantallaExcel = new interfazExcel();
            gestor = new GestorGenerarRankingDeVinos(this, fechaDesde, fechaHasta, tipoResena, tipoVisualizacion, pantallaExcel);
            gestor.opcionGenerarRankingDeVinos(this);
            cmbResenas.Items.Add("Normal");
            cmbResenas.Items.Add("De somellier");
            cmbResenas.Items.Add("De amigos");
            cmbTiposVisualizacion.Items.Add("PDF");
            cmbTiposVisualizacion.Items.Add("Excel");
            cmbTiposVisualizacion.Items.Add("pantalla");
        }

        public DateTime tomarFechaDesde()
        {
            return Convert.ToDateTime(mskFechaDesde.Text);
        }

        public DateTime tomarFechaHasta()
        {
            return Convert.ToDateTime(mskFechaHasta.Text);
        }

        public string tomarTipoResena()
        {
            return Convert.ToString(cmbResenas.Text);
        }

        public string tomarTipoVisualizacion()
        {
            return Convert.ToString(cmbTiposVisualizacion.Text);
        }

        public void pedirDatosRanking()
        {
            btnConfirmacionGenReporte.Enabled = true;
        }

        private void btnIngresarFechas_Click(object sender, EventArgs e)
        {
            fechaDesde = tomarFechaDesde();
            fechaHasta = tomarFechaHasta();
            ValidarPeriodo(tomarFechaDesde(), tomarFechaHasta());
        }

        private void ValidarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("El periodo ingresado es incorrecto");
            } else
            {
                MessageBox.Show("Periodo correcto");
            }
        }

        public void mostrarVinos(List<List<string>> vinosParaExcel)
        {
            
            
            for (int i = 0; i < 4;  i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaPrecio = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaBodega = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaRegion = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaPais = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaVarietal = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell celdaPuntaje = new DataGridViewTextBoxCell();

                celdaNombre.Value = vinosParaExcel[i][0];
                fila.Cells.Add(celdaNombre);

                celdaPrecio.Value = vinosParaExcel[i][1];
                fila.Cells.Add(celdaPrecio);

                celdaBodega.Value = vinosParaExcel[i][2];
                fila.Cells.Add(celdaBodega);

                celdaRegion.Value = vinosParaExcel[i][3];
                fila.Cells.Add(celdaRegion);

                celdaPais.Value = vinosParaExcel[i][4];
                fila.Cells.Add(celdaPais);

                celdaVarietal.Value = vinosParaExcel[i][5];
                fila.Cells.Add(celdaVarietal);

                celdaPuntaje.Value = vinosParaExcel[i][6];
                fila.Cells.Add(celdaPuntaje);

                gdrVinos.Rows.Add(fila);
            }
            
        }


        public void tomarConfirmacionGenReporte(object sender, EventArgs e)
        {
            gestor.tomarConfirmacionGenReporte();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            gestor.exportarExcel();
        }
    }
}
