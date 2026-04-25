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
            Buscar.Click   += AbrirBuscar;
            Agregar.Click  += AbrirAgregar;
            Modificar.Click += AbrirModificar;
            Eliminar.Click  += AbrirEliminar;
            Detalle.Click   += AbrirDetalle;
        }

        private (GestorArticulo ga, GestorImagen gi) CrearGestores()
        {
            var options = new DbContextOptionsBuilder<CatalogoP3DbContext>()
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CATALOGO_P3_DB;Trusted_Connection=True;TrustServerCertificate=True")
                .Options;
            var context = new CatalogoP3DbContext(options);
            var gestorArticulo = new GestorArticulo(
                new RepositorioArticulo(context, new MotorBusquedaArticulo()),
                new GestorCategoria(new RepositorioCategoria(context, new MotorBusquedaCategoria())),
                new GestorMarca(new RepositorioMarca(context, new MotorBusquedaMarca()))
            );
            var gestorImagen = new GestorImagen(
                new RepositorioImagen(context, new MotorBusquedaImagen()),
                gestorArticulo
            );
            return (gestorArticulo, gestorImagen);
        }

        private void AbrirLista(object sender, EventArgs e)
        {
            var (ga, gi) = CrearGestores();
            new ListaArticulos(ga, gi).ShowDialog();
        }

        private void AbrirBuscar(object sender, EventArgs e)
        {
            var (ga, gi) = CrearGestores();
            new BuscarArticulo(ga, gi).ShowDialog();
        }

        private void AbrirAgregar(object sender, EventArgs e)
        {
            var (ga, gi) = CrearGestores();
            new AgregarArticulo(ga, gi).ShowDialog();
        }

        private void AbrirModificar(object sender, EventArgs e)
        {
            var (ga, gi) = CrearGestores();
            new ModificarArticulo(ga, gi).ShowDialog();
        }

        private void AbrirEliminar(object sender, EventArgs e)
        {
            var (ga, _) = CrearGestores();
            new EliminarArticulo(ga).ShowDialog();
        }

        private void AbrirDetalle(object sender, EventArgs e)
        {
            var (ga, gi) = CrearGestores();
            new DetalleArticulo(ga, gi).ShowDialog();
        }
    }
}

