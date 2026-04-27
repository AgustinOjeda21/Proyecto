namespace WinForms
{
    partial class AgregarArticulo
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
            btnAgregarUrl = new Button();
            btnQuitarUrl = new Button();
            listBoxImagenes = new ListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F);
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Artículo";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(24, 65);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(71, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código *:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(185, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(280, 27);
            txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre *:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(24, 143);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 20);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción *:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(185, 140);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 181);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(63, 20);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio *:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(185, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(280, 27);
            txtPrecio.TabIndex = 8;
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(24, 219);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(61, 20);
            lblIdMarca.TabIndex = 9;
            lblIdMarca.Text = "Marca *:";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(185, 219);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(280, 28);
            cmbMarca.TabIndex = 10;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(24, 262);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(82, 20);
            lblIdCategoria.TabIndex = 11;
            lblIdCategoria.Text = "Categoría *:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(185, 257);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(280, 28);
            cmbCategoria.TabIndex = 12;
            // 
            // lblImagenes
            // 
            lblImagenes.AutoSize = true;
            lblImagenes.Location = new Point(24, 310);
            lblImagenes.Name = "lblImagenes";
            lblImagenes.Size = new Size(122, 20);
            lblImagenes.TabIndex = 13;
            lblImagenes.Text = "Imágenes (URLs):";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(185, 310);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.PlaceholderText = "https://...";
            txtUrlImagen.Size = new Size(340, 27);
            txtUrlImagen.TabIndex = 14;
            // 
            // btnAgregarUrl
            // 
            btnAgregarUrl.Location = new Point(531, 310);
            btnAgregarUrl.Name = "btnAgregarUrl";
            btnAgregarUrl.Size = new Size(100, 28);
            btnAgregarUrl.TabIndex = 15;
            btnAgregarUrl.Text = "+ Agregar";
            btnAgregarUrl.Click += btnAgregarUrl_Click;
            // 
            // btnQuitarUrl
            // 
            btnQuitarUrl.Location = new Point(531, 362);
            btnQuitarUrl.Name = "btnQuitarUrl";
            btnQuitarUrl.Size = new Size(100, 28);
            btnQuitarUrl.TabIndex = 17;
            btnQuitarUrl.Text = "- Quitar";
            btnQuitarUrl.Click += btnQuitarUrl_Click;
            // 
            // listBoxImagenes
            // 
            listBoxImagenes.HorizontalScrollbar = true;
            listBoxImagenes.Location = new Point(185, 362);
            listBoxImagenes.Name = "listBoxImagenes";
            listBoxImagenes.Size = new Size(340, 84);
            listBoxImagenes.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(375, 501);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 36);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar artículo";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(185, 501);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 660);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblIdMarca);
            Controls.Add(cmbMarca);
            Controls.Add(lblIdCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(lblImagenes);
            Controls.Add(txtUrlImagen);
            Controls.Add(btnAgregarUrl);
            Controls.Add(listBoxImagenes);
            Controls.Add(btnQuitarUrl);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "AgregarArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Artículo";
            Load += AgregarArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo, lblCodigo, lblNombre, lblDescripcion, lblPrecio, lblIdMarca, lblIdCategoria, lblImagenes;
        private TextBox txtCodigo, txtNombre, txtDescripcion, txtPrecio, txtUrlImagen;
        private ComboBox cmbMarca, cmbCategoria;
        private Button btnAgregarUrl, btnQuitarUrl, btnGuardar, btnCancelar;
        private ListBox listBoxImagenes;
    }
}
