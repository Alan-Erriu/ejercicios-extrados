namespace Resolver8Piezas
{
    public enum Estados
    {
        Libre = 0,
        Ocupado = 1,


    }
    public interface IPiezaAjedrez
    {



        bool EsSeguro(int fila, int columna, Estados[][] tablero);
    }
}
