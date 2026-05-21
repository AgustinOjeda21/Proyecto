namespace WinForms
{
    partial class GestionMarcasCategorias
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMarcas = new Label();
            dgvMarcas = new DataGridView();
            txtNuevaMarca = new TextBox();
            btnAgregarMarca = new Button();
            btnEliminarMarca = new Button();
            lblCategorias = new Label();
            dgvCategorias = new DataGridView();
            txtNuevaCategoria = new TextBox();
            btnAgregarCategoria = new Button();
            btnEliminarCategoria = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblMarcas
            // 
            lblMarcas.AutoSize = true;
            lblMarcas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMarcas.Location = new Point(20, 15);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(75, 25);
            lblMarcas.TabIndex = 0;
            lblMarcas.Text = "Marcas";
            // 
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.ColumnHeadersHeight = 29;
            dgvMarcas.Location = new Point(20, 45);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersWidth = 51;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(478, 344);
            dgvMarcas.TabIndex = 1;
            // 
            // txtNuevaMarca
            // 
            txtNuevaMarca.Location = new Point(20, 416);
            txtNuevaMarca.Name = "txtNuevaMarca";
            txtNuevaMarca.PlaceholderText = "Nueva descripcion de marca...";
            txtNuevaMarca.Size = new Size(280, 27);
            txtNuevaMarca.TabIndex = 2;
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(308, 414);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(90, 30);
            btnAgregarMarca.TabIndex = 3;
            btnAgregarMarca.Text = "+ Agregar";
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // btnEliminarMarca
            // 
            btnEliminarMarca.BackColor = Color.Transparent;
            btnEliminarMarca.ForeColor = Color.Black;
            btnEliminarMarca.Location = new Point(20, 454);
            btnEliminarMarca.Name = "btnEliminarMarca";
            btnEliminarMarca.Size = new Size(180, 30);
            btnEliminarMarca.TabIndex = 4;
            btnEliminarMarca.Text = "- Eliminar seleccionada";
            btnEliminarMarca.UseVisualStyleBackColor = false;
            btnEliminarMarca.Click += btnEliminarMarca_Click;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCategorias.Location = new Point(536, 15);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(106, 25);
            lblCategorias.TabIndex = 5;
            lblCategorias.Text = "Categorias";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.ColumnHeadersHeight = 29;
            dgvCategorias.Location = new Point(536, 45);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(460, 344);
            dgvCategorias.TabIndex = 6;
            // 
            // txtNuevaCategoria
            // 
            txtNuevaCategoria.Location = new Point(536, 416);
            txtNuevaCategoria.Name = "txtNuevaCategoria";
            txtNuevaCategoria.PlaceholderText = "Nueva descripcion de categoria...";
            txtNuevaCategoria.Size = new Size(310, 27);
            txtNuevaCategoria.TabIndex = 7;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(824, 414);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(120, 30);
            btnAgregarCategoria.TabIndex = 8;
            btnAgregarCategoria.Text = "+ Agregar";
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.Transparent;
            btnEliminarCategoria.ForeColor = Color.Black;
            btnEliminarCategoria.Location = new Point(536, 454);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(210, 30);
            btnEliminarCategoria.TabIndex = 9;
            btnEliminarCategoria.Text = "- Eliminar seleccionada";
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(866, 454);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 30);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // GestionMarcasCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 518);
            Controls.Add(lblMarcas);
            Controls.Add(dgvMarcas);
            Controls.Add(txtNuevaMarca);
            Controls.Add(btnAgregarMarca);
            Controls.Add(btnEliminarMarca);
            Controls.Add(lblCategorias);
            Controls.Add(dgvCategorias);
            Controls.Add(txtNuevaCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnCerrar);
            Name = "GestionMarcasCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Marcas y Categorias";
            Load += GestionMarcasCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMarcas, lblCategorias;
        private DataGridView dgvMarcas, dgvCategorias;
        private TextBox txtNuevaMarca, txtNuevaCategoria;
        private Button btnAgregarMarca, btnEliminarMarca;
        private Button btnAgregarCategoria, btnEliminarCategoria;
        private Button btnCerrar;
    }
}