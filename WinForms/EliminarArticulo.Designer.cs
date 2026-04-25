namespace WinForms
{
    partial class EliminarArticulo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo    = new Label();
            lblBuscarId  = new Label();
            txtBuscarId  = new TextBox();
            btnBuscar    = new Button();
            panelInfo    = new Panel();
            lblInfoId     = new Label();
            lblInfoCodigo = new Label();
            lblInfoNombre = new Label();
            lblInfoPrecio = new Label();
            btnEliminar  = new Button();
            btnCerrar    = new Button();
            SuspendLayout();

            lblTitulo.Text = "Eliminar Artículo";
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

            // panel info
            panelInfo.Location = new System.Drawing.Point(20, 105);
            panelInfo.Size = new System.Drawing.Size(420, 185);
            panelInfo.Visible = false;
            panelInfo.BorderStyle = BorderStyle.FixedSingle;

            lblInfoId.Text     = "ID:";      lblInfoId.Location     = new System.Drawing.Point(10, 12); lblInfoId.AutoSize = true;
            lblInfoCodigo.Text = "Código:";  lblInfoCodigo.Location = new System.Drawing.Point(10, 42); lblInfoCodigo.AutoSize = true;
            lblInfoNombre.Text = "Nombre:";  lblInfoNombre.Location = new System.Drawing.Point(10, 72); lblInfoNombre.AutoSize = true;
            lblInfoPrecio.Text = "Precio:";  lblInfoPrecio.Location = new System.Drawing.Point(10, 102); lblInfoPrecio.AutoSize = true;

            btnEliminar.Text = "Eliminar artículo";
            btnEliminar.Location = new System.Drawing.Point(10, 138);
            btnEliminar.Size = new System.Drawing.Size(150, 35);
            btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Click += btnEliminar_Click;

            panelInfo.Controls.AddRange(new Control[] { lblInfoId, lblInfoCodigo, lblInfoNombre, lblInfoPrecio, btnEliminar });

            btnCerrar.Text = "Cerrar";
            btnCerrar.Location = new System.Drawing.Point(20, 310);
            btnCerrar.Size = new System.Drawing.Size(90, 32);
            btnCerrar.Click += btnCerrar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 360);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Artículo";
            Controls.AddRange(new Control[] { lblTitulo, lblBuscarId, txtBuscarId, btnBuscar, panelInfo, btnCerrar });
            ResumeLayout(false);
        }

        private Label lblTitulo, lblBuscarId, lblInfoId, lblInfoCodigo, lblInfoNombre, lblInfoPrecio;
        private TextBox txtBuscarId;
        private Button btnBuscar, btnEliminar, btnCerrar;
        private Panel panelInfo;
    }
}