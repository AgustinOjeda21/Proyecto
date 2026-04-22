using System;
using System.Collections.Generic;


public partial class EntityCategoria
{
    public EntityCategoria(){}
    public EntityCategoria(int id,string? Descripcion)
    {
        this.id = id;
        this.Descripcion = Descripcion;
    }
    public int id { get; set; }

    public string? Descripcion { get; set; }
    public void Mapeo(Categoria obj)
    {
        id = obj.GetId();
        Descripcion = obj.GetDescripcion();
    }
}
