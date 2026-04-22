public enum ResultadoCategoria
{
    NoExiste = 1,
    EjecuccionCorrecta = 2,
    TieneArticulos = 3
}
public enum ResultadoMarca
{
    NoExiste = 1,
    EjecuccionCorrecta = 2,
    TieneArticulos = 3
}
public enum ResultadoArticulo
{
    NoExiste = 1,
    EjecuccionCorrecta = 2,
    NoExisteMarca = 3,
    NoExisteCategoria = 4,

}
public enum ResultadoImagen
{
    NoExiste = 1,
    EjecuccionCorrecta = 2,
    NoExisteArticulo = 3,
    
}