using System;
using System.Collections.Generic;

namespace BibliotecFsa.Models;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int IdLibro { get; set; }

    public int IdUsuario { get; set; }

    public DateOnly Prestamo1 { get; set; }

    public DateOnly Devolucion { get; set; }

    public string? Estado { get; set; }

    public virtual Libro IdLibroNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
