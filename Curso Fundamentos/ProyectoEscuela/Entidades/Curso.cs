using System;
using System.Collections.Generic;

namespace ProyectoEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniqueID { get; private set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public List<Evaluaciones> Evaluaciones{ get; set; }
        public Curso() => UniqueID = Guid.NewGuid().ToString();
        
    }
}