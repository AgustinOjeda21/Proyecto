
using Molde.Aplicacion.Interfaces;
using System.Linq.Expressions;

public class GestorCategoria : IgesCategoria
{
    private readonly IrepoCategoria repo;

    public GestorCategoria(IrepoCategoria repo)
    {
        this.repo = repo;
    }

    public async Task Cargar(Categoria obj)
    {
        await repo.InsertarCategoria(obj);
    }

    public async Task<List<Categoria>> ObtenerCategorias()
    {
        return await repo.ObtenerCategorias();
    }

    public async Task<Categoria?> CapturarCategoria(int id)
    {
        return await repo.CapturarCategoria(id);
    }

    public async Task<bool>ExisteCategoria(int? id)
    {
        return await repo.CapturarCategoria(id) != null;
    }

    public async Task<ResultadoCategoria>ModificarDescripcion(int id,string valor)
    {
        Categoria? obj = await repo.CapturarCategoria(id);
        if(obj is null)
        {
            return ResultadoCategoria.NoExiste;
        }
        obj.SetDescripcion(valor);
        await repo.Actualizar(obj);
        return ResultadoCategoria.EjecuccionCorrecta;
    }
    public async Task<List<Categoria>> LosMayoresMenores(PropiedadesCategoria Propiedad,Ordenador Ordenar)
    {
        return await repo.LosMayoresMenores(Propiedad,Ordenar);
    }

    public async Task<List<Categoria>> MayorMenorA(int Valor,Comparador Comparar)
    {
        return await repo.MayorMenorA(Valor,Comparar);
    }
    public async Task<List<Categoria>> Entre(int Valor1,int Valor2,Comparador Comparar)
    {
        return await repo.Entre(Valor1,Valor2,Comparar);
    }
    public async Task<List<Categoria>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        return await repo.BuscarStringCon(Valor,Comparador);
    }
    public async Task<ResultadoCategoria> Eliminar(int id)
    {
        if(await ExisteCategoria(id)==false)
        {
            return ResultadoCategoria.NoExiste;
        }
        return await repo.Eliminar(id);
    }

}