﻿
namespace DulceTentacion
{
    partial class Carrito
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlCesta = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.BarraHorizontal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlDPersonal = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCU = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDRecojo = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.CBSucursal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaR = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.CBHorario = new System.Windows.Forms.ComboBox();
            this.CBReserva = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlFPago = new System.Windows.Forms.Panel();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.pnlCesta.SuspendLayout();
            this.BarraHorizontal.SuspendLayout();
            this.pnlDPersonal.SuspendLayout();
            this.pnlDRecojo.SuspendLayout();
            this.pnlFPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Blue;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(389, 593);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(200, 60);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(179, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlCesta
            // 
            this.pnlCesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlCesta.Controls.Add(this.label16);
            this.pnlCesta.Location = new System.Drawing.Point(617, 79);
            this.pnlCesta.Name = "pnlCesta";
            this.pnlCesta.Size = new System.Drawing.Size(351, 534);
            this.pnlCesta.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(153, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 25);
            this.label16.TabIndex = 79;
            this.label16.Text = "Su cesta esta vacia";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarraHorizontal
            // 
            this.BarraHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BarraHorizontal.Controls.Add(this.btnRegresar);
            this.BarraHorizontal.Location = new System.Drawing.Point(0, 0);
            this.BarraHorizontal.Name = "BarraHorizontal";
            this.BarraHorizontal.Size = new System.Drawing.Size(994, 46);
            this.BarraHorizontal.TabIndex = 52;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DulceTentacion.Properties.Resources.boton_atras;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(194, 41);
            this.btnRegresar.TabIndex = 53;
            this.btnRegresar.Text = "       Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pnlDPersonal
            // 
            this.pnlDPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDPersonal.Controls.Add(this.label8);
            this.pnlDPersonal.Controls.Add(this.txtCelular);
            this.pnlDPersonal.Controls.Add(this.txtDomicilio);
            this.pnlDPersonal.Controls.Add(this.label6);
            this.pnlDPersonal.Controls.Add(this.txtCU);
            this.pnlDPersonal.Controls.Add(this.txtApPaterno);
            this.pnlDPersonal.Controls.Add(this.txtNombre);
            this.pnlDPersonal.Controls.Add(this.label7);
            this.pnlDPersonal.Controls.Add(this.label4);
            this.pnlDPersonal.Controls.Add(this.label3);
            this.pnlDPersonal.Controls.Add(this.label5);
            this.pnlDPersonal.Location = new System.Drawing.Point(12, 63);
            this.pnlDPersonal.Name = "pnlDPersonal";
            this.pnlDPersonal.Size = new System.Drawing.Size(593, 182);
            this.pnlDPersonal.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Datos Personales";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(329, 47);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(146, 22);
            this.txtCelular.TabIndex = 69;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(175, 144);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(300, 22);
            this.txtDomicilio.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Celular:";
            // 
            // txtCU
            // 
            this.txtCU.Location = new System.Drawing.Point(95, 47);
            this.txtCU.Name = "txtCU";
            this.txtCU.Size = new System.Drawing.Size(100, 22);
            this.txtCU.TabIndex = 67;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(121, 111);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(300, 22);
            this.txtApPaterno.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Dirección Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "C.I:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nombre:";
            // 
            // pnlDRecojo
            // 
            this.pnlDRecojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDRecojo.Controls.Add(this.label13);
            this.pnlDRecojo.Controls.Add(this.CBSucursal);
            this.pnlDRecojo.Controls.Add(this.label9);
            this.pnlDRecojo.Controls.Add(this.dtpFechaR);
            this.pnlDRecojo.Controls.Add(this.label10);
            this.pnlDRecojo.Controls.Add(this.CBHorario);
            this.pnlDRecojo.Controls.Add(this.CBReserva);
            this.pnlDRecojo.Controls.Add(this.txtHora);
            this.pnlDRecojo.Controls.Add(this.label11);
            this.pnlDRecojo.Controls.Add(this.label12);
            this.pnlDRecojo.Location = new System.Drawing.Point(12, 276);
            this.pnlDRecojo.Name = "pnlDRecojo";
            this.pnlDRecojo.Size = new System.Drawing.Size(593, 149);
            this.pnlDRecojo.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 25);
            this.label13.TabIndex = 71;
            this.label13.Text = "Datos para recojer";
            // 
            // CBSucursal
            // 
            this.CBSucursal.FormattingEnabled = true;
            this.CBSucursal.Items.AddRange(new object[] {
            "Principal",
            "Sucursal 1",
            "Sucursal 2",
            "Sucursal 3"});
            this.CBSucursal.Location = new System.Drawing.Point(104, 37);
            this.CBSucursal.Name = "CBSucursal";
            this.CBSucursal.Size = new System.Drawing.Size(246, 24);
            this.CBSucursal.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Sucursal:";
            // 
            // dtpFechaR
            // 
            this.dtpFechaR.Location = new System.Drawing.Point(172, 109);
            this.dtpFechaR.Name = "dtpFechaR";
            this.dtpFechaR.Size = new System.Drawing.Size(291, 22);
            this.dtpFechaR.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fecha de entrega:";
            // 
            // CBHorario
            // 
            this.CBHorario.FormattingEnabled = true;
            this.CBHorario.Items.AddRange(new object[] {
            "AM.",
            "PM."});
            this.CBHorario.Location = new System.Drawing.Point(232, 73);
            this.CBHorario.Name = "CBHorario";
            this.CBHorario.Size = new System.Drawing.Size(66, 24);
            this.CBHorario.TabIndex = 42;
            // 
            // CBReserva
            // 
            this.CBReserva.FormattingEnabled = true;
            this.CBReserva.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CBReserva.Location = new System.Drawing.Point(469, 37);
            this.CBReserva.Name = "CBReserva";
            this.CBReserva.Size = new System.Drawing.Size(93, 24);
            this.CBReserva.TabIndex = 41;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(152, 73);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(74, 22);
            this.txtHora.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Hora de entrega:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(385, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Delivery:";
            // 
            // pnlFPago
            // 
            this.pnlFPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlFPago.Controls.Add(this.btnEfectivo);
            this.pnlFPago.Controls.Add(this.btnQR);
            this.pnlFPago.Controls.Add(this.label14);
            this.pnlFPago.Location = new System.Drawing.Point(12, 459);
            this.pnlFPago.Name = "pnlFPago";
            this.pnlFPago.Size = new System.Drawing.Size(593, 108);
            this.pnlFPago.TabIndex = 55;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Location = new System.Drawing.Point(308, 40);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(184, 51);
            this.btnEfectivo.TabIndex = 74;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = false;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQR.Location = new System.Drawing.Point(72, 40);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(184, 51);
            this.btnQR.TabIndex = 56;
            this.btnQR.Text = "QR";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 25);
            this.label14.TabIndex = 72;
            this.label14.Text = "Formas de pago";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(611, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 25);
            this.label15.TabIndex = 71;
            this.label15.Text = "Carrito";
            // 
            // btnMas
            // 
            this.btnMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMas.BackColor = System.Drawing.Color.Blue;
            this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Image = global::DulceTentacion.Properties.Resources.IconoMas;
            this.btnMas.Location = new System.Drawing.Point(888, 51);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(80, 30);
            this.btnMas.TabIndex = 75;
            this.btnMas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DulceTentacion.Properties.Resources.Icono_Whatsapp;
            this.pictureBox1.Location = new System.Drawing.Point(10, 619);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DulceTentacion.Properties.Resources.Emblema;
            this.pictureBox2.Location = new System.Drawing.Point(0, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 631);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(891, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Bs.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Costo Total:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(779, 623);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(106, 30);
            this.txtCostoTotal.TabIndex = 76;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1013, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlFPago);
            this.Controls.Add(this.pnlDRecojo);
            this.Controls.Add(this.pnlDPersonal);
            this.Controls.Add(this.BarraHorizontal);
            this.Controls.Add(this.pnlCesta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.pnlCesta.ResumeLayout(false);
            this.pnlCesta.PerformLayout();
            this.BarraHorizontal.ResumeLayout(false);
            this.pnlDPersonal.ResumeLayout(false);
            this.pnlDPersonal.PerformLayout();
            this.pnlDRecojo.ResumeLayout(false);
            this.pnlDRecojo.PerformLayout();
            this.pnlFPago.ResumeLayout(false);
            this.pnlFPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCesta;
        private System.Windows.Forms.FlowLayoutPanel BarraHorizontal;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnlDPersonal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCU;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlDRecojo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBSucursal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBHorario;
        private System.Windows.Forms.ComboBox CBReserva;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlFPago;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoTotal;
    }
}