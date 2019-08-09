using System;

namespace ProyectoEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniqueID { get; private set; }
        public TiposJornada Jornada { get; set; }

        public Curso() => UniqueID = Guid.NewGuid().ToString();
        
    }
}