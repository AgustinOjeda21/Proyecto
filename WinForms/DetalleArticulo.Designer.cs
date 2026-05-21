namespace WinForms
{
    partial class DetalleArticulo
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
            panelDetalle = new Panel();
            lblId = new Label();
            lblValId = new Label();
            lblCodigo = new Label();
            lblValCodigo = new Label();
            lblNombre = new Label();
            lblValNombre = new Label();
            lblDescripcion = new Label();
            lblValDescripcion = new Label();
            lblPrecio = new Label();
            lblValPrecio = new Label();
            lblIdMarca = new Label();
            lblValIdMarca = new Label();
            lblIdCategoria = new Label();
            lblValIdCategoria = new Label();
            imgArticulo1 = new PictureBox();
            imgArticulo2 = new PictureBox();
            btnCerrar = new Button();
            panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F);
            lblTitulo.Location = new Point(18, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle del Artículo";
            // 
            // lblBuscarId
            // 
            lblBuscarId.AutoSize = true;
            lblBuscarId.Location = new Point(18, 46);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(80, 15);
            lblBuscarId.TabIndex = 1;
            lblBuscarId.Text = "Buscar por ID:";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(122, 44);
            txtBuscarId.Margin = new Padding(3, 2, 3, 2);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(88, 23);
            txtBuscarId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(219, 43);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 22);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panelDetalle
            // 
            panelDetalle.Controls.Add(lblId);
            panelDetalle.Controls.Add(lblValId);
            panelDetalle.Controls.Add(lblCodigo);
            panelDetalle.Controls.Add(lblValCodigo);
            panelDetalle.Controls.Add(lblNombre);
            panelDetalle.Controls.Add(lblValNombre);
            panelDetalle.Controls.Add(lblDescripcion);
            panelDetalle.Controls.Add(lblValDescripcion);
            panelDetalle.Controls.Add(lblPrecio);
            panelDetalle.Controls.Add(lblValPrecio);
            panelDetalle.Controls.Add(lblIdMarca);
            panelDetalle.Controls.Add(lblValIdMarca);
            panelDetalle.Controls.Add(lblIdCategoria);
            panelDetalle.Controls.Add(lblValIdCategoria);
            panelDetalle.Controls.Add(imgArticulo1);
            panelDetalle.Controls.Add(imgArticulo2);
            panelDetalle.Location = new Point(18, 79);
            panelDetalle.Margin = new Padding(3, 2, 3, 2);
            panelDetalle.Name = "panelDetalle";
            panelDetalle.Size = new Size(648, 345);
            panelDetalle.TabIndex = 4;
            panelDetalle.Visible = false;
            
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(4, 14);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblValId
            // 
            lblValId.AutoSize = true;
            lblValId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValId.Location = new Point(85, 14);
            lblValId.Name = "lblValId";
            lblValId.Size = new Size(0, 15);
            lblValId.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(4, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // lblValCodigo
            // 
            lblValCodigo.AutoSize = true;
            lblValCodigo.Location = new Point(85, 40);
            lblValCodigo.Name = "lblValCodigo";
            lblValCodigo.Size = new Size(0, 15);
            lblValCodigo.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(4, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblValNombre
            // 
            lblValNombre.AutoSize = true;
            lblValNombre.Location = new Point(85, 65);
            lblValNombre.Name = "lblValNombre";
            lblValNombre.Size = new Size(0, 15);
            lblValNombre.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(4, 92);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblValDescripcion
            // 
            lblValDescripcion.AutoSize = true;
            lblValDescripcion.Location = new Point(85, 92);
            lblValDescripcion.MaximumSize = new Size(262, 0);
            lblValDescripcion.Name = "lblValDescripcion";
            lblValDescripcion.Size = new Size(0, 15);
            lblValDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(4, 116);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // lblValPrecio
            // 
            lblValPrecio.AutoSize = true;
            lblValPrecio.Location = new Point(85, 116);
            lblValPrecio.Name = "lblValPrecio";
            lblValPrecio.Size = new Size(0, 15);
            lblValPrecio.TabIndex = 9;
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(4, 142);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(57, 15);
            lblIdMarca.TabIndex = 10;
            lblIdMarca.Text = "ID Marca:";
            // 
            // lblValIdMarca
            // 
            lblValIdMarca.AutoSize = true;
            lblValIdMarca.Location = new Point(85, 142);
            lblValIdMarca.Name = "lblValIdMarca";
            lblValIdMarca.Size = new Size(0, 15);
            lblValIdMarca.TabIndex = 11;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(4, 167);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(75, 15);
            lblIdCategoria.TabIndex = 12;
            lblIdCategoria.Text = "ID Categoría:";
            // 
            // lblValIdCategoria
            // 
            lblValIdCategoria.AutoSize = true;
            lblValIdCategoria.Location = new Point(85, 167);
            lblValIdCategoria.Name = "lblValIdCategoria";
            lblValIdCategoria.Size = new Size(0, 15);
            lblValIdCategoria.TabIndex = 13;
            // 
            // imgArticulo1
            // 
            imgArticulo1.BorderStyle = BorderStyle.FixedSingle;
            imgArticulo1.Location = new Point(332, 0);
            imgArticulo1.Margin = new Padding(3, 2, 3, 2);
            imgArticulo1.Name = "imgArticulo1";
            imgArticulo1.Size = new Size(149, 150);
            imgArticulo1.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo1.TabIndex = 14;
            imgArticulo1.TabStop = false;
            // 
            // imgArticulo2
            // 
            imgArticulo2.BorderStyle = BorderStyle.FixedSingle;
            imgArticulo2.Location = new Point(490, 0);
            imgArticulo2.Margin = new Padding(3, 2, 3, 2);
            imgArticulo2.Name = "imgArticulo2";
            imgArticulo2.Size = new Size(149, 150);
            imgArticulo2.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo2.TabIndex = 15;
            imgArticulo2.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(18, 435);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(79, 24);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // DetalleArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 472);
            Controls.Add(lblTitulo);
            Controls.Add(lblBuscarId);
            Controls.Add(txtBuscarId);
            Controls.Add(btnBuscar);
            Controls.Add(panelDetalle);
            Controls.Add(btnCerrar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetalleArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Artículo";
            panelDetalle.ResumeLayout(false);
            panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo, lblBuscarId;
        private Label lblId, lblValId, lblCodigo, lblValCodigo, lblNombre, lblValNombre;
        private Label lblDescripcion, lblValDescripcion, lblPrecio, lblValPrecio;
        private Label lblIdMarca, lblValIdMarca, lblIdCategoria, lblValIdCategoria;
        private TextBox txtBuscarId;
        private Button btnBuscar, btnCerrar;
        private PictureBox imgArticulo1, imgArticulo2;
        private Panel panelDetalle;
    }
}