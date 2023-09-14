using ejercicios_extrados;
int n = 8; // Tamaño del tablero y número de reinas
Tablero tablero = new Tablero(n);
if (tablero.Resolver())
{
    Console.WriteLine("Solución encontrada:");
    tablero.ImprimirTablero();
}
else
{
    Console.WriteLine("No se encontró una solución.");
}

