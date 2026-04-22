using AutoMapper;

using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

public class RepositorioMarca : IrepoMarca
{
    private readonly CatalogoP3DbContext context;

    private readonly MotorBusquedaMarca motor;
    public RepositorioMarca(CatalogoP3DbContext context,MotorBusquedaMarca motor)
    {
        this.context = context;
        this.motor = motor;
    }

    public async Task<List<Marca>> ObtenerMarcas()
    {
        var Resultado = await context.Marcas.ToListAsync();
        return Resultado.Select(e => new Marca(e.Id,e.Descripcion)).ToList();
    }

    public async Task<Marca?> CapturarMarca(int? id)
    {
        EntityMarca? obj = await context.Marcas.FindAsync(id);
        if(obj==null)
        {
            return null;
        }
        Marca marca = new Marca(obj.Id,obj.Descripcion);
        return marca;
    }

    public async Task InsertarMarca(Marca obj)
    {
        EntityMarca marca = new EntityMarca(obj.GetId(),obj.GetDescripcion());
        context.Marcas.Add(marca);
        await context.SaveChangesAsync();
    }

    public async Task Actualizar(Marca obj)
    {
        EntityMarca? marca = await context.Marcas.FindAsync(obj.GetId());
        if(marca==null)
        {
            return;
        }
        marca.Mapeo(obj);
        await context.SaveChangesAsync();
    }

    public async Task<ResultadoMarca> Eliminar(int id)
    {
        bool TieneArt = await context.Articulos.AnyAsync(x=>x.idMarca==id);
        if(TieneArt)
        {
            return ResultadoMarca.TieneArticulos;
        }
        EntityMarca? obj = await context.Marcas.FindAsync(id);
        if(obj==null)
        {
            return ResultadoMarca.NoExiste;
        }
        context.Marcas.Remove(obj);
        await context.SaveChangesAsync();
        return ResultadoMarca.EjecuccionCorrecta;
    }
    public async Task<List<Marca>> EjecutarQuery(IQueryable<EntityMarca> query)
    {
        return await query.Select(e => new Marca(e.Id,e.Descripcion)).ToListAsync();
    }
    public async Task<List<Marca>> LosMayoresMenores(PropiedadesMarca Propiedad,Ordenador Ordenar)
    {
        var query = context.Marcas.AsQueryable();
        query = Ordenar switch
        {
            Ordenador.Ascendente => motor.OrdenarAscendente(query,Propiedad),
            Ordenador.Descendente => motor.OrdenarDescendente(query,Propiedad),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Marca>> MayorMenorA(int Valor,Comparador Comparar)
    {
        var query = context.Marcas.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorA => motor.MayorA(query,Valor),
            Comparador.MenorA => motor.MenorA(query,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Marca>> Entre(int Valor1,int Valor2,Comparador Comparar)
    {
        var query = context.Marcas.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorMenorA => motor.MayorMenor(query,Valor1,Valor2),
            Comparador.Entre => motor.Entre(query,Valor1,Valor2),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Marca>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        var query = context.Marcas.AsQueryable();
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