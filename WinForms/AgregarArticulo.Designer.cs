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
            lblTitulo.Location = new Point(21, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Artú€ulo";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código *:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(162, 45);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(246, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre *:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(162, 75);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(21, 107);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(71, 15);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción *:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(162, 105);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(246, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(21, 136);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(51, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio *:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(162, 136);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(246, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(21, 164);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(51, 15);
            lblIdMarca.TabIndex = 9;
            lblIdMarca.Text = "Marca *:";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(162, 164);
            cmbMarca.Margin = new Padding(3, 2, 3, 2);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(246, 23);
            cmbMarca.TabIndex = 10;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(21, 196);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(73, 15);
            lblIdCategoria.TabIndex = 11;
            lblIdCategoria.Text = "Categorú} *:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(162, 193);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(246, 23);
            cmbCategoria.TabIndex = 12;
            // 
            // lblImagenes
            // 
            lblImagenes.AutoSize = true;
            lblImagenes.Location = new Point(21, 232);
            lblImagenes.Name = "lblImagenes";
            lblImagenes.Size = new Size(98, 15);
            lblImagenes.TabIndex = 13;
            lblImagenes.Text = "Imágenes (URLs):";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(162, 232);
            txtUrlImagen.Margin = new Padding(3, 2, 3, 2);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.PlaceholderText = "https://...";
            txtUrlImagen.Size = new Size(298, 23);
            txtUrlImagen.TabIndex = 14;
            // 
            // btnAgregarUrl
            // 
            btnAgregarUrl.Location = new Point(465, 232);
            btnAgregarUrl.Margin = new Padding(3, 2, 3, 2);
            btnAgregarUrl.Name = "btnAgregarUrl";
            btnAgregarUrl.Size = new Size(88, 21);
            btnAgregarUrl.TabIndex = 15;
            btnAgregarUrl.Text = "+ Agregar";
            btnAgregarUrl.Click += btnAgregarUrl_Click;
            // 
            // btnQuitarUrl
            // 
            btnQuitarUrl.Location = new Point(465, 272);
            btnQuitarUrl.Margin = new Padding(3, 2, 3, 2);
            btnQuitarUrl.Name = "btnQuitarUrl";
            btnQuitarUrl.Size = new Size(88, 21);
            btnQuitarUrl.TabIndex = 17;
            btnQuitarUrl.Text = "- Quitar";
            btnQuitarUrl.Click += btnQuitarUrl_Click;
            // 
            // listBoxImagenes
            // 
            listBoxImagenes.HorizontalScrollbar = true;
            listBoxImagenes.ItemHeight = 15;
            listBoxImagenes.Location = new Point(162, 272);
            listBoxImagenes.Margin = new Padding(3, 2, 3, 2);
            listBoxImagenes.Name = "listBoxImagenes";
            listBoxImagenes.Size = new Size(298, 64);
            listBoxImagenes.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(328, 376);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 27);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar artú€ulo";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(162, 376);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 495);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Artú€ulo";
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
