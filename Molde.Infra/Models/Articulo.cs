using System;
using System.Collections.Generic;



public partial class EntityArticulo
{
    public EntityArticulo(){}
    public EntityArticulo(int id,string? Codigo,string? Nombre,string? Descripcion,decimal? Precio,int? idMarca,int? idCategoria)
    {
        this.id = id;
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Precio = Precio;
        this.idMarca = idMarca;
        this.idCategoria = idCategoria;
        
    }
    public int id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? idMarca { get; set; }

    public int? idCategoria { get; set; }

    public decimal? Precio { get; set; }

    public void Mapeo(Articulo obj)
    {
        id = obj.GetId();
        this.Codigo = obj.GetCodigo();
        this.Nombre = obj.GetNombre();
        this.Descripcion = obj.GetDescripcion();
        this.Precio = obj.GetPrecio();
        idMarca = obj.GetIdMarca();
        idCategoria = obj.GetIdCategoria();
    }
}
