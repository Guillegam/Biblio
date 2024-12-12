using System;
using System.Collections.Generic;

namespace BibliotecFsa.Models;

public partial class Autore
{
    public int IdAutor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
