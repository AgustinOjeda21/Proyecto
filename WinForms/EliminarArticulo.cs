using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class EliminarArticulo : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private Articulo? articuloActual;

        public EliminarArticulo(GestorArticulo gestorArticulo)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
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
                    panelInfo.Visible = false;
                    return;
                }
                lblInfoId.Text      = $"ID: {articuloActual.GetId()}";
                lblInfoCodigo.Text  = $"Código: {articuloActual.GetCodigo()}";
                lblInfoNombre.Text  = $"Nombre: {articuloActual.GetNombre()}";
                lblInfoPrecio.Text  = $"Precio: {articuloActual.GetPrecio():N2}";
                panelInfo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (articuloActual is null) return;

            var confirm = MessageBox.Show(
                $"¿Estás seguro que querés eliminar \"{articuloActual.GetNombre()}\"?\nSus imágenes también serán eliminadas.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                var resultado = await gestorArticulo.Eliminar(articuloActual.GetId());
                if (resultado == ResultadoArticulo.EjecuccionCorrecta)
                {
                    MessageBox.Show("Artículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarId.Clear();
                    panelInfo.Visible = false;
                    articuloActual = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }
}
