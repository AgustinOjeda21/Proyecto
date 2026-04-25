

namespace Molde.Aplicacion.Interfaces
{
    public interface IrepoArticulo
    {
        public Task<List<Articulo>> ObtenerArticulos();
        public Task<Articulo?> CapturarArticulo(int id);
        public Task<int> InsertarArticulo(Articulo obj);
        public Task Actualizar(Articulo obj);
        public Task Eliminar(int id);
        public Task<List<Articulo>> LosMayoresMenores(PropiedadesArticulo Propiedad,Ordenador Ordenar);
        public Task<List<Articulo>> MayorMenorA(int Valor,PropiedadesArticulo Propiedad,Comparador Comparar);
        public Task<List<Articulo>> Entre(int Valor1,int Valor2,PropiedadesArticulo Propiedad,Comparador Comparar);
        public Task<List<Articulo>> BuscarStringCon(string Valor,PropiedadesArticulo Propiedad,BuscarString Comparador);
    
        

    }
}