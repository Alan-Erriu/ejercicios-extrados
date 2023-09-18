using System;

namespace Resolver8Piezas
{


    public class Resolver
    {


        public IPiezaAjedrez pieza;
        public Estados[][] tablero;
        public int n = 8;


        public Resolver(IPiezaAjedrez pieza)
        {

            this.pieza = pieza;
            tablero = new Estados[n][];
            for (int i = 0; i < n; i++)
            {
                tablero[i] = new Estados[n]; //cada vuelta agrega un array de 8 hasta llegar a 8 = 8x8, todas las casilla son libres o 0
            }
        }

        public bool Resolver2()
        {
            return ColocarReina(0);
        }



        public bool ColocarReina(int fila)
        {
            if (fila == n) //las filas son igual a la cantidad de reinas 8x8
            {
                // Todas las reinas están colocadas, se encontró una solución
                return true;
            }

            for (int columna = 0; columna < n; columna++)
            {
                if (pieza.EsSeguro(fila, columna, tablero))
                {
                    // Colocar una reina en (fila, columna)
                    tablero[fila][columna] = Estados.Ocupado;

                    // Intentar colocar las reinas restantes
                    if (ColocarReina(fila + 1))
                    {
                        return true; // Se encontró una solución y fila se incrementa en 1
                    }

                    // Si no se encontro una solución, retroceder, fila no incrementa su valor
                    tablero[fila][columna] = Estados.Libre;
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

