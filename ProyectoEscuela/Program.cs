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

      escuela.Cursos = new List<Curso>(){
                                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana}
      };

      escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
      escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });
      var otraListaCursos = new List<Curso>(){
                                new Curso{Nombre = "401", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "501", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "502", Jornada = TiposJornada.Tarde}
       };

      escuela.Cursos.AddRange(otraListaCursos);

      escuela.Cursos.RemoveAll(delegate (Curso cur)
                                    {
                                      return cur.Nombre == "301";
                                    });
      escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);

      ImprimirCursosEscuela(escuela);
    }
    private static bool Predicado(Curso CurObj)
    {
      return CurObj.Nombre == "301";
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
