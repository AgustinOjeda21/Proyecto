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
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle del Artículo";
            // 
            // lblBuscarId
            // 
            lblBuscarId.AutoSize = true;
            lblBuscarId.Location = new Point(20, 62);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(101, 20);
            lblBuscarId.TabIndex = 1;
            lblBuscarId.Text = "Buscar por ID:";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(140, 59);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 27);
            txtBuscarId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(250, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 30);
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
            panelDetalle.Location = new Point(20, 105);
            panelDetalle.Name = "panelDetalle";
            panelDetalle.Size = new Size(740, 460);
            panelDetalle.TabIndex = 4;
            panelDetalle.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(5, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblValId
            // 
            lblValId.AutoSize = true;
            lblValId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValId.Location = new Point(5, 5);
            lblValId.Name = "lblValId";
            lblValId.Size = new Size(0, 20);
            lblValId.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(5, 53);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // lblValCodigo
            // 
            lblValCodigo.AutoSize = true;
            lblValCodigo.Location = new Point(5, 38);
            lblValCodigo.Name = "lblValCodigo";
            lblValCodigo.Size = new Size(0, 20);
            lblValCodigo.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(5, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblValNombre
            // 
            lblValNombre.AutoSize = true;
            lblValNombre.Location = new Point(5, 38);
            lblValNombre.Name = "lblValNombre";
            lblValNombre.Size = new Size(0, 20);
            lblValNombre.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(5, 122);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblValDescripcion
            // 
            lblValDescripcion.AutoSize = true;
            lblValDescripcion.Location = new Point(5, 38);
            lblValDescripcion.MaximumSize = new Size(300, 0);
            lblValDescripcion.Name = "lblValDescripcion";
            lblValDescripcion.Size = new Size(0, 20);
            lblValDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(5, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // lblValPrecio
            // 
            lblValPrecio.AutoSize = true;
            lblValPrecio.Location = new Point(5, 38);
            lblValPrecio.Name = "lblValPrecio";
            lblValPrecio.Size = new Size(0, 20);
            lblValPrecio.TabIndex = 9;
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(5, 189);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(72, 20);
            lblIdMarca.TabIndex = 10;
            lblIdMarca.Text = "ID Marca:";
            // 
            // lblValIdMarca
            // 
            lblValIdMarca.AutoSize = true;
            lblValIdMarca.Location = new Point(5, 38);
            lblValIdMarca.Name = "lblValIdMarca";
            lblValIdMarca.Size = new Size(0, 20);
            lblValIdMarca.TabIndex = 11;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(5, 223);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(96, 20);
            lblIdCategoria.TabIndex = 12;
            lblIdCategoria.Text = "ID Categoría:";
            // 
            // lblValIdCategoria
            // 
            lblValIdCategoria.AutoSize = true;
            lblValIdCategoria.Location = new Point(5, 38);
            lblValIdCategoria.Name = "lblValIdCategoria";
            lblValIdCategoria.Size = new Size(0, 20);
            lblValIdCategoria.TabIndex = 13;
            // 
            // imgArticulo1
            // 
            imgArticulo1.BorderStyle = BorderStyle.FixedSingle;
            imgArticulo1.Location = new Point(380, 0);
            imgArticulo1.Name = "imgArticulo1";
            imgArticulo1.Size = new Size(170, 200);
            imgArticulo1.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo1.TabIndex = 14;
            imgArticulo1.TabStop = false;
            // 
            // imgArticulo2
            // 
            imgArticulo2.BorderStyle = BorderStyle.FixedSingle;
            imgArticulo2.Location = new Point(560, 0);
            imgArticulo2.Name = "imgArticulo2";
            imgArticulo2.Size = new Size(170, 200);
            imgArticulo2.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo2.TabIndex = 15;
            imgArticulo2.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(20, 580);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 32);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // DetalleArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 630);
            Controls.Add(lblTitulo);
            Controls.Add(lblBuscarId);
            Controls.Add(txtBuscarId);
            Controls.Add(btnBuscar);
            Controls.Add(panelDetalle);
            Controls.Add(btnCerrar);
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