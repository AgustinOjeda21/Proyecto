namespace WinForms
{
    partial class ListaArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            imgArticulo1 = new PictureBox();
            imgArticulo2 = new PictureBox();
            btnAgregar = new Button();
            btnCerrar = new Button();
            btnOrderBy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 548);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // imgArticulo1
            // 
            imgArticulo1.BackgroundImageLayout = ImageLayout.Stretch;
            imgArticulo1.Location = new Point(1022, -2);
            imgArticulo1.Name = "imgArticulo1";
            imgArticulo1.Size = new Size(299, 283);
            imgArticulo1.TabIndex = 1;
            imgArticulo1.TabStop = false;
            // 
            // imgArticulo2
            // 
            imgArticulo2.BackgroundImageLayout = ImageLayout.Stretch;
            imgArticulo2.Location = new Point(1022, 279);
            imgArticulo2.Name = "imgArticulo2";
            imgArticulo2.Size = new Size(299, 267);
            imgArticulo2.TabIndex = 2;
            imgArticulo2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(335, 611);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 47);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar un artículo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(755, 611);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(154, 47);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnOrderBy
            // 
            btnOrderBy.Location = new Point(512, 611);
            btnOrderBy.Name = "btnOrderBy";
            btnOrderBy.Size = new Size(209, 47);
            btnOrderBy.TabIndex = 5;
            btnOrderBy.Text = "Ordenar de mayor a menor";
            btnOrderBy.UseVisualStyleBackColor = true;
            btnOrderBy.Click += btnOrderBy_Click;
            // 
            // ListaArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 695);
            Controls.Add(btnOrderBy);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(imgArticulo2);
            Controls.Add(imgArticulo1);
            Controls.Add(dataGridView1);
            Name = "ListaArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Artículos";
            Load += ListaArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgArticulo2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox imgArticulo1;
        private PictureBox imgArticulo2;
        private Button btnAgregar;
        private Button btnCerrar;
        private Button btnOrderBy;
    }
}