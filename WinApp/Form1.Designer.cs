namespace WinApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbMenuPrincipal = new System.Windows.Forms.GroupBox();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.gpbMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenuPrincipal
            // 
            this.gpbMenuPrincipal.Controls.Add(this.btnArticulos);
            this.gpbMenuPrincipal.Controls.Add(this.btnCategorias);
            this.gpbMenuPrincipal.Controls.Add(this.btnMarcas);
            this.gpbMenuPrincipal.Location = new System.Drawing.Point(31, 40);
            this.gpbMenuPrincipal.Name = "gpbMenuPrincipal";
            this.gpbMenuPrincipal.Size = new System.Drawing.Size(539, 130);
            this.gpbMenuPrincipal.TabIndex = 0;
            this.gpbMenuPrincipal.TabStop = false;
            this.gpbMenuPrincipal.Text = "Menu Principal";
            // 
            // btnMarcas
            // 
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.Location = new System.Drawing.Point(71, 40);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(99, 60);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Location = new System.Drawing.Point(214, 40);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(99, 60);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.Location = new System.Drawing.Point(356, 40);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(99, 60);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 207);
            this.Controls.Add(this.gpbMenuPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.gpbMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMenuPrincipal;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
    }
}

