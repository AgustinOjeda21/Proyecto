
public class Marca
{
    public Marca(){}
    public Marca(int id,string? Descripcion)
    {
        this.id = id;
        this.Descripcion = Descripcion;
    }
    public int id {get; private set;}
    public string? Descripcion {get; private set;}
    public int GetId()
    {
        return id;
    }
    public string? GetDescripcion()
    {
        return Descripcion;
    }
    public void SetDescripcion(string Descripcion)
    {
        this.Descripcion = Descripcion;
    }
}