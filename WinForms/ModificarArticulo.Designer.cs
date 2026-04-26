namespace WinForms
{
    partial class ModificarArticulo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblBuscarId = new Label();
            txtBuscarId = new TextBox();
            btnBuscar = new Button();
            panelEdicion = new Panel();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblIdMarca = new Label();
            cmbMarca = new ComboBox();
            lblIdCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblImagenes = new Label();
            txtUrlImagen = new TextBox();
            btnAgregarImagen = new Button();
            listBoxImagenes = new ListBox();
            btnEliminarImagen = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panelEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar Artículo";
            // 
            // lblBuscarId
            // 
            lblBuscarId.AutoSize = true;
            lblBuscarId.Location = new Point(20, 60);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(101, 20);
            lblBuscarId.TabIndex = 1;
            lblBuscarId.Text = "Buscar por ID:";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(135, 57);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 27);
            txtBuscarId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(245, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 30);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panelEdicion
            // 
            panelEdicion.Controls.Add(lblCodigo);
            panelEdicion.Controls.Add(txtCodigo);
            panelEdicion.Controls.Add(lblNombre);
            panelEdicion.Controls.Add(txtNombre);
            panelEdicion.Controls.Add(lblDescripcion);
            panelEdicion.Controls.Add(txtDescripcion);
            panelEdicion.Controls.Add(lblPrecio);
            panelEdicion.Controls.Add(txtPrecio);
            panelEdicion.Controls.Add(lblIdMarca);
            panelEdicion.Controls.Add(cmbMarca);
            panelEdicion.Controls.Add(lblIdCategoria);
            panelEdicion.Controls.Add(cmbCategoria);
            panelEdicion.Controls.Add(lblImagenes);
            panelEdicion.Controls.Add(txtUrlImagen);
            panelEdicion.Controls.Add(btnAgregarImagen);
            panelEdicion.Controls.Add(listBoxImagenes);
            panelEdicion.Controls.Add(btnEliminarImagen);
            panelEdicion.Controls.Add(btnGuardar);
            panelEdicion.Controls.Add(btnCancelar);
            panelEdicion.Location = new Point(0, 98);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(620, 530);
            panelEdicion.TabIndex = 4;
            panelEdicion.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 6);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(170, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(220, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(20, 85);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(170, 82);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(220, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 124);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(170, 120);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(220, 27);
            txtPrecio.TabIndex = 7;
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(20, 167);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(51, 20);
            lblIdMarca.TabIndex = 8;
            lblIdMarca.Text = "Marca:";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(170, 164);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(220, 28);
            cmbMarca.TabIndex = 9;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(20, 207);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(72, 20);
            lblIdCategoria.TabIndex = 10;
            lblIdCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(170, 202);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(220, 28);
            cmbCategoria.TabIndex = 11;
            // 
            // lblImagenes
            // 
            lblImagenes.AutoSize = true;
            lblImagenes.Location = new Point(20, 246);
            lblImagenes.Name = "lblImagenes";
            lblImagenes.Size = new Size(76, 20);
            lblImagenes.TabIndex = 12;
            lblImagenes.Text = "Imágenes:";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(170, 241);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.PlaceholderText = "https://...";
            txtUrlImagen.Size = new Size(250, 27);
            txtUrlImagen.TabIndex = 13;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Location = new Point(435, 242);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(85, 28);
            btnAgregarImagen.TabIndex = 14;
            btnAgregarImagen.Text = "+ Agregar";
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // listBoxImagenes
            // 
            listBoxImagenes.Location = new Point(170, 293);
            listBoxImagenes.Name = "listBoxImagenes";
            listBoxImagenes.Size = new Size(250, 64);
            listBoxImagenes.TabIndex = 15;
            // 
            // btnEliminarImagen
            // 
            btnEliminarImagen.Location = new Point(435, 293);
            btnEliminarImagen.Name = "btnEliminarImagen";
            btnEliminarImagen.Size = new Size(85, 28);
            btnEliminarImagen.TabIndex = 16;
            btnEliminarImagen.Text = "- Eliminar";
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(280, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(170, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 35);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ModificarArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 640);
            Controls.Add(lblTitulo);
            Controls.Add(lblBuscarId);
            Controls.Add(txtBuscarId);
            Controls.Add(btnBuscar);
            Controls.Add(panelEdicion);
            Name = "ModificarArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Artículo";
            Load += ModificarArticulo_Load;
            panelEdicion.ResumeLayout(false);
            panelEdicion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo, lblBuscarId, lblCodigo, lblNombre, lblDescripcion, lblPrecio, lblIdMarca, lblIdCategoria, lblImagenes;
        private TextBox txtBuscarId, txtCodigo, txtNombre, txtDescripcion, txtPrecio, txtUrlImagen;
        private ComboBox cmbMarca, cmbCategoria;
        private Button btnBuscar, btnAgregarImagen, btnEliminarImagen, btnGuardar, btnCancelar;
        private ListBox listBoxImagenes;
        private Panel panelEdicion;
    }
}

