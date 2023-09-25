using Resolver8Piezas;

namespace Problema8Piezas
{
    internal class Caballo : IPiezaAjedrez
    {
        public int n = 8;
        public string tipoDePieza = "Caballo";
        public bool EsSeguro(int fila, int columna, Estados[][] tablero)
        {
            // Verificar si la posición está dentro del tablero
            if (fila >= 0 && fila < n && columna >= 0 && columna < n)
            {
                // Verifica si hay un caballlo
                if (tablero[fila][columna] != Estados.Pieza)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
