using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AgregarArticulo : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private readonly GestorImagen gestorImagen;
        private readonly List<string> urlsImagenes = new();

        public AgregarArticulo(GestorArticulo gestorArticulo, GestorImagen gestorImagen)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
            this.gestorImagen = gestorImagen;
        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            string url = txtUrlImagen.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;
            urlsImagenes.Add(url);
            listBoxImagenes.Items.Add(url);
            txtUrlImagen.Clear();
        }

        private void btnQuitarUrl_Click(object sender, EventArgs e)
        {
            if (listBoxImagenes.SelectedIndex < 0) return;
            int idx = listBoxImagenes.SelectedIndex;
            urlsImagenes.RemoveAt(idx);
            listBoxImagenes.Items.RemoveAt(idx);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtIdMarca.Text) ||
                string.IsNullOrWhiteSpace(txtIdCategoria.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtIdMarca.Text.Trim(), out int idMarca))
            {
                MessageBox.Show("El ID de Marca debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtIdCategoria.Text.Trim(), out int idCategoria))
            {
                MessageBox.Show("El ID de Categoría debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var articulo = new Articulo(0, txtCodigo.Text.Trim(), txtNombre.Text.Trim(),
                    txtDescripcion.Text.Trim(), precio, idMarca, idCategoria);

                var (resultado, idGenerado) = await gestorArticulo.Cargar(articulo);

                switch (resultado)
                {
                    case ResultadoArticulo.NoExisteMarca:
                        MessageBox.Show("La marca indicada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case ResultadoArticulo.NoExisteCategoria:
                        MessageBox.Show("La categoría indicada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Guardar imágenes con el id del artículo recién creado (atomicidad)
                foreach (string url in urlsImagenes)
                {
                    var imagen = new Imagen(0, url, idGenerado);
                    await gestorImagen.Cargar(imagen);
                }

                MessageBox.Show("Artículo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
