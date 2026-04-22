public class MotorBusquedaCategoria
{
    public IQueryable<EntityCategoria> Contiene(IQueryable<EntityCategoria> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.Contains(Valor));
            
    }
    public IQueryable<EntityCategoria> EmpiezaCon(IQueryable<EntityCategoria> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.StartsWith(Valor));
            
    }
    public IQueryable<EntityCategoria> TerminaCon(IQueryable<EntityCategoria> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.EndsWith(Valor)); 
    }
    public IQueryable<EntityCategoria> MayorA(IQueryable<EntityCategoria> query,int Valor)
    {
        return query.Where(x=>x.id>Valor);
    }
    
    public IQueryable<EntityCategoria> MenorA(IQueryable<EntityCategoria> query,int Valor)
    {
        return query.Where(x=>x.id<Valor);  
    }
    public IQueryable<EntityCategoria> Entre(IQueryable<EntityCategoria> query,int Valor,int Valor2)
    {
        return query.Where(x=>x.id>Valor&&x.id<Valor2);
    }

    public IQueryable<EntityCategoria> MayorMenor(IQueryable<EntityCategoria> query,int Valor,int Valor2)
    {
        return query.Where(x=>x.id<Valor||x.id>Valor2);
    }

    public IQueryable<EntityCategoria> OrdenarDescendente(IQueryable<EntityCategoria> query,PropiedadesCategoria propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesCategoria.id => query.OrderByDescending(x=>x.id),
            PropiedadesCategoria.Descripcion => query.OrderByDescending(x=>x.Descripcion),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityCategoria> OrdenarAscendente(IQueryable<EntityCategoria> query,PropiedadesCategoria propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesCategoria.id => query.OrderBy(x=>x.id),
            PropiedadesCategoria.Descripcion => query.OrderBy(x=>x.Descripcion),
            _=> throw new Exception("Error del programa")
        };
    }
}