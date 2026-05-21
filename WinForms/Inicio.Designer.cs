namespace WinForms
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            Listar = new Button();
            Eliminar = new Button();
            Modificar = new Button();
            Detalle = new Button();
            Buscar = new Button();
            Agregar = new Button();
            Gestion = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F);
            title.Location = new Point(372, 38);
            title.Name = "title";
            title.Size = new Size(215, 37);
            title.TabIndex = 0;
            title.Text = "Elige una opción";
            // 
            // Listar
            // 
            Listar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Listar.Cursor = Cursors.Hand;
            Listar.Location = new Point(289, 111);
            Listar.Name = "Listar";
            Listar.Padding = new Padding(10, 5, 10, 5);
            Listar.Size = new Size(374, 43);
            Listar.TabIndex = 1;
            Listar.Text = "Listar todos los artículos";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += AbrirLista;
            // 
            // Eliminar
            // 
            Eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Eliminar.Cursor = Cursors.Hand;
            Eliminar.Location = new Point(289, 308);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(374, 43);
            Eliminar.TabIndex = 4;
            Eliminar.Text = "Eliminar un artículo";
            Eliminar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            Modificar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Modificar.Cursor = Cursors.Hand;
            Modificar.Location = new Point(289, 259);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(374, 43);
            Modificar.TabIndex = 5;
            Modificar.Text = "Modificar un artículo";
            Modificar.UseVisualStyleBackColor = true;
            // 
            // Detalle
            // 
            Detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Detalle.Cursor = Cursors.Hand;
            Detalle.Location = new Point(289, 355);
            Detalle.Name = "Detalle";
            Detalle.Size = new Size(374, 43);
            Detalle.TabIndex = 6;
            Detalle.Text = "Ver detalle de un artículo";
            Detalle.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Buscar.Cursor = Cursors.Hand;
            Buscar.Location = new Point(289, 159);
            Buscar.Name = "Buscar";
            Buscar.Padding = new Padding(10, 5, 10, 5);
            Buscar.Size = new Size(374, 43);
            Buscar.TabIndex = 7;
            Buscar.Text = "Buscar un artículo";
            Buscar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            Agregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Agregar.Cursor = Cursors.Hand;
            Agregar.Location = new Point(289, 209);
            Agregar.Name = "Agregar";
            Agregar.Padding = new Padding(10, 5, 10, 5);
            Agregar.Size = new Size(374, 43);
            Agregar.TabIndex = 8;
            Agregar.Text = "Agregar un artículo";
            Agregar.UseVisualStyleBackColor = true;
            // 
            // Gestion
            // 
            Gestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Gestion.Cursor = Cursors.Hand;
            Gestion.Location = new Point(289, 404);
            Gestion.Name = "Gestion";
            Gestion.Size = new Size(374, 43);
            Gestion.TabIndex = 9;
            Gestion.Text = "Gestión de marcas y categorías";
            Gestion.UseVisualStyleBackColor = true;
            Gestion.Click += Gestion_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(978, 576);
            Controls.Add(Gestion);
            Controls.Add(Agregar);
            Controls.Add(Buscar);
            Controls.Add(Detalle);
            Controls.Add(Modificar);
            Controls.Add(Eliminar);
            Controls.Add(Listar);
            Controls.Add(title);
            Name = "Inicio";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button Listar;
        private Button Modificar;
        private Button Buscar;
        private Button Agregar;
        private Button Eliminar;
        private Button Detalle;
        private Button Gestion;
    }
}
