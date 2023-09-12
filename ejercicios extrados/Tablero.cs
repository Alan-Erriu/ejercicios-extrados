
namespace ejercicios_extrados
{


    internal class Tablero
    {
        private int[][] tablero;
        private int n;

        public Tablero(int n)
        {
            this.n = n;
            tablero = new int[n][];
            for (int i = 0; i < n; i++)
            {
                tablero[i] = new int[n];
            }
        }

        public bool Resolver()
        {
            return ColocarReina(0);
        }

        private bool EsSeguro(int fila, int columna)
        {
            // Verificar si es seguro colocar una reina en (fila, columna)
            for (int i = 0; i < fila; i++)
            {
                // Verificar si hay una reina en la misma columna
                if (tablero[i][columna] == 1)
                {
                    return false;
                }

                // Verificar diagonal superior izquierda
                if (columna - (fila - i) >= 0 && tablero[i][columna - (fila - i)] == 1)
                {
                    return false;
                }

                // Verificar diagonal superior derecha
                if (columna + (fila - i) < n && tablero[i][columna + (fila - i)] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ColocarReina(int fila)
        {
            if (fila == n)
            {
                // Todas las reinas están colocadas, se encontró una solución
                return true;
            }

            for (int columna = 0; columna < n; columna++)
            {
                if (EsSeguro(fila, columna))
                {
                    // Colocar una reina en (fila, columna)
                    tablero[fila][columna] = 1;

                    // Intentar colocar las reinas restantes
                    if (ColocarReina(fila + 1))
                    {
                        return true; // Se encontró una solución
                    }

                    // Si no se encontro una solución, retroceder
                    tablero[fila][columna] = 0;
                }
            }

            // No se encontro una solución 
            return false;
        }

        // Metodo para imprimir el tablero
        public void ImprimirTablero()
        {
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < n; columna++)
                {
                    Console.Write(tablero[fila][columna] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}




