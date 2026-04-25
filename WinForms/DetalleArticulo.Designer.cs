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
            lblTitulo        = new Label();
            lblBuscarId      = new Label();
            txtBuscarId      = new TextBox();
            btnBuscar        = new Button();
            panelDetalle     = new Panel();
            // labels fijos
            lblId            = new Label(); lblValId            = new Label();
            lblCodigo        = new Label(); lblValCodigo        = new Label();
            lblNombre        = new Label(); lblValNombre        = new Label();
            lblDescripcion   = new Label(); lblValDescripcion   = new Label();
            lblPrecio        = new Label(); lblValPrecio        = new Label();
            lblIdMarca       = new Label(); lblValIdMarca       = new Label();
            lblIdCategoria   = new Label(); lblValIdCategoria   = new Label();
            imgArticulo1     = new PictureBox();
            imgArticulo2     = new PictureBox();
            btnCerrar        = new Button();
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).BeginInit();
            SuspendLayout();

            lblTitulo.Text = "Detalle del Artículo";
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblTitulo.Location = new System.Drawing.Point(20, 15);
            lblTitulo.AutoSize = true;

            lblBuscarId.Text = "Buscar por ID:";
            lblBuscarId.Location = new System.Drawing.Point(20, 62);
            lblBuscarId.AutoSize = true;

            txtBuscarId.Location = new System.Drawing.Point(140, 59);
            txtBuscarId.Size = new System.Drawing.Size(100, 27);

            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new System.Drawing.Point(250, 57);
            btnBuscar.Size = new System.Drawing.Size(80, 30);
            btnBuscar.Click += btnBuscar_Click;

            // panel detalle
            panelDetalle.Location = new System.Drawing.Point(20, 105);
            panelDetalle.Size = new System.Drawing.Size(740, 460);
            panelDetalle.Visible = false;

            int lx = 5, vx = 160, gap = 38;

            lblId.Text          = "ID:";          lblId.Location          = new System.Drawing.Point(lx, 5);       lblId.AutoSize = true;
            lblValId.Location   = new System.Drawing.Point(vx, 5);        lblValId.AutoSize = true;   lblValId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            lblCodigo.Text      = "Código:";      lblCodigo.Location      = new System.Drawing.Point(lx, gap);     lblCodigo.AutoSize = true;
            lblValCodigo.Location = new System.Drawing.Point(vx, gap);    lblValCodigo.AutoSize = true;

            lblNombre.Text      = "Nombre:";      lblNombre.Location      = new System.Drawing.Point(lx, gap*2);   lblNombre.AutoSize = true;
            lblValNombre.Location = new System.Drawing.Point(vx, gap*2);  lblValNombre.AutoSize = true;

            lblDescripcion.Text = "Descripción:"; lblDescripcion.Location = new System.Drawing.Point(lx, gap*3);   lblDescripcion.AutoSize = true;
            lblValDescripcion.Location = new System.Drawing.Point(vx, gap*3); lblValDescripcion.AutoSize = true; lblValDescripcion.MaximumSize = new System.Drawing.Size(300, 0);

            lblPrecio.Text      = "Precio:";      lblPrecio.Location      = new System.Drawing.Point(lx, gap*4);   lblPrecio.AutoSize = true;
            lblValPrecio.Location = new System.Drawing.Point(vx, gap*4);  lblValPrecio.AutoSize = true;

            lblIdMarca.Text     = "ID Marca:";    lblIdMarca.Location     = new System.Drawing.Point(lx, gap*5);   lblIdMarca.AutoSize = true;
            lblValIdMarca.Location = new System.Drawing.Point(vx, gap*5); lblValIdMarca.AutoSize = true;

            lblIdCategoria.Text = "ID Categoría:"; lblIdCategoria.Location = new System.Drawing.Point(lx, gap*6);  lblIdCategoria.AutoSize = true;
            lblValIdCategoria.Location = new System.Drawing.Point(vx, gap*6); lblValIdCategoria.AutoSize = true;

            imgArticulo1.Location = new System.Drawing.Point(380, 0);
            imgArticulo1.Size = new System.Drawing.Size(170, 200);
            imgArticulo1.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo1.BorderStyle = BorderStyle.FixedSingle;

            imgArticulo2.Location = new System.Drawing.Point(560, 0);
            imgArticulo2.Size = new System.Drawing.Size(170, 200);
            imgArticulo2.SizeMode = PictureBoxSizeMode.Zoom;
            imgArticulo2.BorderStyle = BorderStyle.FixedSingle;

            panelDetalle.Controls.AddRange(new Control[]
            {
                lblId, lblValId, lblCodigo, lblValCodigo, lblNombre, lblValNombre,
                lblDescripcion, lblValDescripcion, lblPrecio, lblValPrecio,
                lblIdMarca, lblValIdMarca, lblIdCategoria, lblValIdCategoria,
                imgArticulo1, imgArticulo2
            });

            btnCerrar.Text = "Cerrar";
            btnCerrar.Location = new System.Drawing.Point(20, 580);
            btnCerrar.Size = new System.Drawing.Size(90, 32);
            btnCerrar.Click += btnCerrar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 630);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Artículo";
            Controls.AddRange(new Control[] { lblTitulo, lblBuscarId, txtBuscarId, btnBuscar, panelDetalle, btnCerrar });
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).EndInit();
            ResumeLayout(false);
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