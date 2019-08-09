using System;
using System.Collections.Generic;
using ProyectoEscuela.Entidades;
using static System.Console;

namespace ProyectoEscuela
{
  class Program
  {
    static void Main(string[] args)
    {
      var escuela = new Escuela("Escuela De Jedis", 1993, TiposEscuela.Secundaria,
                                 pais: "Colombia", ciudad: "Bogotá");

      var listaCursos = new List<Curso>();
      escuela.Cursos = new Curso[]{
                                new Curso(){Nombre = "101"},
                                new Curso(){Nombre = "201"},
                                new Curso(){Nombre = "301"}
      };
      //WriteLine(escuela);
      escuela = null;
      ImprimirCursosEscuela(escuela);
    }
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      WriteLine("===========================");
      WriteLine("CURSOS ESCUELA");
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

      WriteLine("===========================");
    }

    private static void ImprimirCursosWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      while (contador < arregloCursos.Length)
      {
        Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueID}");
        contador++;
      }
    }

    private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      do
      {
        Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueID}");
        contador++;

      } while (contador < arregloCursos.Length);
    }
    private static void ImprimirCursosFor(Curso[] arregloCursos)
    {
      for (int i = 0; i < arregloCursos.Length; i++)
      {
        Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueID}");
      }
    }
    private static void ImprimirCursosForEach(Curso[] arregloCursos)
    {
      foreach (var curso in arregloCursos)
      {
        Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueID}");
      }

    }

  }
}
