using Resolver8Piezas;

namespace Problema8Piezas
{
    internal class Torre : IPiezaAjedrez
    {
        public int n = 8;
        public string tipoDePieza = "Torre";
        public bool EsSeguro(int fila, int columna, Estados[][] tablero)
        {

            for (int i = 0; i < fila; i++)
            {
                // Verificar si hay una reina en la misma columna
                if (tablero[i][columna] == Estados.Ocupado)
                {
                    return false;
                }

            }
            return true;
        }


    }
}
