
namespace DulceTentacion
{
    partial class SeleccionFoto
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
        /// 
       
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBoxCentral = new System.Windows.Forms.PictureBox();
            this.pictureBoxDerecha = new System.Windows.Forms.PictureBox();
            this.pictureBoxIzquierda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(326, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 37);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(450, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Subir Fotografía";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona tu avatar";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::DulceTentacion.Properties.Resources.icono_anterior;
            this.btnAnterior.Location = new System.Drawing.Point(19, 111);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(49, 67);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::DulceTentacion.Properties.Resources.icono_siguiente;
            this.btnSiguiente.Location = new System.Drawing.Point(519, 111);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(49, 67);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pictureBoxCentral
            // 
            this.pictureBoxCentral.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBoxCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCentral.Image = global::DulceTentacion.Properties.Resources.Avatar_Joven;
            this.pictureBoxCentral.Location = new System.Drawing.Point(195, 84);
            this.pictureBoxCentral.Name = "pictureBoxCentral";
            this.pictureBoxCentral.Size = new System.Drawing.Size(195, 176);
            this.pictureBoxCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCentral.TabIndex = 15;
            this.pictureBoxCentral.TabStop = false;
            // 
            // pictureBoxDerecha
            // 
            this.pictureBoxDerecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDerecha.Image = global::DulceTentacion.Properties.Resources.Avatar_Niño_2;
            this.pictureBoxDerecha.Location = new System.Drawing.Point(340, 50);
            this.pictureBoxDerecha.Name = "pictureBoxDerecha";
            this.pictureBoxDerecha.Size = new System.Drawing.Size(173, 174);
            this.pictureBoxDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDerecha.TabIndex = 14;
            this.pictureBoxDerecha.TabStop = false;
            // 
            // pictureBoxIzquierda
            // 
            this.pictureBoxIzquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIzquierda.Image = global::DulceTentacion.Properties.Resources.Avatar_Niño;
            this.pictureBoxIzquierda.Location = new System.Drawing.Point(74, 50);
            this.pictureBoxIzquierda.Name = "pictureBoxIzquierda";
            this.pictureBoxIzquierda.Size = new System.Drawing.Size(173, 174);
            this.pictureBoxIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIzquierda.TabIndex = 13;
            this.pictureBoxIzquierda.TabStop = false;
            // 
            // SeleccionFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(580, 339);
            this.Controls.Add(this.pictureBoxCentral);
            this.Controls.Add(this.pictureBoxDerecha);
            this.Controls.Add(this.pictureBoxIzquierda);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeleccionFoto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzquierda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.PictureBox pictureBoxCentral;
        private System.Windows.Forms.PictureBox pictureBoxDerecha;
        private System.Windows.Forms.PictureBox pictureBoxIzquierda;
    }
}