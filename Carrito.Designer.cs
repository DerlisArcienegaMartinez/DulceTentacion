
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
            this.pictureBoxDerecha = new System.Windows.Forms.PictureBox();
            this.pictureBoxCentral = new System.Windows.Forms.PictureBox();
            this.pictureBoxIzquierda = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDerecha
            // 
            this.pictureBoxDerecha.Location = new System.Drawing.Point(487, 107);
            this.pictureBoxDerecha.Name = "pictureBoxDerecha";
            this.pictureBoxDerecha.Size = new System.Drawing.Size(216, 219);
            this.pictureBoxDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDerecha.TabIndex = 0;
            this.pictureBoxDerecha.TabStop = false;
            // 
            // pictureBoxCentral
            // 
            this.pictureBoxCentral.Location = new System.Drawing.Point(274, 143);
            this.pictureBoxCentral.Name = "pictureBoxCentral";
            this.pictureBoxCentral.Size = new System.Drawing.Size(279, 260);
            this.pictureBoxCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCentral.TabIndex = 1;
            this.pictureBoxCentral.TabStop = false;
            // 
            // pictureBoxIzquierda
            // 
            this.pictureBoxIzquierda.Location = new System.Drawing.Point(119, 107);
            this.pictureBoxIzquierda.Name = "pictureBoxIzquierda";
            this.pictureBoxIzquierda.Size = new System.Drawing.Size(216, 219);
            this.pictureBoxIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIzquierda.TabIndex = 2;
            this.pictureBoxIzquierda.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(257, 454);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(134, 51);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "button1";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(474, 454);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(134, 51);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "button2";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 598);
            this.Controls.Add(this.pictureBoxCentral);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pictureBoxIzquierda);
            this.Controls.Add(this.pictureBoxDerecha);
            this.Name = "Carrito";
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzquierda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDerecha;
        private System.Windows.Forms.PictureBox pictureBoxCentral;
        private System.Windows.Forms.PictureBox pictureBoxIzquierda;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}