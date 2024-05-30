using PPAI_DSI_2024.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_2024.Boundary
{
    public partial class interfazExcel : Form
    {

        private List<Vino> listaOrdenadaVinos;
        public interfazExcel()
        {
            InitializeComponent();
        }

        private void interfazExcel_Load(object sender, EventArgs e)
        {
            
        }

        public void exportarExcel()
        {
            MessageBox.Show("Se va a generar un excel con el ranking de los 10 vinos mejores calificados por somelliers.");
        }
    }
}
