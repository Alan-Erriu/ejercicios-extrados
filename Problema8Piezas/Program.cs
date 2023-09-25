


using Problema8Piezas;
using Resolver8Piezas;

Reina reina = new Reina();
Torre torre = new Torre();
Alfil alfil = new Alfil();
Peon peon = new Peon();
Caballo caballo = new Caballo();




Resolver tablero = new Resolver(reina);

if (tablero.Resolver2())
{
    Console.WriteLine("Solución encontrada para tipo de pieza: " + reina.tipoDePieza);
    Console.WriteLine("");
    tablero.ImprimirTablero();
}
else
{
    Console.WriteLine("No se encontró una solución.");
}