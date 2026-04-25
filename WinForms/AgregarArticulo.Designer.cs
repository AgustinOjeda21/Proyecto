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
            lblCodigo = new Label(); txtCodigo = new TextBox();
            lblNombre = new Label(); txtNombre = new TextBox();
            lblDescripcion = new Label(); txtDescripcion = new TextBox();
            lblPrecio = new Label(); txtPrecio = new TextBox();
            lblIdMarca = new Label(); txtIdMarca = new TextBox();
            lblIdCategoria = new Label(); txtIdCategoria = new TextBox();
            lblImagenes = new Label();
            txtUrlImagen = new TextBox();
            btnAgregarUrl = new Button();
            btnQuitarUrl = new Button();
            listBoxImagenes = new ListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            int lx = 24, ix = 185, w = 280, gap = 46, y = 65;

            lblTitulo.Text = "Agregar Artículo"; lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblTitulo.Location = new System.Drawing.Point(lx, 15); lblTitulo.AutoSize = true;

            lblCodigo.Text = "Código *:"; lblCodigo.Location = new System.Drawing.Point(lx, y); lblCodigo.AutoSize = true;
            txtCodigo.Location = new System.Drawing.Point(ix, y - 2); txtCodigo.Size = new System.Drawing.Size(w, 27);

            lblNombre.Text = "Nombre *:"; lblNombre.Location = new System.Drawing.Point(lx, y + gap); lblNombre.AutoSize = true;
            txtNombre.Location = new System.Drawing.Point(ix, y + gap - 2); txtNombre.Size = new System.Drawing.Size(w, 27);

            lblDescripcion.Text = "Descripción *:"; lblDescripcion.Location = new System.Drawing.Point(lx, y + gap*2); lblDescripcion.AutoSize = true;
            txtDescripcion.Location = new System.Drawing.Point(ix, y + gap*2 - 2); txtDescripcion.Size = new System.Drawing.Size(w, 27);

            lblPrecio.Text = "Precio *:"; lblPrecio.Location = new System.Drawing.Point(lx, y + gap*3); lblPrecio.AutoSize = true;
            txtPrecio.Location = new System.Drawing.Point(ix, y + gap*3 - 2); txtPrecio.Size = new System.Drawing.Size(w, 27);

            lblIdMarca.Text = "ID Marca *:"; lblIdMarca.Location = new System.Drawing.Point(lx, y + gap*4); lblIdMarca.AutoSize = true;
            txtIdMarca.Location = new System.Drawing.Point(ix, y + gap*4 - 2); txtIdMarca.Size = new System.Drawing.Size(w, 27);

            lblIdCategoria.Text = "ID Categoría *:"; lblIdCategoria.Location = new System.Drawing.Point(lx, y + gap*5); lblIdCategoria.AutoSize = true;
            txtIdCategoria.Location = new System.Drawing.Point(ix, y + gap*5 - 2); txtIdCategoria.Size = new System.Drawing.Size(w, 27);

            lblImagenes.Text = "Imágenes (URLs):"; lblImagenes.Location = new System.Drawing.Point(lx, y + gap*6); lblImagenes.AutoSize = true;
            txtUrlImagen.Location = new System.Drawing.Point(ix, y + gap*6 - 2); txtUrlImagen.Size = new System.Drawing.Size(340, 27);
            txtUrlImagen.PlaceholderText = "https://...";

            btnAgregarUrl.Text = "+ Agregar"; btnAgregarUrl.Location = new System.Drawing.Point(ix + 348, y + gap*6 - 2);
            btnAgregarUrl.Size = new System.Drawing.Size(100, 28); btnAgregarUrl.Click += btnAgregarUrl_Click;

            listBoxImagenes.Location = new System.Drawing.Point(ix, y + gap*7 - 2);
            listBoxImagenes.Size = new System.Drawing.Size(340, 100);
            listBoxImagenes.HorizontalScrollbar = true;

            btnQuitarUrl.Text = "- Quitar"; btnQuitarUrl.Location = new System.Drawing.Point(ix + 348, y + gap*7 - 2);
            btnQuitarUrl.Size = new System.Drawing.Size(100, 28); btnQuitarUrl.Click += btnQuitarUrl_Click;

            btnGuardar.Text = "Guardar artículo"; btnGuardar.Location = new System.Drawing.Point(ix, y + gap*7 + 115);
            btnGuardar.Size = new System.Drawing.Size(150, 36); btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Text = "Cancelar"; btnCancelar.Location = new System.Drawing.Point(ix + 160, y + gap*7 + 115);
            btnCancelar.Size = new System.Drawing.Size(100, 36); btnCancelar.Click += btnCancelar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 660);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Artículo";
            Controls.AddRange(new Control[] {
                lblTitulo, lblCodigo, txtCodigo, lblNombre, txtNombre,
                lblDescripcion, txtDescripcion, lblPrecio, txtPrecio,
                lblIdMarca, txtIdMarca, lblIdCategoria, txtIdCategoria,
                lblImagenes, txtUrlImagen, btnAgregarUrl, listBoxImagenes,
                btnQuitarUrl, btnGuardar, btnCancelar
            });
            ResumeLayout(false);
        }

        private Label lblTitulo, lblCodigo, lblNombre, lblDescripcion, lblPrecio, lblIdMarca, lblIdCategoria, lblImagenes;
        private TextBox txtCodigo, txtNombre, txtDescripcion, txtPrecio, txtIdMarca, txtIdCategoria, txtUrlImagen;
        private Button btnAgregarUrl, btnQuitarUrl, btnGuardar, btnCancelar;
        private ListBox listBoxImagenes;
    }
}
