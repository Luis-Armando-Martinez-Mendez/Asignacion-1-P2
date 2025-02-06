using System;
using System.Collections.Generic;

// Clase base
class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public MiembroDeLaComunidad(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Tipo: {GetType().Name}");
    }
}

// Clases derivadas
class Empleado : MiembroDeLaComunidad
{
    public Empleado(string nombre) : base(nombre) { }
}

class Estudiante : MiembroDeLaComunidad
{
    public Estudiante(string nombre) : base(nombre) { }
}

class ExAlumno : MiembroDeLaComunidad
{
    public ExAlumno(string nombre) : base(nombre) { }
}

// Subclases de Empleado
class Docente : Empleado
{
    public Docente(string nombre) : base(nombre) { }
}

class Administrativo : Empleado
{
    public Administrativo(string nombre) : base(nombre) { }
}

// Subclases de Docente
class Administrador : Docente
{
    public Administrador(string nombre) : base(nombre) { }
}

class Maestro : Docente
{
    public Maestro(string nombre) : base(nombre) { }
}

// prueba
class Program
{
    static void Main()
    {
        List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>
        {
            new Estudiante("Carlos"),
            new ExAlumno("Maria"),
            new Administrador("Pedro"),
            new Maestro("Lucia"),
            new Administrativo("Jorge")
        };

        foreach (var miembro in miembros)
        {
            miembro.MostrarInfo();
        }
    }
}
