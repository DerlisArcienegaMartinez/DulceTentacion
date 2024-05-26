
namespace DulceTentacion
{
    partial class Ubicacion
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
            this.ContUbicacion = new System.Windows.Forms.Panel();
            this.CBModo = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.LinkLabel();
            this.GBOpinionGeneral = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.RBExcelente = new System.Windows.Forms.RadioButton();
            this.RBBuena = new System.Windows.Forms.RadioButton();
            this.RBRegular = new System.Windows.Forms.RadioButton();
            this.RBMala = new System.Windows.Forms.RadioButton();
            this.RBPesima = new System.Windows.Forms.RadioButton();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.LinkLabel();
            this.btnSucursal1 = new System.Windows.Forms.Button();
            this.btnSucursal3 = new System.Windows.Forms.Button();
            this.btnSucursal2 = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.MapUbi = new GMap.NET.WindowsForms.GMapControl();
            this.BarraHorizontal = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.ContUbicacion.SuspendLayout();
            this.GBOpinionGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContUbicacion
            // 
            this.ContUbicacion.Controls.Add(this.BarraHorizontal);
            this.ContUbicacion.Controls.Add(this.CBModo);
            this.ContUbicacion.Controls.Add(this.lblSucursal);
            this.ContUbicacion.Controls.Add(this.GBOpinionGeneral);
            this.ContUbicacion.Controls.Add(this.lblReserva);
            this.ContUbicacion.Controls.Add(this.btnSucursal1);
            this.ContUbicacion.Controls.Add(this.btnSucursal3);
            this.ContUbicacion.Controls.Add(this.btnSucursal2);
            this.ContUbicacion.Controls.Add(this.btnPrincipal);
            this.ContUbicacion.Controls.Add(this.MapUbi);
            this.ContUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContUbicacion.Location = new System.Drawing.Point(0, 0);
            this.ContUbicacion.Name = "ContUbicacion";
            this.ContUbicacion.Size = new System.Drawing.Size(1013, 674);
            this.ContUbicacion.TabIndex = 15;
            // 
            // CBModo
            // 
            this.CBModo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBModo.FormattingEnabled = true;
            this.CBModo.Items.AddRange(new object[] {
            "Mapa Normal",
            "Mapa Satélite"});
            this.CBModo.Location = new System.Drawing.Point(12, 62);
            this.CBModo.Name = "CBModo";
            this.CBModo.Size = new System.Drawing.Size(221, 24);
            this.CBModo.TabIndex = 48;
            this.CBModo.SelectedIndexChanged += new System.EventHandler(this.CBModo_SelectedIndexChanged_1);
            // 
            // lblSucursal
            // 
            this.lblSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(483, 226);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(208, 20);
            this.lblSucursal.TabIndex = 47;
            this.lblSucursal.TabStop = true;
            this.lblSucursal.Text = "Visite nuestras sucursales";
            // 
            // GBOpinionGeneral
            // 
            this.GBOpinionGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GBOpinionGeneral.Controls.Add(this.pictureBox1);
            this.GBOpinionGeneral.Controls.Add(this.btnEnviar);
            this.GBOpinionGeneral.Controls.Add(this.RBExcelente);
            this.GBOpinionGeneral.Controls.Add(this.RBBuena);
            this.GBOpinionGeneral.Controls.Add(this.RBRegular);
            this.GBOpinionGeneral.Controls.Add(this.RBMala);
            this.GBOpinionGeneral.Controls.Add(this.RBPesima);
            this.GBOpinionGeneral.Controls.Add(this.txtOpinion);
            this.GBOpinionGeneral.Controls.Add(this.label6);
            this.GBOpinionGeneral.Controls.Add(this.label3);
            this.GBOpinionGeneral.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpinionGeneral.Location = new System.Drawing.Point(477, 263);
            this.GBOpinionGeneral.Name = "GBOpinionGeneral";
            this.GBOpinionGeneral.Size = new System.Drawing.Size(508, 334);
            this.GBOpinionGeneral.TabIndex = 42;
            this.GBOpinionGeneral.TabStop = false;
            this.GBOpinionGeneral.Text = "Escribe una opinión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DulceTentacion.Properties.Resources.Icono_Whatsapp;
            this.pictureBox1.Location = new System.Drawing.Point(448, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(171, 266);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(148, 35);
            this.btnEnviar.TabIndex = 39;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // RBExcelente
            // 
            this.RBExcelente.AutoSize = true;
            this.RBExcelente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBExcelente.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBExcelente.Location = new System.Drawing.Point(395, 225);
            this.RBExcelente.Name = "RBExcelente";
            this.RBExcelente.Size = new System.Drawing.Size(103, 24);
            this.RBExcelente.TabIndex = 37;
            this.RBExcelente.TabStop = true;
            this.RBExcelente.Text = "Excelente";
            this.RBExcelente.UseVisualStyleBackColor = true;
            // 
            // RBBuena
            // 
            this.RBBuena.AutoSize = true;
            this.RBBuena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBBuena.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBuena.Location = new System.Drawing.Point(302, 225);
            this.RBBuena.Name = "RBBuena";
            this.RBBuena.Size = new System.Drawing.Size(78, 24);
            this.RBBuena.TabIndex = 38;
            this.RBBuena.TabStop = true;
            this.RBBuena.Text = "Buena";
            this.RBBuena.UseVisualStyleBackColor = true;
            // 
            // RBRegular
            // 
            this.RBRegular.AutoSize = true;
            this.RBRegular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBRegular.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBRegular.Location = new System.Drawing.Point(198, 225);
            this.RBRegular.Name = "RBRegular";
            this.RBRegular.Size = new System.Drawing.Size(89, 24);
            this.RBRegular.TabIndex = 36;
            this.RBRegular.TabStop = true;
            this.RBRegular.Text = "Regular";
            this.RBRegular.UseVisualStyleBackColor = true;
            // 
            // RBMala
            // 
            this.RBMala.AutoSize = true;
            this.RBMala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBMala.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMala.Location = new System.Drawing.Point(112, 225);
            this.RBMala.Name = "RBMala";
            this.RBMala.Size = new System.Drawing.Size(67, 24);
            this.RBMala.TabIndex = 35;
            this.RBMala.TabStop = true;
            this.RBMala.Text = "Mala";
            this.RBMala.UseVisualStyleBackColor = true;
            // 
            // RBPesima
            // 
            this.RBPesima.AutoSize = true;
            this.RBPesima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBPesima.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPesima.Location = new System.Drawing.Point(10, 225);
            this.RBPesima.Name = "RBPesima";
            this.RBPesima.Size = new System.Drawing.Size(84, 24);
            this.RBPesima.TabIndex = 34;
            this.RBPesima.TabStop = true;
            this.RBPesima.Text = "Pésima";
            this.RBPesima.UseVisualStyleBackColor = true;
            // 
            // txtOpinion
            // 
            this.txtOpinion.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpinion.Location = new System.Drawing.Point(24, 36);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.Size = new System.Drawing.Size(455, 120);
            this.txtOpinion.TabIndex = 35;
            this.txtOpinion.Text = "Describe tu experiencia (opcional)";
            this.txtOpinion.Leave += new System.EventHandler(this.txtOpinion_Leave_1);
            this.txtOpinion.MouseEnter += new System.EventHandler(this.txtOpinion_MouseEnter_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Selecciona tu experiencia personal (opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Califica esta app";
            // 
            // lblReserva
            // 
            this.lblReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReserva.AutoSize = true;
            this.lblReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReserva.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(464, 619);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(483, 24);
            this.lblReserva.TabIndex = 41;
            this.lblReserva.TabStop = true;
            this.lblReserva.Text = "¿Desea realizar una reservación en la sucursal que desee?";
            this.lblReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReserva_LinkClicked);
            // 
            // btnSucursal1
            // 
            this.btnSucursal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSucursal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnSucursal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucursal1.FlatAppearance.BorderSize = 0;
            this.btnSucursal1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnSucursal1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnSucursal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursal1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursal1.Location = new System.Drawing.Point(743, 62);
            this.btnSucursal1.Name = "btnSucursal1";
            this.btnSucursal1.Size = new System.Drawing.Size(227, 72);
            this.btnSucursal1.TabIndex = 40;
            this.btnSucursal1.Text = "Sucursal 1";
            this.btnSucursal1.UseVisualStyleBackColor = false;
            this.btnSucursal1.Click += new System.EventHandler(this.btnSucursal1_Click_1);
            // 
            // btnSucursal3
            // 
            this.btnSucursal3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSucursal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(215)))), ((int)(((byte)(242)))));
            this.btnSucursal3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucursal3.FlatAppearance.BorderSize = 0;
            this.btnSucursal3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnSucursal3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(215)))), ((int)(((byte)(242)))));
            this.btnSucursal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursal3.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursal3.Location = new System.Drawing.Point(743, 140);
            this.btnSucursal3.Name = "btnSucursal3";
            this.btnSucursal3.Size = new System.Drawing.Size(227, 72);
            this.btnSucursal3.TabIndex = 39;
            this.btnSucursal3.Text = "Sucursal 3";
            this.btnSucursal3.UseVisualStyleBackColor = false;
            this.btnSucursal3.Click += new System.EventHandler(this.btnSucursal3_Click_1);
            // 
            // btnSucursal2
            // 
            this.btnSucursal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSucursal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(219)))), ((int)(((byte)(118)))));
            this.btnSucursal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucursal2.FlatAppearance.BorderSize = 0;
            this.btnSucursal2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSucursal2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(219)))), ((int)(((byte)(118)))));
            this.btnSucursal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursal2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursal2.Location = new System.Drawing.Point(501, 140);
            this.btnSucursal2.Name = "btnSucursal2";
            this.btnSucursal2.Size = new System.Drawing.Size(227, 72);
            this.btnSucursal2.TabIndex = 38;
            this.btnSucursal2.Text = "Sucursal 2";
            this.btnSucursal2.UseVisualStyleBackColor = false;
            this.btnSucursal2.Click += new System.EventHandler(this.btnSucursal2_Click_1);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(83)))));
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(83)))));
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(501, 62);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(227, 72);
            this.btnPrincipal.TabIndex = 37;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click_1);
            // 
            // MapUbi
            // 
            this.MapUbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapUbi.Bearing = 0F;
            this.MapUbi.CanDragMap = true;
            this.MapUbi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapUbi.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapUbi.GrayScaleMode = false;
            this.MapUbi.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapUbi.LevelsKeepInMemmory = 5;
            this.MapUbi.Location = new System.Drawing.Point(12, 87);
            this.MapUbi.MarkersEnabled = true;
            this.MapUbi.MaxZoom = 2;
            this.MapUbi.MinZoom = 2;
            this.MapUbi.MouseWheelZoomEnabled = true;
            this.MapUbi.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapUbi.Name = "MapUbi";
            this.MapUbi.NegativeMode = false;
            this.MapUbi.PolygonsEnabled = true;
            this.MapUbi.RetryLoadTile = 0;
            this.MapUbi.RoutesEnabled = true;
            this.MapUbi.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapUbi.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapUbi.ShowTileGridLines = false;
            this.MapUbi.Size = new System.Drawing.Size(446, 575);
            this.MapUbi.TabIndex = 36;
            this.MapUbi.Zoom = 0D;
            // 
            // BarraHorizontal
            // 
            this.BarraHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BarraHorizontal.Controls.Add(this.btnRegresar);
            this.BarraHorizontal.Location = new System.Drawing.Point(0, 0);
            this.BarraHorizontal.Name = "BarraHorizontal";
            this.BarraHorizontal.Size = new System.Drawing.Size(1013, 46);
            this.BarraHorizontal.TabIndex = 49;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DulceTentacion.Properties.Resources.boton_atras;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(174, 38);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "          Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1013, 674);
            this.Controls.Add(this.ContUbicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubicacion";
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            this.ContUbicacion.ResumeLayout(false);
            this.ContUbicacion.PerformLayout();
            this.GBOpinionGeneral.ResumeLayout(false);
            this.GBOpinionGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ContUbicacion;
        private System.Windows.Forms.ComboBox CBModo;
        private System.Windows.Forms.LinkLabel lblSucursal;
  
        private System.Windows.Forms.GroupBox GBOpinionGeneral;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RadioButton RBExcelente;
        private System.Windows.Forms.RadioButton RBBuena;
        private System.Windows.Forms.RadioButton RBRegular;
        private System.Windows.Forms.RadioButton RBMala;
        private System.Windows.Forms.RadioButton RBPesima;
        private System.Windows.Forms.TextBox txtOpinion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblReserva;
        private System.Windows.Forms.Button btnSucursal1;
        private System.Windows.Forms.Button btnSucursal3;
        private System.Windows.Forms.Button btnSucursal2;
        private System.Windows.Forms.Button btnPrincipal;
        private GMap.NET.WindowsForms.GMapControl MapUbi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraHorizontal;
        private System.Windows.Forms.Button btnRegresar;
    }
}