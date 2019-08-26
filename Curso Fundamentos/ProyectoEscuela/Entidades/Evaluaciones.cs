using System;

namespace ProyectoEscuela.Entidades
{
  public class Evaluaciones
  {
    public string Nombre { get; set; }
    public string UniqueID { get; private set; }
    public Alumno Alumno { get; set; }
    public Asignatura Asignatura { get; set; }
    public float Nota { get; set; }
    public Evaluaciones() => UniqueID = Guid.NewGuid().ToString();
  }
}