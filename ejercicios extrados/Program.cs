using ejercicios_extrados;
int n = 8; // Tamaño del tablero y número de reinas
Tablero tablero = new Tablero(n);
if (tablero.Resolver())
{
    Console.WriteLine("Solución encontrada:");
    Console.WriteLine("El valor 1 representa una reina y valor 0 representa un lugar vacío");
    tablero.ImprimirTablero();
}
else
{
    Console.WriteLine("No se encontró una solución.");
}



