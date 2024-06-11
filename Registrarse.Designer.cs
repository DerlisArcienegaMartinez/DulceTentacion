
namespace DulceTentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.btnSelectFoto = new System.Windows.Forms.Button();
            this.GBCuenta = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ImgPerfil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFoto
            // 
            this.btnSelectFoto.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFoto.Location = new System.Drawing.Point(596, 217);
            this.btnSelectFoto.Name = "btnSelectFoto";
            this.btnSelectFoto.Size = new System.Drawing.Size(190, 36);
            this.btnSelectFoto.TabIndex = 1;
            this.btnSelectFoto.Text = "Seleccionar Foto";
            this.btnSelectFoto.UseVisualStyleBackColor = true;
            this.btnSelectFoto.Click += new System.EventHandler(this.btnSelectFoto_Click);
            // 
            // GBCuenta
            // 
            this.GBCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GBCuenta.Controls.Add(this.txtContraseña);
            this.GBCuenta.Controls.Add(this.txtNomUsuario);
            this.GBCuenta.Controls.Add(this.label19);
            this.GBCuenta.Controls.Add(this.label18);
            this.GBCuenta.Controls.Add(this.lblIdCliente);
            this.GBCuenta.Controls.Add(this.txtCI);
            this.GBCuenta.Controls.Add(this.txtApMaterno);
            this.GBCuenta.Controls.Add(this.txtApPaterno);
            this.GBCuenta.Controls.Add(this.txtNombre);
            this.GBCuenta.Controls.Add(this.label11);
            this.GBCuenta.Controls.Add(this.label4);
            this.GBCuenta.Controls.Add(this.label3);
            this.GBCuenta.Controls.Add(this.label2);
            this.GBCuenta.Controls.Add(this.label1);
            this.GBCuenta.Controls.Add(this.pictureBox1);
            this.GBCuenta.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCuenta.Location = new System.Drawing.Point(12, 25);
            this.GBCuenta.Name = "GBCuenta";
            this.GBCuenta.Size = new System.Drawing.Size(578, 432);
            this.GBCuenta.TabIndex = 2;
            this.GBCuenta.TabStop = false;
            this.GBCuenta.Text = "Crear Cuenta de Usuario";
            this.GBCuenta.Enter += new System.EventHandler(this.GBCuenta_Enter);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(223, 338);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(202, 28);
            this.txtContraseña.TabIndex = 51;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(223, 304);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(202, 28);
            this.txtNomUsuario.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(99, 343);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 23);
            this.label19.TabIndex = 49;
            this.label19.Text = "Contraseña:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(64, 309);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 23);
            this.label18.TabIndex = 48;
            this.label18.Text = "Nombre Usuario:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(157, 34);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 18);
            this.lblIdCliente.TabIndex = 37;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(261, 84);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(126, 28);
            this.txtCI.TabIndex = 27;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(184, 211);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(300, 28);
            this.txtApMaterno.TabIndex = 26;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(184, 177);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(300, 28);
            this.txtApPaterno.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 28);
            this.txtNombre.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "IdCliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "C.I:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(596, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Registrarse";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(596, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.BackColor = System.Drawing.Color.LightGray;
            this.ImgPerfil.Location = new System.Drawing.Point(596, 25);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(186, 186);
            this.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPerfil.TabIndex = 0;
            this.ImgPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DulceTentacion.Properties.Resources.Emblema;
            this.pictureBox1.Location = new System.Drawing.Point(115, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSelectFoto);
            this.Controls.Add(this.ImgPerfil);
            this.Controls.Add(this.GBCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.GBCuenta.ResumeLayout(false);
            this.GBCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPerfil;
        private System.Windows.Forms.Button btnSelectFoto;
        private System.Windows.Forms.GroupBox GBCuenta;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}