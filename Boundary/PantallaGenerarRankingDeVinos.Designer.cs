namespace PPAI_DSI_2024
{
    partial class PantallaGenerarRankingDeVinos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mskFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.btnValidarPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResenas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTiposVisualizacion = new System.Windows.Forms.ComboBox();
            this.btnConfirmacionGenReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese fechaDesde y fechaHasta de consideracion de reseñas:";
            // 
            // mskFechaDesde
            // 
            this.mskFechaDesde.Location = new System.Drawing.Point(142, 42);
            this.mskFechaDesde.Mask = "00/00/0000";
            this.mskFechaDesde.Name = "mskFechaDesde";
            this.mskFechaDesde.Size = new System.Drawing.Size(70, 20);
            this.mskFechaDesde.TabIndex = 1;
            this.mskFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // mskFechaHasta
            // 
            this.mskFechaHasta.Location = new System.Drawing.Point(218, 42);
            this.mskFechaHasta.Mask = "00/00/0000";
            this.mskFechaHasta.Name = "mskFechaHasta";
            this.mskFechaHasta.Size = new System.Drawing.Size(70, 20);
            this.mskFechaHasta.TabIndex = 2;
            this.mskFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btnValidarPeriodo
            // 
            this.btnValidarPeriodo.Location = new System.Drawing.Point(339, 38);
            this.btnValidarPeriodo.Name = "btnValidarPeriodo";
            this.btnValidarPeriodo.Size = new System.Drawing.Size(136, 24);
            this.btnValidarPeriodo.TabIndex = 3;
            this.btnValidarPeriodo.Text = "Validar periodo";
            this.btnValidarPeriodo.UseVisualStyleBackColor = true;
            this.btnValidarPeriodo.Click += new System.EventHandler(this.btnValidarPeriodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese tipo de reseña:";
            // 
            // cmbResenas
            // 
            this.cmbResenas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResenas.FormattingEnabled = true;
            this.cmbResenas.Location = new System.Drawing.Point(190, 89);
            this.cmbResenas.Name = "cmbResenas";
            this.cmbResenas.Size = new System.Drawing.Size(121, 21);
            this.cmbResenas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese un tipo de visualziacion para generar el reporte:";
            // 
            // cmbTiposVisualizacion
            // 
            this.cmbTiposVisualizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposVisualizacion.FormattingEnabled = true;
            this.cmbTiposVisualizacion.Location = new System.Drawing.Point(421, 145);
            this.cmbTiposVisualizacion.Name = "cmbTiposVisualizacion";
            this.cmbTiposVisualizacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposVisualizacion.TabIndex = 7;
            // 
            // btnConfirmacionGenReporte
            // 
            this.btnConfirmacionGenReporte.Location = new System.Drawing.Point(20, 202);
            this.btnConfirmacionGenReporte.Name = "btnConfirmacionGenReporte";
            this.btnConfirmacionGenReporte.Size = new System.Drawing.Size(114, 45);
            this.btnConfirmacionGenReporte.TabIndex = 8;
            this.btnConfirmacionGenReporte.Text = "Confirmar reporte";
            this.btnConfirmacionGenReporte.UseVisualStyleBackColor = true;
            this.btnConfirmacionGenReporte.Click += new System.EventHandler(this.tomarConfirmacionGenReporte);
            // 
            // PantallaGenerarRankingDeVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmacionGenReporte);
            this.Controls.Add(this.cmbTiposVisualizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbResenas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidarPeriodo);
            this.Controls.Add(this.mskFechaHasta);
            this.Controls.Add(this.mskFechaDesde);
            this.Controls.Add(this.label1);
            this.Name = "PantallaGenerarRankingDeVinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaGenerarRankingDeVinos";
            this.Load += new System.EventHandler(this.PantallaGenerarRankingDeVinos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskFechaDesde;
        private System.Windows.Forms.MaskedTextBox mskFechaHasta;
        private System.Windows.Forms.Button btnValidarPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResenas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposVisualizacion;
        private System.Windows.Forms.Button btnConfirmacionGenReporte;
    }
}