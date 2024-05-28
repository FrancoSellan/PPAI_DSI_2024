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
    public partial class BonVino : Form
    {
        public BonVino()
        {
            InitializeComponent();
        }

        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            PantallaGenerarRankingDeVinos ventana = new PantallaGenerarRankingDeVinos();
            ventana.Show();
            this.Hide();
        }

        private void BonVino_Load(object sender, EventArgs e)
        {

        }
    }
}
