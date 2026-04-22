using Microsoft.EntityFrameworkCore;


// ─── CONFIGURACIÓN ────────────────────────────────────────────────────────────

var options = new DbContextOptionsBuilder<CatalogoP3DbContext>()
    .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CATALOGO_P3_DB;Trusted_Connection=True;TrustServerCertificate=True")
    .Options;
    //esta es la conexion a la base de datos muy importante para que el programa funcion


var context        = new CatalogoP3DbContext(options);
var motorart       = new MotorBusquedaArticulo();
var motormar       = new MotorBusquedaMarca();
var motorcat       = new MotorBusquedaCategoria();
var motorima       = new MotorBusquedaImagen();
var repoArticulo   = new RepositorioArticulo(context,motorart);
var repoCategoria  = new RepositorioCategoria(context,motorcat);
var repoMarca      = new RepositorioMarca(context,motormar);
var repoImagen     = new RepositorioImagen(context,motorima);

var gesCategoria   = new GestorCategoria(repoCategoria);
var gesMarca       = new GestorMarca(repoMarca);
var gesArticulo    = new GestorArticulo(repoArticulo, gesCategoria, gesMarca);
var gesImagen      = new GestorImagen(repoImagen, gesArticulo);
// todo esto tiene que declararse en main para que funcione

// ─── HELPERS ──────────────────────────────────────────────────────────────────

void Titulo(string texto)
{
    Console.WriteLine();
    Console.WriteLine(new string('─', 50));
    Console.WriteLine($"  {texto}");
    Console.WriteLine(new string('─', 50));
}

void Pausa()
{
    Console.WriteLine("\nPresioná ENTER para continuar...");
    Console.ReadLine();
}

// ─── CATEGORÍAS ───────────────────────────────────────────────────────────────

Titulo("CATEGORÍAS - Listar");
List<Categoria> categorias = await gesCategoria.ObtenerCategorias(); // necesita si o si ir el away antes del metodo
if (categorias.Count()>0)
    categorias.ForEach(c => Console.WriteLine($"  [{c.GetId()}] {c.GetDescripcion()}"));// esto lo unico que hace es recorrer la lista y mostrarla
else
    Console.WriteLine("  No hay categorías cargadas.");
Pausa();

Titulo("CATEGORÍAS - Agregar");
await gesCategoria.Cargar(new Categoria(0, "Indumentaria"));// lo ideal seria validar los datos antes de guardarlo, el id podes ingresar el que quieras por que es autoincremental se setea solo
await gesCategoria.Cargar(new Categoria(0, "Calzado"));
Console.WriteLine("  Se agregaron: Indumentaria, Calzado");
Pausa();

Titulo("CATEGORÍAS - Buscar por descripción que contenga 'ind'");
List<Categoria> catsFiltradas = await gesCategoria.BuscarStringCon("ind",BuscarString.Contiene);// Primero ingresas la cadena que queres buscar y luego ingresas el enum Buscarstring que tiene: empiezacon, Termincacon, Contiene
catsFiltradas.ForEach(c => Console.WriteLine($"  [{c.GetId()}] {c.GetDescripcion()}"));
Pausa();

Titulo("CATEGORÍAS - Modificar descripción");
categorias = await gesCategoria.ObtenerCategorias();
if (categorias.Count()>0)
{
    Categoria primera = categorias.First();// obtiene la primera categoria de la lista
    ResultadoCategoria res = await gesCategoria.ModificarDescripcion(primera.GetId(), "Indumentaria Deportiva");// para er modificar ingresas primero el id del objeto que vas a modificar y despues el valor que ingresaste
    Console.WriteLine($"  Resultado: {res}");// los modificar devuelven resultados en forma de enum que indica el resultado de la operacion ya sea que no existe el objeto que queres modificar o si se ejecuto correctamente
}
Pausa();

// ─── MARCAS ───────────────────────────────────────────────────────────────────

Titulo("MARCAS - Listar");
var marcas = await gesMarca.ObtenerMarcas();
if (marcas.Count()>0)
    marcas.ForEach(m => Console.WriteLine($"  [{m.GetId()}] {m.GetDescripcion()}"));
else
    Console.WriteLine("  No hay marcas cargadas.");
Pausa();

