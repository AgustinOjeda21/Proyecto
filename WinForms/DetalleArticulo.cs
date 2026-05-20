using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class DetalleArticulo : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private readonly GestorImagen gestorImagen;
        private readonly GestorMarca gestorMarca;
        private readonly GestorCategoria gestorCategoria;
        private static readonly HttpClient httpClient = new HttpClient();

        public DetalleArticulo(GestorArticulo gestorArticulo, GestorImagen gestorImagen,GestorMarca gestorMarca, GestorCategoria gestorCategoria)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
            this.gestorImagen = gestorImagen;
            this.gestorMarca = gestorMarca;
            this.gestorCategoria = gestorCategoria;
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
                var articulo = await gestorArticulo.CapturarArticulo(id);
                if (articulo is null)
                {
                    MessageBox.Show("No existe un artículo con ese ID.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panelDetalle.Visible = false;
                    return;
                }

                lblValId.Text = articulo.GetId().ToString();
                lblValCodigo.Text = articulo.GetCodigo() ?? "-";
                lblValNombre.Text = articulo.GetNombre() ?? "-";
                lblValDescripcion.Text = articulo.GetDescripcion() ?? "-";
                lblValPrecio.Text = $"{articulo.GetPrecio():N2}";
                List<Marca> ListaMar = await gestorMarca.ObtenerMarcas();
                List<Categoria> ListaCat = await gestorCategoria.ObtenerCategorias();
                var Marca = ListaMar.Find(obj=>obj.GetId()==articulo.GetIdMarca());
                var Categoria = ListaCat.Find(obj => obj.GetId() == articulo.GetIdCategoria());
                lblValIdMarca.Text = Marca.GetDescripcion() ?? "-";
                lblValIdCategoria.Text = Categoria.GetDescripcion() ?? "-";

                var imagenes = await gestorImagen.EsIgual(id);
                await CargarImagenAsync(imgArticulo1, imagenes.ElementAtOrDefault(0)?.GetimagenUrl());
                await CargarImagenAsync(imgArticulo2, imagenes.ElementAtOrDefault(1)?.GetimagenUrl());

                panelDetalle.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarImagenAsync(PictureBox box, string? url)
        {
            if (string.IsNullOrEmpty(url)) { box.Image = null; return; }
            try
            {
                box.SizeMode = PictureBoxSizeMode.Zoom;
                var req = new HttpRequestMessage(HttpMethod.Get, url);
                req.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                var res = await httpClient.SendAsync(req);
                res.EnsureSuccessStatusCode();
                var bytes = await res.Content.ReadAsByteArrayAsync();
                using var ms = new System.IO.MemoryStream(bytes);
                box.Image = Image.FromStream(ms);
            }
            catch { box.Image = null; }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        
    }
}
