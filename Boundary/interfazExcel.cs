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
        public interfazExcel()
        {
            InitializeComponent();
        }

        private void interfazExcel_Load(object sender, EventArgs e)
        {
            
        }

        public void exportarExcel()
        {
            MessageBox.Show("Excel generado correctamente");
        }
    }
}
