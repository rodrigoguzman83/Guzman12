namespace WinApp
{
    partial class frmListadoCategoria
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
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.gpbBuscas = new System.Windows.Forms.GroupBox();
            this.gpbListadoCategorias = new System.Windows.Forms.GroupBox();
            this.gpbAcciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gpbBuscas.SuspendLayout();
            this.gpbListadoCategorias.SuspendLayout();
            this.gpbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Location = new System.Drawing.Point(20, 19);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(240, 20);
            this.txtBuscarCategoria.TabIndex = 1;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(284, 16);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCategoria.TabIndex = 2;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(36, 36);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(318, 150);
            this.dgvCategorias.TabIndex = 3;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(20, 36);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 4;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCategoria.Location = new System.Drawing.Point(122, 36);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 5;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(225, 36);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 6;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // gpbBuscas
            // 
            this.gpbBuscas.Controls.Add(this.txtBuscarCategoria);
            this.gpbBuscas.Controls.Add(this.btnBuscarCategoria);
            this.gpbBuscas.Location = new System.Drawing.Point(37, 22);
            this.gpbBuscas.Name = "gpbBuscas";
            this.gpbBuscas.Size = new System.Drawing.Size(389, 54);
            this.gpbBuscas.TabIndex = 7;
            this.gpbBuscas.TabStop = false;
            this.gpbBuscas.Text = "Busqueda";
            // 
            // gpbListadoCategorias
            // 
            this.gpbListadoCategorias.Controls.Add(this.dgvCategorias);
            this.gpbListadoCategorias.Location = new System.Drawing.Point(37, 104);
            this.gpbListadoCategorias.Name = "gpbListadoCategorias";
            this.gpbListadoCategorias.Size = new System.Drawing.Size(389, 222);
            this.gpbListadoCategorias.TabIndex = 3;
            this.gpbListadoCategorias.TabStop = false;
            this.gpbListadoCategorias.Text = "Listado de Categorias";
            // 
            // gpbAcciones
            // 
            this.gpbAcciones.Controls.Add(this.btnAgregarCategoria);
            this.gpbAcciones.Controls.Add(this.btnModificarCategoria);
            this.gpbAcciones.Controls.Add(this.btnEliminarCategoria);
            this.gpbAcciones.Location = new System.Drawing.Point(37, 346);
            this.gpbAcciones.Name = "gpbAcciones";
            this.gpbAcciones.Size = new System.Drawing.Size(389, 99);
            this.gpbAcciones.TabIndex = 4;
            this.gpbAcciones.TabStop = false;
            this.gpbAcciones.Text = "Acciones";
            // 
            // frmListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 479);
            this.Controls.Add(this.gpbAcciones);
            this.Controls.Add(this.gpbListadoCategorias);
            this.Controls.Add(this.gpbBuscas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmListadoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gpbBuscas.ResumeLayout(false);
            this.gpbBuscas.PerformLayout();
            this.gpbListadoCategorias.ResumeLayout(false);
            this.gpbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.GroupBox gpbBuscas;
        private System.Windows.Forms.GroupBox gpbListadoCategorias;
        private System.Windows.Forms.GroupBox gpbAcciones;
    }
}