

public class Articulo
{
    public Articulo(){}
    public Articulo(int id, string? Codigo,string? Nombre,string? Descripcion,decimal? Precio,int? idMarca,int? idCategoria)
    {
        this.id = id;
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Precio = Precio;
        this.idMarca = idMarca;
        this.idCategoria = idCategoria;
        
    }
    public int id {get; private set;}
    public string? Codigo {get; private set;}
    public string? Nombre {get; private set;}
    public string? Descripcion {get; private set;}
    public decimal? Precio {get; private set;}
    public int? idMarca {get; private set;}
    public int? idCategoria {get; private set;}
    public int GetId()
    {
        return id;
    }
    public int? GetIdMarca()
    {
        return idMarca;
    }
    public int? GetIdCategoria()
    {
        return idCategoria;
    }
    public string? GetDescripcion()
    {
        return Descripcion;
    }
    public string? GetNombre()
    {
        return Nombre;
    }
    public string? GetCodigo()
    {
        return Codigo;
    }
    public decimal? GetPrecio()
    {
        return Precio;
    }
    public void SetDescripcion(string Descripcion)
    {
        this.Descripcion = Descripcion;
    }
    public void SetNombre(string Nombre)
    {
        this.Nombre = Nombre;
    }
    public void SetCodigo(string Codigo)
    {
        this.Codigo = Codigo;
    }
    public void SetIdMarca(int idMarca)
    {
        this.idMarca = idMarca;
    }
    public void SetIdCategoria(int idCategoria)
    {
        this.idCategoria = idCategoria;
    }
    public void SetPrecio(decimal Precio)
    {
        this.Precio = Precio;
    }
}