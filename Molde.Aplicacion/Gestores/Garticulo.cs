using System.Linq.Expressions;
using Molde.Aplicacion.Interfaces;

public class GestorArticulo : IgesArticulo
{
    private readonly IrepoArticulo repo;
    private readonly IgesCategoria gescat;
    private readonly IgesMarca gesmar;
    public GestorArticulo(IrepoArticulo repo,IgesCategoria gescat,IgesMarca gesmar)
    {
        this.repo = repo;
        this.gescat = gescat;
        this.gesmar = gesmar;
    }

    public async Task<ResultadoArticulo> Cargar(Articulo obj)
    {
        if(!await gescat.ExisteCategoria(obj.GetIdCategoria())&&obj.GetIdCategoria() is not null)
        {
            return ResultadoArticulo.NoExisteCategoria;
        }
        if(!await gesmar.ExisteMarca(obj.GetIdMarca())&&obj.GetIdMarca() is not null)
        {
            return ResultadoArticulo.NoExisteMarca;
        }
        await repo.InsertarArticulo(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<List<Articulo>> ObtenerArticulos()
    {
        return await repo.ObtenerArticulos();
    }

    public async Task<Articulo?> CapturarArticulo(int id)
    {
        return await repo.CapturarArticulo(id);
    }

    public async Task<bool>ExisteArticulo(int id)
    {
        return await repo.CapturarArticulo(id) != null;
    }
    public async Task<ResultadoArticulo>ModificarDescripcion(int id,string valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        obj.SetDescripcion(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<ResultadoArticulo>ModificarPrecio(int id,decimal valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        obj.SetPrecio(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<ResultadoArticulo>ModificarNombre(int id,string valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        obj.SetNombre(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<ResultadoArticulo>ModificarCodigo(int id,string valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        obj.SetCodigo(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<ResultadoArticulo>ModificarMarca(int id,int valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        if(!await gesmar.ExisteMarca(valor))
        {
            return ResultadoArticulo.NoExisteMarca;
        }
        obj.SetIdMarca(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }
    public async Task<ResultadoArticulo>ModificarCategoria(int id,int valor)
    {
        Articulo? obj = await repo.CapturarArticulo(id);
        if(obj is null)
        {
            return ResultadoArticulo.NoExiste;
        }
        if(!await gescat.ExisteCategoria(valor))
        {
            return ResultadoArticulo.NoExisteCategoria;
        }
        obj.SetIdCategoria(valor);
        await repo.Actualizar(obj);
        return ResultadoArticulo.EjecuccionCorrecta;
    }

    public async Task<List<Articulo>> LosMayoresMenores(PropiedadesArticulo Propiedad,Ordenador Ordenar)
    {
        return await repo.LosMayoresMenores(Propiedad,Ordenar);
    }

    public async Task<List<Articulo>> MayorMenorA(int Valor,PropiedadesArticulo Propiedad,Comparador Comparar)
    {
        return await repo.MayorMenorA(Valor,Propiedad,Comparar);
    }
    public async Task<List<Articulo>> Entre(int Valor1,int Valor2,PropiedadesArticulo Propiedad,Comparador Comparar)
    {
        return await repo.Entre(Valor1,Valor2,Propiedad,Comparar);
    }
    public async Task<List<Articulo>> BuscarStringCon(string Valor,PropiedadesArticulo Propiedad,BuscarString Comparador)
    {
        return await repo.BuscarStringCon(Valor,Propiedad,Comparador);
    }


    public async Task<ResultadoArticulo> Eliminar(int id)
    {
        if(await ExisteArticulo(id)==false)
        {
            return ResultadoArticulo.NoExiste;
        }
        await repo.Eliminar(id);
        return ResultadoArticulo.EjecuccionCorrecta;
    }

    

}
