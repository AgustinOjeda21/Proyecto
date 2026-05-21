using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace WinForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Buscar.Click += AbrirBuscar;
            Agregar.Click += AbrirAgregar;
            Modificar.Click += AbrirModificar;
            Eliminar.Click += AbrirEliminar;
            Detalle.Click += AbrirDetalle;
        }

        private (GestorArticulo ga, GestorImagen gi, GestorMarca gm, GestorCategoria gc) CrearGestores()
        {
            var options = new DbContextOptionsBuilder<CatalogoP3DbContext>()
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CATALOGO_P3_DB;Trusted_Connection=True;TrustServerCertificate=True")
                .Options;
            var context = new CatalogoP3DbContext(options);

            var gestorCategoria = new GestorCategoria(new RepositorioCategoria(context, new MotorBusquedaCategoria()));
            var gestorMarca = new GestorMarca(new RepositorioMarca(context, new MotorBusquedaMarca()));

            var gestorArticulo = new GestorArticulo(
                new RepositorioArticulo(context, new MotorBusquedaArticulo()),
                gestorCategoria,
                gestorMarca
            );
            var gestorImagen = new GestorImagen(
                new RepositorioImagen(context, new MotorBusquedaImagen()),
                gestorArticulo
            );
            return (gestorArticulo, gestorImagen, gestorMarca, gestorCategoria);
        }

        private void AbrirLista(object sender, EventArgs e)
        {
            var (ga, gi, gm, gc) = CrearGestores();
            new ListaArticulos(ga, gi, gc, gm).ShowDialog();
        }

        private void AbrirBuscar(object sender, EventArgs e)
        {
            var (ga, gi, _, _) = CrearGestores();
            new BuscarArticulo(ga, gi).ShowDialog();
        }

        private void AbrirAgregar(object sender, EventArgs e)
        {
            var (ga, gi, gm, gc) = CrearGestores();
            new AgregarArticulo(ga, gi, gm, gc).ShowDialog();
        }

        private void AbrirModificar(object sender, EventArgs e)
        {
            var (ga, gi, gm, gc) = CrearGestores();
            new ModificarArticulo(ga, gi, gm, gc).ShowDialog();
        }

        private void AbrirEliminar(object sender, EventArgs e)
        {
            var (ga, _, _, _) = CrearGestores();
            new EliminarArticulo(ga).ShowDialog();
        }

        private void AbrirDetalle(object sender, EventArgs e)
        {
            var (ga, gi, gm, gc) = CrearGestores();
            new DetalleArticulo(ga, gi, gm, gc).ShowDialog();
        }

        private void Gestion_Click(object sender, EventArgs e)
        {
            var (_, _, gm, gc) = CrearGestores();
            new GestionMarcasCategorias(gm, gc).ShowDialog();
        }
    }
}

