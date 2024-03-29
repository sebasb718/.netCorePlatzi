using System;
using System.Collections.Generic;

namespace ProyectoEscuela.Entidades
{
  public class Escuela
  {
    public string UniqueID { get; private set; } = Guid.NewGuid().ToString();
    private string nombre;
    public string Nombre
    {
      get { return "La Escuela es: " + nombre; }
      set { nombre = value.ToUpper(); }
    }
    public int AñoCreacion { get; set; }
    public string Pais { get; set; }
    public string Ciudad { get; set; }
    public TiposEscuela TipoEscuela { get; set; }
    public List<Curso> Cursos { get; set; }

    public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

    public Escuela(string nombre, int año, TiposEscuela tipos, string pais = "", string ciudad = "")
    {
      (Nombre, AñoCreacion) = (nombre, año);
      TipoEscuela = tipos;
      Pais = pais;
      Ciudad = ciudad;
    }

    public override string ToString()
    {
      return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
    }

  }
}