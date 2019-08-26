using System;

namespace ProyectoEscuela.Entidades
{
  public class Alumno
  {
    public string Nombre { get; set; }
    public string UniqueID { get; private set; }
    public Alumno() => UniqueID = Guid.NewGuid().ToString();
  }
}