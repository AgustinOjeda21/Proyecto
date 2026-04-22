
public interface IrepoMarca
{
    public Task<List<Marca>> ObtenerMarcas();
    public Task<Marca?> CapturarMarca(int? id);
    public Task InsertarMarca(Marca obj);
    public Task Actualizar(Marca obj);
    public Task<ResultadoMarca> Eliminar(int id);
    public Task<List<Marca>> LosMayoresMenores(PropiedadesMarca Propiedad,Ordenador Ordenar);
    public Task<List<Marca>> MayorMenorA(int Valor,Comparador Comparar);
    public Task<List<Marca>> Entre(int Valor1,int Valor2,Comparador Comparar);
    public Task<List<Marca>> BuscarStringCon(string Valor,BuscarString Comparador);
    
    
}