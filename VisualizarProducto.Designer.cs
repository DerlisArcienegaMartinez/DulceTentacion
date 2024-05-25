
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAllProd = new System.Windows.Forms.Button();
            this.btnProdAgo = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.btnRegresar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 45);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(18)))), ((int)(((byte)(143)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DulceTentacion.Properties.Resources.regresar3_removebg_preview;
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
            this.btnAddProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAddProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(408, 51);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(198, 42);
            this.btnAddProd.TabIndex = 19;
            this.btnAddProd.Text = "Añadir Producto";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 541);
            this.dataGridView1.TabIndex = 20;
            // 
            // VisualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(987, 674);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAllProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnProdAgo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarProducto";
            this.Text = "VisualizarProducto";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAllProd;
        private System.Windows.Forms.Button btnProdAgo;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}