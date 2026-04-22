
using Microsoft.EntityFrameworkCore;


public class RepositorioImagen : IrepoImagen
{
    private readonly CatalogoP3DbContext context;

    private readonly MotorBusquedaImagen motor;
    public RepositorioImagen(CatalogoP3DbContext context,MotorBusquedaImagen motor)
    {
        this.context = context;
        this.motor = motor;
    }

    public async Task<List<Imagen>> ObtenerImagenes()
    {
        var Resultado = await context.Imagenes.ToListAsync();
        return Resultado.Select(e => new Imagen(e.id,e.imagenUrl,e.idArticulo)).ToList();
    }

    public async Task<Imagen?> CapturarImagen(int id)
    {
        EntityImagen? obj = await context.Imagenes.FindAsync(id);
        if(obj==null)
        {
            return null;
        }
        Imagen imagen = new Imagen(obj.id,obj.imagenUrl,obj.idArticulo);
        return imagen;
    }

    public async Task InsertarImagen(Imagen obj)
    {
        EntityImagen imagen = new EntityImagen(obj.GetId(),obj.GetimagenUrl(),obj.GetIdArticulo());
        context.Imagenes.Add(imagen);
        await context.SaveChangesAsync();
    }

    public async Task Actualizar(Imagen obj)
    {
        EntityImagen? imagen = await context.Imagenes.FindAsync(obj.GetId());
        if(imagen==null)
        {
            return;
        }
        imagen.Mapeo(obj);
        await context.SaveChangesAsync();
    }

    public async Task Eliminar(int id)
    {
        EntityImagen? obj = await context.Imagenes.FindAsync(id);
        if(obj==null)
        {
            return ;
        }
        context.Imagenes.Remove(obj);
        await context.SaveChangesAsync();
    }
    public async Task<List<Imagen>> EjecutarQuery(IQueryable<EntityImagen> query)
    {
        return await query.Select(e => new Imagen(e.id,e.imagenUrl,e.idArticulo)).ToListAsync();
    }
    public async Task<List<Imagen>> LosMayoresMenores(PropiedadesImagen Propiedad,Ordenador Ordenar)
    {
        var query = context.Imagenes.AsQueryable();
        query = Ordenar switch
        {
            Ordenador.Ascendente => motor.OrdenarAscendente(query,Propiedad),
            Ordenador.Descendente => motor.OrdenarDescendente(query,Propiedad),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Imagen>> MayorMenorA(int Valor,PropiedadesImagen Propiedad,Comparador Comparar)
    {
        var query = context.Imagenes.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorA => motor.MayorA(query,Propiedad,Valor),
            Comparador.MenorA => motor.MenorA(query,Propiedad,Valor),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Imagen>> Entre(int Valor1,int Valor2,PropiedadesImagen Propiedad,Comparador Comparar)
    {
        var query = context.Imagenes.AsQueryable();
        query = Comparar switch
        {
            Comparador.MayorMenorA => motor.MayorMenor(query,Propiedad,Valor1,Valor2),
            Comparador.Entre => motor.Entre(query,Propiedad,Valor1,Valor2),
            _=> throw new Exception("Error del programa")
        };
        return await EjecutarQuery(query);
    }

    public async Task<List<Imagen>> BuscarStringCon(string Valor,BuscarString Comparador)
    {
        var query = context.Imagenes.AsQueryable();
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