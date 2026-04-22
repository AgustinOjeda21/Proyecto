
public interface IrepoCategoria
{
    public Task<List<Categoria>> ObtenerCategorias();
    public Task<Categoria?> CapturarCategoria(int? id);
    public Task InsertarCategoria(Categoria obj);
    public Task Actualizar(Categoria obj);
    public Task<ResultadoCategoria> Eliminar(int id);
    public Task<List<Categoria>> LosMayoresMenores(PropiedadesCategoria Propiedad,Ordenador Ordenar);
    public Task<List<Categoria>> MayorMenorA(int Valor,Comparador Comparar);
    public Task<List<Categoria>> Entre(int Valor1,int Valor2,Comparador Comparar);
    public Task<List<Categoria>> BuscarStringCon(string Valor,BuscarString Comparador);
    
    
}