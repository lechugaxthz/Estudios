using System.Diagnostics.CodeAnalysis;

namespace Clases
{
    public class Persona
    {
        public string? Nombre { get; set; } = default;
        public int? Edad { get; set; } = default;
        public string? Ropa { get; set; } = default;

        public bool EqualsInPerson(object obj)
        {
            return obj is Persona persona && persona.Nombre == Nombre && persona.Edad == Edad;
        }
    }

    public class ComparadorDePersona : IEqualityComparer<Persona>
    {
        public bool Equals(Persona? x, Persona? y)
        {
            return
                x is Persona persona1 && y is Persona persona2 &&
                persona1.Nombre == persona2.Nombre &&
                persona1.Edad == persona2.Edad;
        }

        public int GetHashCode([DisallowNull] Persona obj)
        {
            return (int)(obj.Nombre.GetHashCode() * obj.Edad);
        }
    }

    
}