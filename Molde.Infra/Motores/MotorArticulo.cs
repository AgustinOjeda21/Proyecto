public class MotorBusquedaArticulo
{
    public IQueryable<EntityArticulo> Contiene(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,string Valor)
    {
        return propiedad switch
        {
            PropiedadesArticulo.Codigo => query.Where(x=>x.Codigo.Contains(Valor)),
            PropiedadesArticulo.Nombre => query.Where(x=>x.Nombre.Contains(Valor)),
            PropiedadesArticulo.Descripcion => query.Where(x=>x.Descripcion.Contains(Valor)),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityArticulo> EmpiezaCon(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,string Valor)
    {
        return propiedad switch
        {
            PropiedadesArticulo.Codigo => query.Where(x=>x.Codigo.StartsWith(Valor)),
            PropiedadesArticulo.Nombre => query.Where(x=>x.Nombre.StartsWith(Valor)),
            PropiedadesArticulo.Descripcion => query.Where(x=>x.Descripcion.StartsWith(Valor)),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityArticulo> TerminaCon(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,string Valor)
    {
        return propiedad switch
        {
            PropiedadesArticulo.Codigo => query.Where(x=>x.Codigo.EndsWith(Valor)),
            PropiedadesArticulo.Nombre => query.Where(x=>x.Nombre.EndsWith(Valor)),
            PropiedadesArticulo.Descripcion => query.Where(x=>x.Descripcion.EndsWith(Valor)),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityArticulo> MayorA(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,int Valor)
    {
        return propiedad switch
        {
            PropiedadesArticulo.id  => query.Where(x=>x.id>Valor),
            PropiedadesArticulo.idCategoria  => query.Where(x=>x.idCategoria>Valor),
            PropiedadesArticulo.idMarca  => query.Where(x=>x.idMarca>Valor),
            PropiedadesArticulo.Precio => query.Where(x=>x.Precio>Valor),
            _=> throw new Exception("Error del programa")
        };
    }
    
    public IQueryable<EntityArticulo> MenorA(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,int Valor)
    {
        return propiedad switch
        {
            PropiedadesArticulo.id  => query.Where(x=>x.id<Valor),
            PropiedadesArticulo.idCategoria  => query.Where(x=>x.idCategoria<Valor),
            PropiedadesArticulo.idMarca  => query.Where(x=>x.idMarca<Valor),
            PropiedadesArticulo.Precio => query.Where(x=>x.Precio<Valor),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityArticulo> Entre(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,int Valor,int Valor2)
    {
        return propiedad switch
        {
            PropiedadesArticulo.id  => query.Where(x=>x.id>Valor&&x.id<Valor2),
            PropiedadesArticulo.idCategoria  => query.Where(x=>x.idCategoria>Valor&&x.idCategoria<Valor2),
            PropiedadesArticulo.idMarca  => query.Where(x=>x.idMarca>Valor&&x.idMarca<Valor2),
            PropiedadesArticulo.Precio => query.Where(x=>x.Precio>Valor&&x.Precio<Valor2),
            _=> throw new Exception("Error del programa")
        };
    }

    public IQueryable<EntityArticulo> MayorMenor(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad,int Valor,int Valor2)
    {
        return propiedad switch
        {
            PropiedadesArticulo.id  => query.Where(x=>x.id<Valor||x.id>Valor2),
            PropiedadesArticulo.idCategoria  => query.Where(x=>x.idCategoria<Valor||x.idCategoria>Valor2),
            PropiedadesArticulo.idMarca  => query.Where(x=>x.idMarca<Valor||x.idMarca>Valor2),
            PropiedadesArticulo.Precio => query.Where(x=>x.Precio<Valor||x.Precio>Valor2),
            _=> throw new Exception("Error del programa")
        };
    }

    public IQueryable<EntityArticulo> OrdenarDescendente(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesArticulo.id => query.OrderByDescending(x=>x.id),
            PropiedadesArticulo.Codigo => query.OrderByDescending(x=>x.Codigo),
            PropiedadesArticulo.Descripcion => query.OrderByDescending(x=>x.Descripcion),
            PropiedadesArticulo.Nombre => query.OrderByDescending(x=>x.Nombre),
            PropiedadesArticulo.Precio=> query.OrderByDescending(x=>x.Precio),
            PropiedadesArticulo.idCategoria=> query.OrderByDescending(x=>x.idCategoria),
            PropiedadesArticulo.idMarca=> query.OrderByDescending(x=>x.idMarca),
            _=> throw new Exception("Error del programa")
        };
    }
    public IQueryable<EntityArticulo> OrdenarAscendente(IQueryable<EntityArticulo> query,PropiedadesArticulo propiedad)
    {
        
        return propiedad switch
        {
            PropiedadesArticulo.id => query.OrderBy(x=>x.id),
            PropiedadesArticulo.Codigo => query.OrderBy(x=>x.Codigo),
            PropiedadesArticulo.Descripcion => query.OrderBy(x=>x.Descripcion),
            PropiedadesArticulo.Nombre => query.OrderBy(x=>x.Nombre),
            PropiedadesArticulo.Precio=> query.OrderBy(x=>x.Precio),
            PropiedadesArticulo.idCategoria=> query.OrderBy(x=>x.idCategoria),
            PropiedadesArticulo.idMarca=> query.OrderBy(x=>x.idMarca),
            _=> throw new Exception("Error del programa")
        };
    }
}