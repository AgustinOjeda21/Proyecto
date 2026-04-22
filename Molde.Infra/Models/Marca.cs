using System;
using System.Collections.Generic;



public partial class EntityMarca
{
    public EntityMarca(){}
    public EntityMarca(int id,string? Descripcion)
    {
        Id = id;
        this.Descripcion = Descripcion;
    }
    public int Id { get; set; }
    public string? Descripcion { get; set; }

    public void Mapeo(Marca obj)
    {
        Id = obj.GetId();
        this.Descripcion = obj.GetDescripcion();
    }
}
