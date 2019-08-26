using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ProyectoEscuela.Entidades;

namespace ProyectoEscuela
{
  public class EscuelaEngine
  {
    public Escuela Escuela { get; set; }

    public void Inicializar()
    {
      Escuela = new Escuela("Escuela De Jedis", 1993, TiposEscuela.Primaria,
                               pais: "Colombia", ciudad: "Bogotá");
      CargarCursos();
      CargarAsignaturas();
      CargarEvaluaciones();
    }

    private void CargarEvaluaciones()
    {
      var listaEvaluaciones = new List<Evaluación>();
      foreach (var curso in Escuela.Cursos)
      {
        foreach (var asignatura in curso.Asignaturas)
        {
          string[] nombreEval = { "Quiz", "Test 1", "Parcial", "Final", "Recuperación", "Fin Curso" };
          Random rnd = new Random();
          foreach (var alumno in curso.Alumnos)
          {
            for (int i = 0; i < 5; i++)
            {
              double rndNota = rnd.NextDouble() * 5.0;
              int rndNombre = rnd.Next(0, nombreEval.Length - 1);
              Evaluación evaluacion = new Evaluación
              {
                Nombre = nombreEval[rndNombre],
                Asignatura = asignatura,
                Nota = Convert.ToSingle(Math.Round(rndNota, 1))
              };
              listaEvaluaciones.Add(evaluacion);
            }
          }
        }
      }
    }

    private void CargarAsignaturas()
    {
      foreach (var curso in Escuela.Cursos)
      {
        List<Asignatura> listaAsignaturas = new List<Asignatura>(){
          new Asignatura{Nombre = "Matematicas"},
          new Asignatura{Nombre = "Ciencias"},
          new Asignatura{Nombre = "Español"},
          new Asignatura{Nombre = "Educación física"},
          new Asignatura{Nombre = "Sociales"}
        };
        curso.Asignaturas = listaAsignaturas;
      }
    }

    private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
    {
      string[] nombre1 = { "Juan", "Andres", "Miguel", "Daniel", "Jose", "Ivan" };
      string[] nombre2 = { "Sebatian", "Felipe", "Alberto", "Augusto", "Pancracio", "Albeiro" };
      string[] apellido = { "Bernal", "Fonseca", "Chacon", "Alvarez", "Cubides", "Florez" };

      var listaDeAlumnos = from n1 in nombre1
                           from n2 in nombre2
                           from a1 in apellido
                           select new Alumno { Nombre = $"{n1} {n2} {a1}" };

      return listaDeAlumnos.OrderBy((al) => al.UniqueID).Take(cantidad).ToList();
    }

    private void CargarCursos()
    {
      Escuela.Cursos = new List<Curso>(){
                                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "401", Jornada = TiposJornada.Tarde},
                                new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
      };
      Random rnd = new Random();
      foreach (var curso in Escuela.Cursos)
      {
        int cantRandom = rnd.Next(5, 20);
        curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
      }
    }
  }
}