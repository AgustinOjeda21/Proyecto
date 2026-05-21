using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class GestionMarcasCategorias : Form
    {
        private readonly GestorMarca gestorMarca;
        private readonly GestorCategoria gestorCategoria;

        public GestionMarcasCategorias(GestorMarca gestorMarca, GestorCategoria gestorCategoria)
        {
            InitializeComponent();
            this.gestorMarca = gestorMarca;
            this.gestorCategoria = gestorCategoria;
        }

        private async void GestionMarcasCategorias_Load(object sender, EventArgs e)
        {
            await RefrescarMarcas();
            await RefrescarCategorias();
        }

        private async System.Threading.Tasks.Task RefrescarMarcas()
        {
            try
            {
                var marcas = await gestorMarca.ObtenerMarcas();
                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = marcas;
                if (dgvMarcas.Columns.Contains("id")) dgvMarcas.Columns["id"].HeaderText = "ID";
                if (dgvMarcas.Columns.Contains("Descripcion")) dgvMarcas.Columns["Descripcion"].HeaderText = "Descripcion";
                dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private async void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            string desc = txtNuevaMarca.Text.Trim();
            if (string.IsNullOrEmpty(desc)) { 
                MessageBox.Show("Ingresa descripcion."); 
                return; 
            }
            try { 
                await gestorMarca.Cargar(new Marca(0, desc)); txtNuevaMarca.Clear(); await RefrescarMarcas(); 
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: " + ex.Message); 
            }
        }
        private async void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null || dgvMarcas.CurrentRow.DataBoundItem is not Marca marca) return;
            if (MessageBox.Show("Eliminar marca: " + marca.GetDescripcion(), "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { 
                await gestorMarca.Eliminar(marca.GetId()); await RefrescarMarcas(); 
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private async System.Threading.Tasks.Task RefrescarCategorias()
        {
            try
            {
                var cats = await gestorCategoria.ObtenerCategorias();
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = cats;
                if (dgvCategorias.Columns.Contains("id")) dgvCategorias.Columns["id"].HeaderText = "ID";
                if (dgvCategorias.Columns.Contains("Descripcion")) dgvCategorias.Columns["Descripcion"].HeaderText = "Descripcion";
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private async void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string desc = txtNuevaCategoria.Text.Trim();
            if (string.IsNullOrEmpty(desc)) { 
                MessageBox.Show("Ingresa descripcion."); 
                return; 
            }
            try { 
                await gestorCategoria.Cargar(new Categoria(0, desc)); txtNuevaCategoria.Clear(); await RefrescarCategorias(); 
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private async void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null || dgvCategorias.CurrentRow.DataBoundItem is not Categoria cat) return;
            if (MessageBox.Show("Eliminar categoria: " + cat.GetDescripcion(), "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { 
                await gestorCategoria.Eliminar(cat.GetId()); await RefrescarCategorias(); 
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }
}