using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ModificarArticulo : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private readonly GestorImagen gestorImagen;
        private Articulo? articuloActual;
        private List<Imagen> imagenesActuales = new();

        public ModificarArticulo(GestorArticulo gestorArticulo, GestorImagen gestorImagen)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
            this.gestorImagen = gestorImagen;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarId.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingresá un ID válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                articuloActual = await gestorArticulo.CapturarArticulo(id);
                if (articuloActual is null)
                {
                    MessageBox.Show("No existe un artículo con ese ID.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panelEdicion.Visible = false;
                    return;
                }

                txtCodigo.Text = articuloActual.GetCodigo() ?? "";
                txtNombre.Text = articuloActual.GetNombre() ?? "";
                txtDescripcion.Text = articuloActual.GetDescripcion() ?? "";
                txtPrecio.Text = articuloActual.GetPrecio()?.ToString() ?? "";
                txtIdMarca.Text = articuloActual.GetIdMarca()?.ToString() ?? "";
                txtIdCategoria.Text = articuloActual.GetIdCategoria()?.ToString() ?? "";

                imagenesActuales = await gestorImagen.EsIgual(id);
                RefrescarListaImagenes();

                panelEdicion.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListaImagenes()
        {
            listBoxImagenes.Items.Clear();
            foreach (var img in imagenesActuales)
                listBoxImagenes.Items.Add($"[{img.GetId()}] {img.GetimagenUrl()}");
        }

        private async void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (articuloActual is null) return;
            string url = txtUrlImagen.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;
            try
            {
                var imagen = new Imagen(0, url, articuloActual.GetId());
                var res = await gestorImagen.Cargar(imagen);
                if (res == ResultadoImagen.EjecuccionCorrecta)
                {
                    imagenesActuales = await gestorImagen.EsIgual(articuloActual.GetId());
                    RefrescarListaImagenes();
                    txtUrlImagen.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (listBoxImagenes.SelectedIndex < 0) return;
            var imagen = imagenesActuales[listBoxImagenes.SelectedIndex];
            try
            {
                await gestorImagen.Eliminar(imagen.GetId());
                imagenesActuales = await gestorImagen.EsIgual(articuloActual!.GetId());
                RefrescarListaImagenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (articuloActual is null) return;
            int id = articuloActual.GetId();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtIdMarca.Text) || string.IsNullOrWhiteSpace(txtIdCategoria.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio) ||
                !int.TryParse(txtIdMarca.Text.Trim(), out int idMarca) ||
                !int.TryParse(txtIdCategoria.Text.Trim(), out int idCategoria))
            {
                MessageBox.Show("Precio, ID Marca e ID Categoría deben ser numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resCodigo = await gestorArticulo.ModificarCodigo(id, txtCodigo.Text.Trim());
                var resNombre = await gestorArticulo.ModificarNombre(id, txtNombre.Text.Trim());
                var resDesc = await gestorArticulo.ModificarDescripcion(id, txtDescripcion.Text.Trim());
                var resPrecio = await gestorArticulo.ModificarPrecio(id, precio);
                var resMarca = await gestorArticulo.ModificarMarca(id, idMarca);
                var resCat = await gestorArticulo.ModificarCategoria(id, idCategoria);

                if (resMarca == ResultadoArticulo.NoExisteMarca)
                {
                    MessageBox.Show("La marca indicada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (resCat == ResultadoArticulo.NoExisteCategoria)
                {
                    MessageBox.Show("La categoría indicada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Artículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelEdicion.Visible = false;
                txtBuscarId.Clear();
                articuloActual = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
    }
}