Titulo("MARCAS - Agregar");
await gesMarca.Cargar(new Marca(0, "Nike"));
await gesMarca.Cargar(new Marca(0, "Adidas"));
await gesMarca.Cargar(new Marca(0, "Puma"));
Console.WriteLine("  Se agregaron: Nike, Adidas, Puma");
Pausa();

Titulo("MARCAS - Buscar por descripción que empiece con 'A'");
var marcasFiltradas = await gesMarca.BuscarStringCon("A",BuscarString.EmpiezaCon);
marcasFiltradas.ForEach(m => Console.WriteLine($"  [{m.GetId()}] {m.GetDescripcion()}"));
Pausa();

Titulo("MARCAS - Ordenar por descripción descendente");
var marcasOrdenadas = await gesMarca.LosMayoresMenores(PropiedadesMarca.Descripcion,Ordenador.Descendente);
marcasOrdenadas.ForEach(m => Console.WriteLine($"  {m.GetDescripcion()}"));
Pausa();

// ─── ARTÍCULOS ────────────────────────────────────────────────────────────────

Titulo("ARTÍCULOS - Listar");
List<Articulo> articulos = await gesArticulo.ObtenerArticulos();
if (articulos.Count()>0)
    articulos.ForEach(a => Console.WriteLine($"  [{a.id}] {a.Nombre} | ${a.Precio} | Marca: {a.idMarca} | Cat: {a.idCategoria}"));
else
    Console.WriteLine("  No hay artículos cargados.");
Pausa(); // el mismo comportamiento que el anterior todos funcionan igual

Titulo("ARTÍCULOS - Agregar");
marcas = await gesMarca.ObtenerMarcas();
categorias = await gesCategoria.ObtenerCategorias();
int? idMarca = marcas.FirstOrDefault()?.GetId();//busca la primera marca de la lista y guarda su id para despues agregarselo al articulo que vas a guardar
int? idCat   = categorias.FirstOrDefault()?.GetId();// lo mismo de arriba

var r1 = await gesArticulo.Cargar(new Articulo(0, "COD001", "Remera Básica",    "Remera de algodón azul",  1500m,  idMarca, idCat));// lo mismo que con marca lo ideal es que valides los datos que se ingresan
var r2 = await gesArticulo.Cargar(new Articulo(0, "COD002", "Zapatilla Running", "Zapatilla liviana",       8500m,  idMarca, idCat));
var r3 = await gesArticulo.Cargar(new Articulo(0, "COD003", "Buzo Canguro",      "Buzo con bolsillo",       4200m,  idMarca, idCat));
var r4 = await gesArticulo.Cargar(new Articulo(0, "COD004", "Short Deportivo",   "Short con bolsillos",     2300m,  idMarca, idCat));
// Intentar cargar con marca inexistente (debe fallar)
var r5 = await gesArticulo.Cargar(new Articulo(0, "COD005", "Articulo Fallido",  "No deberia cargarse",     999m,   99999,   idCat));
Console.WriteLine($"  Remera Básica:    {r1}");
Console.WriteLine($"  Zapatilla:        {r2}");
Console.WriteLine($"  Buzo:             {r3}");
Console.WriteLine($"  Short:            {r4}");
Console.WriteLine($"  Marca inexistente:{r5}  ← debería ser NoExisteMarca");
Pausa();

Titulo("ARTÍCULOS - Ver detalle de uno");
articulos = await gesArticulo.ObtenerArticulos();
if (articulos.Count()>0)
{
    Articulo detalle = await gesArticulo.CapturarArticulo(articulos.First().id);// obtiene el primer articulo de la lista
    Console.WriteLine($"  Id:          {detalle?.id}");
    Console.WriteLine($"  Código:      {detalle?.Codigo}");
    Console.WriteLine($"  Nombre:      {detalle?.Nombre}");
    Console.WriteLine($"  Descripción: {detalle?.Descripcion}");
    Console.WriteLine($"  Precio:      ${detalle?.Precio}");
    Console.WriteLine($"  IdMarca:     {detalle?.idMarca}");
    Console.WriteLine($"  IdCategoria: {detalle?.idCategoria}");// el signo de interrogacion sirve para preguntar si el objeto es nulo si no es nulo llama a la propiedad si no no ya que se romperia el programa 
}
Pausa();

