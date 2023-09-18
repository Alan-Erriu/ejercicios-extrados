// crear librería solucionar8piezas
// interfaz pieza
// crear objetos pieza con un patron de movimiento


using Problema8Piezas;
using Resolver8Piezas;

Reina reina = new Reina();
Torre torre = new Torre();
Alfil alfil = new Alfil();
Peon peon = new Peon();
Caballo caballo = new Caballo();




Resolver tablero = new Resolver(peon);

if (tablero.Resolver2())
{
    Console.WriteLine("Solución encontrada para tipo de pieza: " + peon.tipoDePieza);
    tablero.ImprimirTablero();
}
else
{
    Console.WriteLine("No se encontró una solución.");
}