
namespace DulceTentacion
{
    partial class VisualizarProducto
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
            this.BarraHorizontal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAllProd = new System.Windows.Forms.Button();
            this.btnProdAgo = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.BarraHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraHorizontal
            // 
            this.BarraHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BarraHorizontal.Controls.Add(this.btnRegresar);
            this.BarraHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraHorizontal.Location = new System.Drawing.Point(0, 0);
            this.BarraHorizontal.Name = "BarraHorizontal";
            this.BarraHorizontal.Size = new System.Drawing.Size(987, 45);
            this.BarraHorizontal.TabIndex = 13;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(18)))), ((int)(((byte)(143)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DulceTentacion.Properties.Resources.boton_atras;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(210, 39);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "      Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAllProd
            // 
            this.btnAllProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAllProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProd.Location = new System.Drawing.Point(12, 51);
            this.btnAllProd.Name = "btnAllProd";
            this.btnAllProd.Size = new System.Drawing.Size(192, 42);
            this.btnAllProd.TabIndex = 15;
            this.btnAllProd.Text = "Todos los productos";
            this.btnAllProd.UseVisualStyleBackColor = true;
            // 
            // btnProdAgo
            // 
            this.btnProdAgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdAgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnProdAgo.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdAgo.Location = new System.Drawing.Point(210, 51);
            this.btnProdAgo.Name = "btnProdAgo";
            this.btnProdAgo.Size = new System.Drawing.Size(192, 42);
            this.btnProdAgo.TabIndex = 16;
            this.btnProdAgo.Text = "Productos agotados";
            this.btnProdAgo.UseVisualStyleBackColor = true;
            // 
            // btnEditProd
            // 
            this.btnEditProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnEditProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProd.Location = new System.Drawing.Point(612, 51);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(186, 42);
            this.btnEditProd.TabIndex = 17;
            this.btnEditProd.Text = "Editar Producto";
            this.btnEditProd.UseVisualStyleBackColor = true;
            // 
            // btnDelProd
            // 
            this.btnDelProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnDelProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProd.Location = new System.Drawing.Point(804, 51);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(180, 42);
            this.btnDelProd.TabIndex = 18;
            this.btnDelProd.Text = "Eliminar producto";
            this.btnDelProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAddProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(408, 51);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(198, 42);
            this.btnAddProd.TabIndex = 19;
            this.btnAddProd.Text = "Añadir Producto";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // dgvTablas
            // 
            this.dgvTablas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 106);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.RowHeadersWidth = 51;
            this.dgvTablas.RowTemplate.Height = 24;
            this.dgvTablas.Size = new System.Drawing.Size(963, 541);
            this.dgvTablas.TabIndex = 20;
            // 
            // VisualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(987, 674);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.btnAllProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnProdAgo);
            this.Controls.Add(this.BarraHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarProducto";
            this.Text = "VisualizarProducto";
            this.Load += new System.EventHandler(this.VisualizarProducto_Load);
            this.BarraHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BarraHorizontal;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAllProd;
        private System.Windows.Forms.Button btnProdAgo;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.DataGridView dgvTablas;
    }
}