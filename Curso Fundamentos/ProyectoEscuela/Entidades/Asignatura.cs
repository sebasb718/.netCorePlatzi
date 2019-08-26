using System;

namespace ProyectoEscuela.Entidades
{
  public class Asignatura
  {
    public string Nombre { get; set; }
    public string UniqueID { get; private set; }
    public Asignatura() => UniqueID = Guid.NewGuid().ToString();
  }
}