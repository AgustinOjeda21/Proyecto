using System.Linq.Expressions;
using Molde.Aplicacion.Interfaces;

public class GestorMarca : IgesMarca
{
    private readonly IrepoMarca repo;

    public GestorMarca(IrepoMarca repo)
    {
        this.repo = repo;
    }

    public async Task Cargar(Marca obj)
    {
        await repo.InsertarMarca(obj);
    }

    public async Task<List<Marca>> ObtenerMarcas()
    {
        return await repo.ObtenerMarcas();
    }

    public async Task<Marca?> CapturarMarca(int id)
    {
        return await repo.CapturarMarca(id);
    }

    public async Task<bool>ExisteMarca(int? id)
    {
        return await repo.CapturarMarca(id) != null;
    }

    public async Task<ResultadoMarca>ModificarDescripcion(int id,string valor)
    {
        Marca? obj = await repo.CapturarMarca(id);
        if(obj is null)
        {
            return ResultadoMarca.NoExiste;
        }
        obj.SetDescripcion(valor);
        await repo.Actualizar(obj);
        return ResultadoMarca.EjecuccionCorrecta;
    }

    public async Task<List<Marca>> LosMayoresMenores(PropiedadesMarca Propiedad,Ordenador Ordenar)
    {
        return await repo.LosMayoresMenores(Propiedad,Ordenar);
    }

    public async Task<List<Marca>> MayorMenorA(int Valor,Comparador Comparar)
    {
        return await repo.MayorMenorA(Valor,Comparar);
    }
    public async Task<List<Marca>> Entre(int Valor1,int Valor2,Comparador Comparar)
    {
        return await repo.Entre(Valor1,Valor2,Comparar);
    }
    public async Task<List<Marca>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        return await repo.BuscarStringCon(Valor,Comparador);
    }

   public async Task<ResultadoMarca> Eliminar(int id)
    {
        if(await ExisteMarca(id)==false)
        {
            return ResultadoMarca.NoExiste;
        }
        return await repo.Eliminar(id);
    }

}