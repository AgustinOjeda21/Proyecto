using Microsoft.EntityFrameworkCore;

public class RepositorioCategoria : IrepoCategoria
{
    private readonly CatalogoP3DbContext context;
   
    private readonly MotorBusquedaCategoria motor;
    public RepositorioCategoria(CatalogoP3DbContext context,MotorBusquedaCategoria motor)
    {
        this.context = context;
        this.motor = motor;
    }

    public async Task<List<Categoria>> ObtenerCategorias()
    {
        var Resultado = await context.Categorias.ToListAsync();
        return Resultado.Select(e => new Categoria(e.id,e.Descripcion)).ToList();
    }

    public async Task<Categoria?> CapturarCategoria(int? id)
    {
        EntityCategoria? obj = await context.Categorias.FindAsync(id);
        if(obj==null)
        {
            return null;
        }
        Categoria categoria = new Categoria(obj.id,obj.Descripcion);
        return categoria;
    }

    public async Task InsertarCategoria(Categoria obj)
    {
        EntityCategoria categoria = new EntityCategoria(obj.GetId(),obj.GetDescripcion());
        context.Categorias.Add(categoria);
        await context.SaveChangesAsync();
    }

    public async Task Actualizar(Categoria obj)
    {
        EntityCategoria? categoria = await context.Categorias.FindAsync(obj.GetId());
        if(categoria==null)
        {
            return;
        }
        categoria.Mapeo(obj);
        await context.SaveChangesAsync();
    }
    
    public async Task<ResultadoCategoria> Eliminar(int id)
    {
        bool TieneArt = await context.Articulos.AnyAsync(x=>x.idCategoria==id);
        if(TieneArt)
        {
            return ResultadoCategoria.TieneArticulos;
        }
        EntityCategoria? obj = await context.Categorias.FindAsync(id);
        if(obj==null)
        {
            return ResultadoCategoria.NoExiste;
        }
        context.Categorias.Remove(obj);
        await context.SaveChangesAsync();
        return ResultadoCategoria.EjecuccionCorrecta;
    }

    public async Task<List<Categoria>> EjecutarQuery(IQueryable<EntityCategoria> query)
    {
        return await query.Select(e => new Categoria(e.id,e.Descripcion)).ToListAsync();
    }
    public async Task<List<Categoria>> LosMayoresMenores(PropiedadesCategoria Propiedad,Ordenador Ordenar)
    {
        var query = context.Categorias.AsQueryable();
        query = Ordenar switch
        {
            Ordenador.Ascendente => motor.OrdenarAscendente(query,Propiedad),
            Ordenador.Descendente => motor.OrdenarDescendente(query,Propiedad),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Categoria>> MayorMenorA(int Valor,Comparador Comparar)
    {
        var query = context.Categorias.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorA => motor.MayorA(query,Valor),
            Comparador.MenorA => motor.MenorA(query,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Categoria>> Entre(int Valor1,int Valor2,Comparador Comparar)
    {
        var query = context.Categorias.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorMenorA => motor.MayorMenor(query,Valor1,Valor2),
            Comparador.Entre => motor.Entre(query,Valor1,Valor2),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Categoria>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        var query = context.Categorias.AsQueryable();
        query = Comparador switch
        {
            BuscarString.Contiene => motor.Contiene(query,Valor),
            BuscarString.EmpiezaCon => motor.EmpiezaCon(query,Valor),
            BuscarString.TerminaCon => motor.TerminaCon(query,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }
    

}