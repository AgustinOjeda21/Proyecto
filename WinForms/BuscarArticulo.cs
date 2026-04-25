using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms
{
    public partial class BuscarArticulo : Form
    {
        private readonly GestorArticulo gestorArticulo;
        private readonly GestorImagen gestorImagen;

        public BuscarArticulo(GestorArticulo gestorArticulo, GestorImagen gestorImagen)
        {
            InitializeComponent();
            this.gestorArticulo = gestorArticulo;
            this.gestorImagen = gestorImagen;
            cmbFiltro.SelectedIndex = 0;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esEntre = cmbFiltro.SelectedIndex == 2 || cmbFiltro.SelectedIndex == 5;
            lblValor2.Visible = numValor2.Visible = esEntre;
            lblValor1.Text = esEntre ? "Desde:" : "Valor:";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int v1 = (int)numValor1.Value;
                int v2 = (int)numValor2.Value;

                List<Articulo> resultado = cmbFiltro.SelectedIndex switch
                {
                    0 => await gestorArticulo.MayorMenorA(v1, PropiedadesArticulo.Precio, Comparador.MayorA),
                    1 => await gestorArticulo.MayorMenorA(v1, PropiedadesArticulo.Precio, Comparador.MenorA),
                    2 => await gestorArticulo.Entre(v1, v2, PropiedadesArticulo.Precio, Comparador.Entre),
                    3 => await gestorArticulo.MayorMenorA(v1, PropiedadesArticulo.id, Comparador.MayorA),
                    4 => await gestorArticulo.MayorMenorA(v1, PropiedadesArticulo.id, Comparador.MenorA),
                    5 => await gestorArticulo.Entre(v1, v2, PropiedadesArticulo.id, Comparador.Entre),
                    _ => new List<Articulo>()
                };

                if (resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos con ese filtro.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var ventana = new ListaArticulos(gestorArticulo, gestorImagen, resultado);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }
}