Titulo("ARTÍCULOS - Buscar por nombre que contenga 'rem'");
List<Articulo> porNombre = await gesArticulo.BuscarStringCon("rem",PropiedadesArticulo.Nombre,BuscarString.Contiene);// mismo comportamiento que el de marca
porNombre.ForEach(a => Console.WriteLine($"  {a.Nombre}"));
Pausa();

Titulo("ARTÍCULOS - Precio mayor a $2000");
List<Articulo> caros = await gesArticulo.MayorMenorA(2000,PropiedadesArticulo.Precio,Comparador.MayorA);// aca primero pasas el valor que ingresaste, luego la propiedad que queres modificar y por ultimo el comparador que tiene mayorA y menorA para MayorMenorA y entre y MenorMayorA para entre
caros.ForEach(a => Console.WriteLine($"  {a.Nombre} | ${a.Precio}"));
Pausa();

Titulo("ARTÍCULOS - Precio menor a $3000");
List<Articulo> baratos = await gesArticulo.MayorMenorA(3000,PropiedadesArticulo.Precio,Comparador.MenorA);//mismo funcionamiento que arriba
baratos.ForEach(a => Console.WriteLine($"  {a.Nombre} | ${a.Precio}"));
Pausa();

Titulo("ARTÍCULOS - Precio entre $2000 y $5000");
List<Articulo> rango = await gesArticulo.Entre(2000,5000,PropiedadesArticulo.Precio,Comparador.Entre);//busca los objetos con el precio entre esos valores primero ingresas el minimo y despues el maximo
rango.ForEach(a => Console.WriteLine($"  {a.Nombre} | ${a.Precio}"));
Pausa();

Titulo("ARTÍCULOS - Precio fuera de $2000 y $5000 (MenorMayor)");
List<Articulo> fuera = await gesArticulo.Entre(2000,5000,PropiedadesArticulo.Precio,Comparador.MayorMenorA);//busca los valores menores al minimo y mayores al maximo
fuera.ForEach(a => Console.WriteLine($"  {a.Nombre} | ${a.Precio}"));
Pausa();

Titulo("ARTÍCULOS - Ordenar por precio ascendente");
List<Articulo> porPrecioAsc = await gesArticulo.LosMayoresMenores(PropiedadesArticulo.Precio,Ordenador.Ascendente);// ordena los registros segun la propiedad que eligas con el enum ordenador eliges si es ascendente o descendente
porPrecioAsc.ForEach(a => Console.WriteLine($"  {a.Nombre} | ${a.Precio}"));
Pausa();

Titulo("ARTÍCULOS - Ordenar por nombre descendente");
List<Articulo> porNombreDesc = await gesArticulo.LosMayoresMenores(PropiedadesArticulo.Precio,Ordenador.Descendente);
porNombreDesc.ForEach(a => Console.WriteLine($"  {a.Nombre}"));
Pausa();

Titulo("ARTÍCULOS - Modificar nombre"); // mismo concepto de modifcar que en marca
if (articulos.Count()>0)
{
    var id = articulos.First().id;
    var res = await gesArticulo.ModificarNombre(id, "Remera Básica Modificada");
    Console.WriteLine($"  Resultado: {res}");
    var verificacion = await gesArticulo.CapturarArticulo(id);
    Console.WriteLine($"  Nombre actualizado: {verificacion?.Nombre}");
}
Pausa();

Titulo("ARTÍCULOS - Modificar precio");
if (articulos.Count()>0)
{
    var id = articulos.First().id;
    var res = await gesArticulo.ModificarPrecio(id, 1750m);
    Console.WriteLine($"  Resultado: {res}");
    var verificacion = await gesArticulo.CapturarArticulo(id);
    Console.WriteLine($"  Precio actualizado: ${verificacion?.Precio}");
}
Pausa();

