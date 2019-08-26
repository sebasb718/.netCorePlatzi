using System;
using static System.Console;

namespace ProyectoEscuela.Util
{
  public static class Printer
  {
    public static void DibujarLinea(int tamaño = 10)
    {
      WriteLine("".PadLeft(tamaño, '='));
    }
    public static void WriteTitle(string titulo)
    {
      var tamañoLinea = titulo.Length + 4;
      DibujarLinea(tamañoLinea);
      WriteLine($"| {titulo.ToUpper()} |");
      DibujarLinea(tamañoLinea);
    }

    public static void Beep(int frecuencia = 2000, int tiempo = 500, int cantidad = 1)
    {
      while (cantidad-- > 0)
      {
        Console.Beep(frecuencia, tiempo);
      }
    }

  }
}