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
            lblBuscarId = new Label(); txtBuscarId = new TextBox(); btnBuscar = new Button();
            panelEdicion = new Panel();
            lblCodigo = new Label(); txtCodigo = new TextBox();
            lblNombre = new Label(); txtNombre = new TextBox();
            lblDescripcion = new Label(); txtDescripcion = new TextBox();
            lblPrecio = new Label(); txtPrecio = new TextBox();
            lblIdMarca = new Label(); txtIdMarca = new TextBox();
            lblIdCategoria = new Label(); txtIdCategoria = new TextBox();
            lblImagenes = new Label();
            txtUrlImagen = new TextBox();
            btnAgregarImagen = new Button();
            btnEliminarImagen = new Button();
            listBoxImagenes = new ListBox();
            btnGuardar = new Button(); btnCancelar = new Button();
            SuspendLayout();

            // Cabecera busqueda
            lblTitulo.Text = "Modificar Artículo"; lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblTitulo.Location = new System.Drawing.Point(20, 15); lblTitulo.AutoSize = true;

            lblBuscarId.Text = "Buscar por ID:"; lblBuscarId.Location = new System.Drawing.Point(20, 60); lblBuscarId.AutoSize = true;
            txtBuscarId.Location = new System.Drawing.Point(135, 57); txtBuscarId.Size = new System.Drawing.Size(100, 27);
            btnBuscar.Text = "Buscar"; btnBuscar.Location = new System.Drawing.Point(245, 55);
            btnBuscar.Size = new System.Drawing.Size(80, 30); btnBuscar.Click += btnBuscar_Click;

            // Panel de edicion
            panelEdicion.Location = new System.Drawing.Point(0, 98);
            panelEdicion.Size = new System.Drawing.Size(620, 530);
            panelEdicion.Visible = false;

            int lx = 20, ix = 170, w = 220, gap = 40;

            lblCodigo.Text = "Código:"; lblCodigo.Location = new System.Drawing.Point(lx, 5); lblCodigo.AutoSize = true;
            txtCodigo.Location = new System.Drawing.Point(ix, 2); txtCodigo.Size = new System.Drawing.Size(w, 27);

            lblNombre.Text = "Nombre:"; lblNombre.Location = new System.Drawing.Point(lx, gap); lblNombre.AutoSize = true;
            txtNombre.Location = new System.Drawing.Point(ix, gap-3); txtNombre.Size = new System.Drawing.Size(w, 27);

            lblDescripcion.Text = "Descripción:"; lblDescripcion.Location = new System.Drawing.Point(lx, gap*2); lblDescripcion.AutoSize = true;
            txtDescripcion.Location = new System.Drawing.Point(ix, gap*2-3); txtDescripcion.Size = new System.Drawing.Size(w, 27);

            lblPrecio.Text = "Precio:"; lblPrecio.Location = new System.Drawing.Point(lx, gap*3); lblPrecio.AutoSize = true;
            txtPrecio.Location = new System.Drawing.Point(ix, gap*3-3); txtPrecio.Size = new System.Drawing.Size(w, 27);

            lblIdMarca.Text = "ID Marca:"; lblIdMarca.Location = new System.Drawing.Point(lx, gap*4); lblIdMarca.AutoSize = true;
            txtIdMarca.Location = new System.Drawing.Point(ix, gap*4-3); txtIdMarca.Size = new System.Drawing.Size(w, 27);

            lblIdCategoria.Text = "ID Categoría:"; lblIdCategoria.Location = new System.Drawing.Point(lx, gap*5); lblIdCategoria.AutoSize = true;
            txtIdCategoria.Location = new System.Drawing.Point(ix, gap*5-3); txtIdCategoria.Size = new System.Drawing.Size(w, 27);

            lblImagenes.Text = "Imágenes:"; lblImagenes.Location = new System.Drawing.Point(lx, gap*6); lblImagenes.AutoSize = true;
            txtUrlImagen.Location = new System.Drawing.Point(ix, gap*6-3); txtUrlImagen.Size = new System.Drawing.Size(250, 27);
            txtUrlImagen.PlaceholderText = "https://...";

            btnAgregarImagen.Text = "+ Agregar"; btnAgregarImagen.Location = new System.Drawing.Point(ix+258, gap*6-3);
            btnAgregarImagen.Size = new System.Drawing.Size(85, 28); btnAgregarImagen.Click += btnAgregarImagen_Click;

            listBoxImagenes.Location = new System.Drawing.Point(ix, gap*7-3);
            listBoxImagenes.Size = new System.Drawing.Size(250, 80);

            btnEliminarImagen.Text = "- Eliminar"; btnEliminarImagen.Location = new System.Drawing.Point(ix+258, gap*7-3);
            btnEliminarImagen.Size = new System.Drawing.Size(85, 28); btnEliminarImagen.Click += btnEliminarImagen_Click;

            btnGuardar.Text = "Guardar cambios"; btnGuardar.Location = new System.Drawing.Point(ix, gap*7+82);
            btnGuardar.Size = new System.Drawing.Size(140, 35); btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Text = "Cancelar"; btnCancelar.Location = new System.Drawing.Point(ix+150, gap*7+82);
            btnCancelar.Size = new System.Drawing.Size(90, 35); btnCancelar.Click += btnCancelar_Click;

            panelEdicion.Controls.AddRange(new Control[] {
                lblCodigo, txtCodigo, lblNombre, txtNombre,
                lblDescripcion, txtDescripcion, lblPrecio, txtPrecio,
                lblIdMarca, txtIdMarca, lblIdCategoria, txtIdCategoria,
                lblImagenes, txtUrlImagen, btnAgregarImagen,
                listBoxImagenes, btnEliminarImagen,
                btnGuardar, btnCancelar
            });

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(620, 640);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Artículo";
            Controls.AddRange(new Control[] { lblTitulo, lblBuscarId, txtBuscarId, btnBuscar, panelEdicion });
            ResumeLayout(false);
        }

        private Label lblTitulo, lblBuscarId, lblCodigo, lblNombre, lblDescripcion, lblPrecio, lblIdMarca, lblIdCategoria, lblImagenes;
        private TextBox txtBuscarId, txtCodigo, txtNombre, txtDescripcion, txtPrecio, txtIdMarca, txtIdCategoria, txtUrlImagen;
        private Button btnBuscar, btnAgregarImagen, btnEliminarImagen, btnGuardar, btnCancelar;
        private ListBox listBoxImagenes;
        private Panel panelEdicion;
    }
}
