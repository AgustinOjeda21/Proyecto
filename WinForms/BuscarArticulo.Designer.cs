namespace WinForms
{
    partial class BuscarArticulo
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
            lblFiltro = new Label();
            cmbFiltro = new ComboBox();
            lblValor1 = new Label();
            numValor1 = new NumericUpDown();
            lblValor2 = new Label();
            numValor2 = new NumericUpDown();
            btnBuscar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor2).BeginInit();
            SuspendLayout();

            lblTitulo.Text = "Buscar Artú€ulo"; lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblTitulo.Location = new System.Drawing.Point(20, 15); lblTitulo.AutoSize = true;

            lblFiltro.Text = "Filtro:"; lblFiltro.Location = new System.Drawing.Point(20, 65); lblFiltro.AutoSize = true;
            cmbFiltro.Location = new System.Drawing.Point(110, 62); cmbFiltro.Size = new System.Drawing.Size(260, 27);
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.Items.AddRange(new object[] {
                "Precio Mayor a", "Precio Menor a", "Precio Entre",
                "ID Mayor a", "ID Menor a", "ID Entre"
            });
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;

            lblValor1.Text = "Valor:"; lblValor1.Location = new System.Drawing.Point(20, 110); lblValor1.AutoSize = true;
            numValor1.Location = new System.Drawing.Point(110, 107); numValor1.Size = new System.Drawing.Size(120, 27);
            numValor1.Maximum = 9999999; numValor1.DecimalPlaces = 0;

            lblValor2.Text = "Hasta:"; lblValor2.Location = new System.Drawing.Point(250, 110); lblValor2.AutoSize = true; lblValor2.Visible = false;
            numValor2.Location = new System.Drawing.Point(300, 107); numValor2.Size = new System.Drawing.Size(120, 27);
            numValor2.Maximum = 9999999; numValor2.DecimalPlaces = 0; numValor2.Visible = false;

            btnBuscar.Text = "Buscar y ver resultados"; btnBuscar.Location = new System.Drawing.Point(110, 155);
            btnBuscar.Size = new System.Drawing.Size(180, 35); btnBuscar.Click += btnBuscar_Click;

            btnCerrar.Text = "Cerrar"; btnCerrar.Location = new System.Drawing.Point(300, 155);
            btnCerrar.Size = new System.Drawing.Size(80, 35); btnCerrar.Click += btnCerrar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 220);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Artú€ulo";
            Controls.AddRange(new Control[] { lblTitulo, lblFiltro, cmbFiltro, lblValor1, numValor1, lblValor2, numValor2, btnBuscar, btnCerrar });
            ((System.ComponentModel.ISupportInitialize)numValor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor2).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitulo, lblFiltro, lblValor1, lblValor2;
        private ComboBox cmbFiltro;
        private NumericUpDown numValor1, numValor2;
        private Button btnBuscar, btnCerrar;
    }
}
