using System.Linq.Expressions;
using Molde.Aplicacion.Interfaces;

public class GestorImagen 
{
    private readonly IrepoImagen repo;
    private readonly IgesArticulo gesart;

    public GestorImagen(IrepoImagen repo,IgesArticulo gesart)
    {
        this.gesart = gesart;
        this.repo = repo;
    }

    public async Task<ResultadoImagen> Cargar(Imagen obj)
    {
        if(!await gesart.ExisteArticulo(obj.GetIdArticulo()))
        {
            return ResultadoImagen.NoExisteArticulo;
        }
        await repo.InsertarImagen(obj);
        return ResultadoImagen.EjecuccionCorrecta;
    }

    public async Task<List<Imagen>> ObtenerImagenes()
    {
        return await repo.ObtenerImagenes();
    }

    public async Task<Imagen?> CapturarImagen(int id)
    {
        return await repo.CapturarImagen(id);
    }

    public async Task<bool>ExisteImagen(int id)
    {
        return await repo.CapturarImagen(id) != null;
    }

    public async Task<ResultadoImagen>ModificarUrl(int id,string valor)
    {
        Imagen? obj = await repo.CapturarImagen(id);
        if(obj is null)
        {
            return ResultadoImagen.NoExiste;
        }
        obj.SetimagenUrl(valor);
        await repo.Actualizar(obj);
        return ResultadoImagen.EjecuccionCorrecta;
    }
    public async Task<ResultadoImagen>ModificarArticulo(int id,int valor)
    {
        Imagen? obj = await repo.CapturarImagen(id);
        if(obj is null)
        {
            return ResultadoImagen.NoExiste;
        }
        if(!await gesart.ExisteArticulo(valor))
        {
            return ResultadoImagen.NoExisteArticulo;
        }
        obj.SetIdArticulo(valor);
        await repo.Actualizar(obj);
        return ResultadoImagen.EjecuccionCorrecta;
    }
   
    public async Task<List<Imagen>> LosMayoresMenores(PropiedadesImagen Propiedad,Ordenador Ordenar)
    {
        return await repo.LosMayoresMenores(Propiedad,Ordenar);
    }

    public async Task<List<Imagen>> MayorMenorA(int Valor,PropiedadesImagen Propiedad,Comparador Comparar)
    {
        return await repo.MayorMenorA(Valor,Propiedad,Comparar);
    }
    public async Task<List<Imagen>> Entre(int Valor1,int Valor2,PropiedadesImagen Propiedad,Comparador Comparar)
    {
        return await repo.Entre(Valor1,Valor2,Propiedad,Comparar);
    }
    public async Task<List<Imagen>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        return await repo.BuscarStringCon(Valor,Comparador);
    }
    public async Task<ResultadoImagen> Eliminar(int id)
    {
        if(await ExisteImagen(id)==false)
        {
            return ResultadoImagen.NoExiste;
        }
        await repo.Eliminar(id);
        return ResultadoImagen.EjecuccionCorrecta;
    }

    
}