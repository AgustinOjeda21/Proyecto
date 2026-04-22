using Microsoft.EntityFrameworkCore;

using Molde.Aplicacion.Interfaces;

public class RepositorioArticulo : IrepoArticulo
{
    private readonly CatalogoP3DbContext context;
    private readonly MotorBusquedaArticulo motor;
    public RepositorioArticulo(CatalogoP3DbContext context,MotorBusquedaArticulo motor)
    {
        this.context = context;
        this.motor = motor;
    }

    public async Task<List<Articulo>> ObtenerArticulos()
    {
        var Resultado = await context.Articulos.ToListAsync();
        return Resultado.Select(e => new Articulo(e.id,e.Codigo,e.Nombre,e.Descripcion,e.Precio,e.idMarca,e.idCategoria)).ToList();
    }

    public async Task<Articulo?> CapturarArticulo(int id)
    {
        EntityArticulo? obj = await context.Articulos.FindAsync(id);
        if(obj==null)
        {
            return null;
        }
        Articulo articulo = new Articulo(obj.id,obj.Codigo,obj.Nombre,obj.Descripcion,obj.Precio,obj.idMarca,obj.idCategoria);
        return articulo;
    }

    public async Task InsertarArticulo(Articulo obj)
    {
        EntityArticulo articulo = new EntityArticulo(obj.GetId(),obj.GetCodigo(),obj.GetNombre(),obj.GetDescripcion(),obj.GetPrecio(),obj.GetIdMarca(),obj.GetIdCategoria());
        context.Articulos.Add(articulo);
        await context.SaveChangesAsync();
    }

    public async Task Actualizar(Articulo obj)
    {
        EntityArticulo? articulo = await context.Articulos.FindAsync(obj.GetId());
        if(articulo==null)
        {
            return;
        }
        articulo.Mapeo(obj);
        await context.SaveChangesAsync();
    }
    public async Task Eliminar(int id)
    {
        await context.Imagenes.Where(x=>x.idArticulo==id).ExecuteDeleteAsync();
        EntityArticulo? obj = await context.Articulos.FindAsync(id);
        if(obj==null)
        {
            return ;
        }
        context.Articulos.Remove(obj);
        await context.SaveChangesAsync();
    }

    public async Task<List<Articulo>> EjecutarQuery(IQueryable<EntityArticulo> query)
    {
        return await query.Select(e => new Articulo(e.id,e.Codigo,e.Nombre,e.Descripcion,e.Precio,e.idMarca,e.idCategoria)).ToListAsync();
    }
    public async Task<List<Articulo>> LosMayoresMenores(PropiedadesArticulo Propiedad,Ordenador Ordenar)
    {
        var query = context.Articulos.AsQueryable();
        query = Ordenar switch
        {
            Ordenador.Ascendente => motor.OrdenarAscendente(query,Propiedad),
            Ordenador.Descendente => motor.OrdenarDescendente(query,Propiedad),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Articulo>> MayorMenorA(int Valor,PropiedadesArticulo Propiedad,Comparador Comparar)
    {
        var query = context.Articulos.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorA => motor.MayorA(query,Propiedad,Valor),
            Comparador.MenorA => motor.MenorA(query,Propiedad,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Articulo>> Entre(int Valor1,int Valor2,PropiedadesArticulo Propiedad,Comparador Comparar)
    {
        var query = context.Articulos.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorMenorA => motor.MayorMenor(query,Propiedad,Valor1,Valor2),
            Comparador.Entre => motor.Entre(query,Propiedad,Valor1,Valor2),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Articulo>> BuscarStringCon(string Valor,PropiedadesArticulo Propiedad,BuscarString Comparador)
    {
        var query = context.Articulos.AsQueryable();
        query = Comparador switch
        {
            BuscarString.Contiene => motor.Contiene(query,Propiedad,Valor),
            BuscarString.EmpiezaCon => motor.EmpiezaCon(query,Propiedad,Valor),
            BuscarString.TerminaCon => motor.TerminaCon(query,Propiedad,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

}