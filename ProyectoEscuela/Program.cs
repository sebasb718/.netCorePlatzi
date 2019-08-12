using System;
using System.Collections.Generic;
using ProyectoEscuela.Entidades;
using ProyectoEscuela.Util;
using static System.Console;

namespace ProyectoEscuela
{
  class Program
  {
    static void Main(string[] args)
    {
      var engine = new EscuelaEngine();
      engine.Inicializar();
      Printer.WriteTitle("Bienvenidos a la escuela");
      ImprimirCursosEscuela(engine.Escuela);
    }
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      Printer.WriteTitle("Cursos escuela");
      if (escuela?.Cursos != null)
      {
        foreach (var curso in escuela.Cursos)
        {
          WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueID}");
        }
      }
      else
      {
        WriteLine("No hay cursos en la escuela");
      }
    }

  }
}