Titulo("ARTÍCULOS - Modificar con ID inexistente (debe fallar)");
var resFail = await gesArticulo.ModificarNombre(99999, "No existe");
Console.WriteLine($"  Resultado: {resFail}  ← debería ser NoExiste");
Pausa();
/*
// ─── IMÁGENES ─────────────────────────────────────────────────────────────────

Titulo("IMÁGENES - Agregar a un artículo");
articulos = await gesArticulo.ObtenerArticulos();
if (articulos.Count()>0)
{
    int idArt = articulos.First().id;
    var ri1 = await gesImagen.Cargar(new Imagen(0, "https://ejemplo.com/img1.jpg", idArt));
    var ri2 = await gesImagen.Cargar(new Imagen(0, "https://ejemplo.com/img2.jpg", idArt));
    var ri3 = await gesImagen.Cargar(new Imagen(0, "https://ejemplo.com/img3.jpg", idArt));
    Console.WriteLine($"  Imagen 1: {ri1}");
    Console.WriteLine($"  Imagen 2: {ri2}");
    Console.WriteLine($"  Imagen 3: {ri3}");

    // Intentar agregar imagen a artículo inexistente
    var riFail = await gesImagen.Cargar(new Imagen(0, "https://ejemplo.com/fail.jpg", 99999));
    Console.WriteLine($"  Artículo inexistente: {riFail}  ← debería ser NoExisteArticulo");
}
Pausa();

Titulo("IMÁGENES - Listar imágenes de un artículo");
if (articulos.Count()>0)
{
    int idArt = articulos.First().id;
    List<Imagen> imagenes = await gesImagen.EsIgual(x=>x.idArticulo,idArt);// este metodo sirve para buscar todos los registros en donde el valor que ingresaste sea igual al que tiene el objeto en la propiedad que elegiste en este caso se usa para listar todas las imagenes de un articulo pero lo podes usar para muchas otras cosas
    Console.WriteLine($"  Artículo ID {idArt} tiene {imagenes.Count} imagen(es):");
    imagenes.ForEach(i => Console.WriteLine($"    [{i.GetId()}] {i.GetimagenUrl()}"));
}
Pausa();

Titulo("IMÁGENES - Modificar URL");
if (articulos.Count()>0)
{
    int idArt = articulos.First().id;
    List<Imagen> imagenes = await gesImagen.EsIgual(x=>x.idArticulo,idArt);
    if (imagenes.Any())
    {
        int idImg = imagenes.First().GetId();
        var res = await gesImagen.ModificarUrl(idImg, "https://ejemplo.com/nueva-url.jpg");
        Console.WriteLine($"  Resultado: {res}");
        var verificacion = await gesImagen.CapturarImagen(idImg);
        Console.WriteLine($"  URL actualizada: {verificacion?.GetimagenUrl()}");
    }
}
Pausa();

Titulo("IMÁGENES - Eliminar imagen");
if (articulos.Count()>0)
{
    int idArt = articulos.First().id;
    List<Imagen> imagenes = await gesImagen.EsIgual(x=>x.idArticulo,idArt);
    if (imagenes.Count()>0)
    {
        int idImg = imagenes.Last().GetId();
        var res = await gesImagen.Eliminar(idImg);
        Console.WriteLine($"  Resultado: {res}");
        idArt = articulos.First().id;
        List<Imagen> restantes = await gesImagen.EsIgual(x=>x.idArticulo,idArt);
        Console.WriteLine($"  Imágenes restantes: {restantes.Count}");
    }
}
Pausa();
En desarrollo*/
// ─── ELIMINAR ─────────────────────────────────────────────────────────────────

Titulo("ARTÍCULOS - Eliminar");
articulos = await gesArticulo.ObtenerArticulos();
if (articulos.Count()>0)
{
    int idEliminar = articulos.Last().id;
    Console.WriteLine($"  Eliminando artículo ID {idEliminar}: {articulos.Last().Nombre}");
    var res = await gesArticulo.Eliminar(idEliminar);
    Console.WriteLine($"  Resultado: {res}");
    var verificacion = await gesArticulo.CapturarArticulo(idEliminar);
    Console.WriteLine($"  ¿Sigue existiendo?: {verificacion != null}  ← debería ser False");
}
Pausa();

Titulo("ARTÍCULOS - Eliminar ID inexistente (debe fallar)");
var resElimFail = await gesArticulo.Eliminar(99999);
Console.WriteLine($"  Resultado: {resElimFail}  ← debería ser NoExiste");
Pausa();

Console.WriteLine();
Console.WriteLine("  Demo completa. Fin del programa.");
Console.ReadKey();