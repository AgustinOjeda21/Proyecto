
public class MotorBusquedaMarca
{
    public IQueryable<EntityMarca> Contiene(IQueryable<EntityMarca> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.Contains(Valor));
            
    }
    public IQueryable<EntityMarca> EmpiezaCon(IQueryable<EntityMarca> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.StartsWith(Valor));
            
    }
    public IQueryable<EntityMarca> TerminaCon(IQueryable<EntityMarca> query,string Valor)
    {
        return query.Where(x=>x.Descripcion.EndsWith(Valor)); 
    }
    public IQueryable<EntityMarca> MayorA(IQueryable<EntityMarca> query,int Valor)
    {
        return query.Where(x=>x.Id>Valor);
    }
    
    public IQueryable<EntityMarca> MenorA(IQueryable<EntityMarca> query,int Valor)
    {
        return query.Where(x=>x.Id<Valor);  
    }
    public IQueryable<EntityMarca> Entre(IQueryable<EntityMarca> query,int Valor,int Valor2)
    {
        return query.Where(x=>x.Id>Valor&&x.Id<Valor2);
    }

    public IQueryable<EntityMarca> MayorMenor(IQueryable<EntityMarca> query,int Valor,int Valor2)
    {
        return query.Where(x=>x.Id<Valor||x.Id>Valor2);
    }

    public IQueryable<EntityMarca> OrdenarDescendente(IQueryable<EntityMarca> query,PropiedadesMarca propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesMarca.id => query.OrderByDescending(x=>x.Id),
            PropiedadesMarca.Descripcion => query.OrderByDescending(x=>x.Descripcion),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityMarca> OrdenarAscendente(IQueryable<EntityMarca> query,PropiedadesMarca propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesMarca.id => query.OrderBy(x=>x.Id),
            PropiedadesMarca.Descripcion => query.OrderBy(x=>x.Descripcion),
            _=> throw new Exception("Error del programa")
        };
    }
}