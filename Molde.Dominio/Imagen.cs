public class Imagen
{
    public Imagen(){}
    public Imagen(int id,string imagenUrl,int idArticulo)
    {
        this.id = id;
        this.imagenUrl = imagenUrl;
        this.idArticulo = idArticulo;
    }
    public int id {get; private set;}
    public int idArticulo {get; private set;}
    public string imagenUrl {get; private set;}
    public int GetId()
    {
        return id;
    }
    public int GetIdArticulo()
    {
        return idArticulo;
    }
    public string GetimagenUrl()
    {
        return imagenUrl;
    }
    public void SetimagenUrl(string imagenUrl)
    {
        this.imagenUrl = imagenUrl;
    }
    public void SetIdArticulo(int idArticulo)
    {
        this.idArticulo = idArticulo;
    }
}