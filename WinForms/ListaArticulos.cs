using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ListaArticulos : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private readonly GestorImagen gestorImagen;
        private readonly GestorMarca gestorMarca;
        private readonly GestorCategoria gestorCategoria;
        private List<Articulo> listaActual = new();
        private static readonly HttpClient httpClient = new HttpClient();

        public ListaArticulos(GestorArticulo gestorArticulo, GestorImagen gestorImagen,GestorCategoria gestorCategoria,GestorMarca gestorMarca)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
            this.gestorImagen = gestorImagen;
            var context = new CatalogoP3DbContext();
            this.gestorMarca = gestorMarca;
            this.gestorCategoria = gestorCategoria;
        }

        private async void ListaArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                listaActual = await gestorArticulo.ObtenerArticulos();
                MostrarEnGrilla(listaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar artú€ulos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnGrilla(List<Articulo> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;

            if (dataGridView1.Columns.Contains("Precio"))
                dataGridView1.Columns["Precio"]!.DefaultCellStyle.Format = "N2";

            if (lista.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                _ = CargarImagenesDeArticulo(lista[0]);
            }
            else
            {
                imgArticulo1.Image = null;
                imgArticulo2.Image = null;
            }
        }

        private async void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Articulo articulo)
                return;
            await CargarImagenesDeArticulo(articulo);
        }

        private async Task CargarImagenesDeArticulo(Articulo articulo)
        {
            try
            {
                var imagenes = await gestorImagen.EsIgual(articulo.id);
                await CargarImagenAsync(imgArticulo1, imagenes.ElementAtOrDefault(0)?.GetimagenUrl());
                await CargarImagenAsync(imgArticulo2, imagenes.ElementAtOrDefault(1)?.GetimagenUrl());
            }
            catch { }
        }

        private async Task CargarImagenAsync(PictureBox box, string? url)
        {
            if (string.IsNullOrEmpty(url))
            {
                box.Image = null;
                return;
            }
            try
            {
                box.SizeMode = PictureBoxSizeMode.Zoom;
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                var response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var bytes = await response.Content.ReadAsByteArrayAsync();
                using var ms = new System.IO.MemoryStream(bytes);
                box.Image = Image.FromStream(ms);
            }
            catch
            {
                box.Image = null;
            }
        }

        private async void btnOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                listaActual = await gestorArticulo.LosMayoresMenores(PropiedadesArticulo.id, Ordenador.Descendente);
                MostrarEnGrilla(listaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new AgregarArticulo(gestorArticulo, gestorImagen, gestorMarca, gestorCategoria);
            form.ShowDialog();
            _ = RecargarListaAsync();
        }

        private async Task RecargarListaAsync()
        {
             listaActual = await gestorArticulo.ObtenerArticulos();
             MostrarEnGrilla(listaActual);
        }
    }
}
