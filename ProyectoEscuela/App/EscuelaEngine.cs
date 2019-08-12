using System.Collections.Generic;
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

      Escuela.Cursos = new List<Curso>(){
                                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                                new Curso{Nombre = "401", Jornada = TiposJornada.Tarde},
                                new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
        };

    }
  }
}