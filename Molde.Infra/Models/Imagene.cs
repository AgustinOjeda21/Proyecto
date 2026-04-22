using System;
using System.Collections.Generic;



public partial class EntityImagen
{
    public EntityImagen(){}
    public EntityImagen(int id,string imagenUrl,int idArticulo)
    {
        this.id = id;
        this.imagenUrl = imagenUrl;
        this.idArticulo = idArticulo;
    }
    public int id { get; set; }

    public int idArticulo { get; set; }

    public string imagenUrl { get; set; } = null!;

    public void Mapeo(Imagen obj)
    {
        this.id = obj.GetId();
        this.imagenUrl = obj.GetimagenUrl();
        this.idArticulo = obj.GetIdArticulo();
    }
}
