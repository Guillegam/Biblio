using System;
using System.Collections.Generic;

namespace BibliotecFsa.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public int IdAutor { get; set; }

    public int IdCategoria { get; set; }

    public short Publicacion { get; set; }

    public string? Estado { get; set; }

    public virtual Autore IdAutorNavigation { get; set; } = null!;

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
