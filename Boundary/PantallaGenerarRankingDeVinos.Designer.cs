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
            this.btnIngresarFechas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResenas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTiposVisualizacion = new System.Windows.Forms.ComboBox();
            this.btnConfirmacionGenReporte = new System.Windows.Forms.Button();
            this.gdrVinos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionVarietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 19);
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
            // btnIngresarFechas
            // 
            this.btnIngresarFechas.Location = new System.Drawing.Point(339, 38);
            this.btnIngresarFechas.Name = "btnIngresarFechas";
            this.btnIngresarFechas.Size = new System.Drawing.Size(136, 24);
            this.btnIngresarFechas.TabIndex = 3;
            this.btnIngresarFechas.Text = "Ingresar fechas";
            this.btnIngresarFechas.UseVisualStyleBackColor = true;
            this.btnIngresarFechas.Click += new System.EventHandler(this.btnIngresarFechas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
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
            this.label3.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 19);
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
            this.btnConfirmacionGenReporte.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmacionGenReporte.Location = new System.Drawing.Point(20, 202);
            this.btnConfirmacionGenReporte.Name = "btnConfirmacionGenReporte";
            this.btnConfirmacionGenReporte.Size = new System.Drawing.Size(114, 50);
            this.btnConfirmacionGenReporte.TabIndex = 8;
            this.btnConfirmacionGenReporte.Text = "Confirmar reporte";
            this.btnConfirmacionGenReporte.UseVisualStyleBackColor = true;
            this.btnConfirmacionGenReporte.Click += new System.EventHandler(this.tomarConfirmacionGenReporte);
            // 
            // gdrVinos
            // 
            this.gdrVinos.AllowUserToAddRows = false;
            this.gdrVinos.AllowUserToDeleteRows = false;
            this.gdrVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrVinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.NombreBodega,
            this.NombreRegion,
            this.NombrePais,
            this.DescripcionVarietal,
            this.Puntaje});
            this.gdrVinos.Location = new System.Drawing.Point(390, 222);
            this.gdrVinos.Name = "gdrVinos";
            this.gdrVinos.ReadOnly = true;
            this.gdrVinos.Size = new System.Drawing.Size(744, 322);
            this.gdrVinos.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // NombreBodega
            // 
            this.NombreBodega.HeaderText = "NombreBodega";
            this.NombreBodega.Name = "NombreBodega";
            this.NombreBodega.ReadOnly = true;
            // 
            // NombreRegion
            // 
            this.NombreRegion.HeaderText = "NombreRegion";
            this.NombreRegion.Name = "NombreRegion";
            this.NombreRegion.ReadOnly = true;
            // 
            // NombrePais
            // 
            this.NombrePais.HeaderText = "NombrePais";
            this.NombrePais.Name = "NombrePais";
            this.NombrePais.ReadOnly = true;
            // 
            // DescripcionVarietal
            // 
            this.DescripcionVarietal.HeaderText = "DescripcionVarietal";
            this.DescripcionVarietal.Name = "DescripcionVarietal";
            this.DescripcionVarietal.ReadOnly = true;
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Location = new System.Drawing.Point(20, 284);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(114, 55);
            this.btnExportarExcel.TabIndex = 10;
            this.btnExportarExcel.Text = "Exportar excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(20, 365);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(114, 55);
            this.btnLimpiarDatos.TabIndex = 11;
            this.btnLimpiarDatos.Text = "Limpiar datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // PantallaGenerarRankingDeVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1164, 579);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.gdrVinos);
            this.Controls.Add(this.btnConfirmacionGenReporte);
            this.Controls.Add(this.cmbTiposVisualizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbResenas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresarFechas);
            this.Controls.Add(this.mskFechaHasta);
            this.Controls.Add(this.mskFechaDesde);
            this.Controls.Add(this.label1);
            this.Name = "PantallaGenerarRankingDeVinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaGenerarRankingDeVinos";
            this.Load += new System.EventHandler(this.PantallaGenerarRankingDeVinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrVinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskFechaDesde;
        private System.Windows.Forms.MaskedTextBox mskFechaHasta;
        private System.Windows.Forms.Button btnIngresarFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResenas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTiposVisualizacion;
        private System.Windows.Forms.Button btnConfirmacionGenReporte;
        private System.Windows.Forms.DataGridView gdrVinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionVarietal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnLimpiarDatos;
    }
}