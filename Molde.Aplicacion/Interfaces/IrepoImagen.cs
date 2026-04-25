public interface IrepoImagen
{
    public Task<List<Imagen>> ObtenerImagenes();
    public Task<List<Imagen>> ObtenerImagenesPorArticulo(int idArticulo);
    public Task<Imagen?> CapturarImagen(int id);
    public Task InsertarImagen(Imagen obj);
    public Task Actualizar(Imagen obj);
    public Task Eliminar(int id);
    public Task<List<Imagen>> LosMayoresMenores(PropiedadesImagen Propiedad,Ordenador Ordenar);
    public Task<List<Imagen>> MayorMenorA(int Valor,PropiedadesImagen Propiedad,Comparador Comparar);
    public Task<List<Imagen>> Entre(int Valor1,int Valor2,PropiedadesImagen Propiedad,Comparador Comparar);
    public Task<List<Imagen>> BuscarStringCon(string Valor,BuscarString Comparador);


}