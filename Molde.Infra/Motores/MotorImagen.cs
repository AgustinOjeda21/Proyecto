public class MotorBusquedaImagen
{
    public IQueryable<EntityImagen> Contiene(IQueryable<EntityImagen> query,string Valor)
    {
        return query.Where(x=>x.imagenUrl.Contains(Valor));
            
    }
    public IQueryable<EntityImagen> EmpiezaCon(IQueryable<EntityImagen> query,string Valor)
    {
        return query.Where(x=>x.imagenUrl.StartsWith(Valor));
            
    }
    public IQueryable<EntityImagen> TerminaCon(IQueryable<EntityImagen> query,string Valor)
    {
        return query.Where(x=>x.imagenUrl.EndsWith(Valor)); 
    }
    public IQueryable<EntityImagen> MayorA(IQueryable<EntityImagen> query,PropiedadesImagen propiedad,int Valor)
    {
        return propiedad switch
        {
            PropiedadesImagen.id  => query.Where(x=>x.id>Valor),
            PropiedadesImagen.idArticulo  => query.Where(x=>x.idArticulo>Valor),
            _=> throw new Exception("Error del programa")
        };
    }
    
    public IQueryable<EntityImagen> MenorA(IQueryable<EntityImagen> query,PropiedadesImagen propiedad,int Valor)
    {
        return propiedad switch
        {
            PropiedadesImagen.id  => query.Where(x=>x.id<Valor),
            PropiedadesImagen.idArticulo  => query.Where(x=>x.idArticulo<Valor),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityImagen> Entre(IQueryable<EntityImagen> query,PropiedadesImagen propiedad,int Valor,int Valor2)
    {
        return propiedad switch
        {
            PropiedadesImagen.id  => query.Where(x=>x.id>Valor&&x.id<Valor2),
            PropiedadesImagen.idArticulo  => query.Where(x=>x.idArticulo>Valor&&x.idArticulo<Valor2),
            _=> throw new Exception("Error del programa")
        };
    }

    public IQueryable<EntityImagen> MayorMenor(IQueryable<EntityImagen> query,PropiedadesImagen propiedad,int Valor,int Valor2)
    {
        return propiedad switch
        {
            PropiedadesImagen.id  => query.Where(x=>x.id<Valor||x.id>Valor2),
            PropiedadesImagen.idArticulo  => query.Where(x=>x.idArticulo<Valor||x.idArticulo>Valor2),
     
            _=> throw new Exception("Error del programa")
        };
    }

    public IQueryable<EntityImagen> OrdenarDescendente(IQueryable<EntityImagen> query,PropiedadesImagen propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesImagen.id => query.OrderByDescending(x=>x.id),
            PropiedadesImagen.imagenUrl => query.OrderByDescending(x=>x.imagenUrl),
            PropiedadesImagen.idArticulo => query.OrderByDescending(x=>x.idArticulo),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityImagen> OrdenarAscendente(IQueryable<EntityImagen> query,PropiedadesImagen propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesImagen.id => query.OrderBy(x=>x.id),
            PropiedadesImagen.imagenUrl => query.OrderBy(x=>x.imagenUrl),
            PropiedadesImagen.idArticulo => query.OrderBy(x=>x.idArticulo),
            _=> throw new Exception("Error del programa")
        };
    }
}