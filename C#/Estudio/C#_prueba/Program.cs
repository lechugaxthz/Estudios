
using Clases;
using static ConsoleAplication1.ProgramOperators;

namespace RootProgram
{
    public class Root
    {
        public static void Main()
        {
            Console.WriteLine(Convert.ToInt64("00111100", 2).ToString());

            Console.WriteLine("Op compleja ?");
            string? response1 = Console.ReadLine();
            if (!string.IsNullOrEmpty(response1) && "si".Equals(response1.ToLower()))
            {
                Console.WriteLine("indica valor real e imaginario (con enter de por medio)\n");
                double r1 = Convert.ToDouble(Console.ReadLine());
                double i1 = Convert.ToDouble(Console.ReadLine());
                Complex a = new() { Real = r1, Imaginary = i1 };

                Console.WriteLine("indica valor real e imaginario (con enter de por medio) de la segunda variable\n");
                double r2 = Convert.ToDouble(Console.ReadLine());
                double i2 = Convert.ToDouble(Console.ReadLine());
                Complex b = new() { Real = r2, Imaginary = i2 };

                Complex c = a + b;

                Console.WriteLine($"la respuesta es {c.Real} + {c.Imaginary}i");
            }

            Console.WriteLine("Op de cardinales ?");
            string? response2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(response2) && "si".Equals(response2.ToLower()))
            {
                Console.WriteLine("indica valor de X e Y (con enter de por medio)\n");
                double r1 = Convert.ToDouble(Console.ReadLine());
                double i1 = Convert.ToDouble(Console.ReadLine());
                Cardinal a = new() { X = r1, Y = i1 };

                Console.WriteLine("indica valor X e Y (con enter de por medio) de la segunda variable\n");
                double r2 = Convert.ToDouble(Console.ReadLine());
                double i2 = Convert.ToDouble(Console.ReadLine());
                Cardinal b = new() { X = r2, Y = i2 };

                Cardinal c = a + b;

                Console.WriteLine($"la respuesta es ({c.X} , {c.Y})\nDe longitud {c.Longitud()}");
            }


            /* Equivalencias */
            Persona lechu1 = new() { Nombre = "Lautaro", Edad = 24, Ropa = "alguna prenda" };
            Persona lechu2 = new() { Nombre = "Lautaro", Edad = 24, Ropa = "alguna prenda" };
            Persona scarlette = new() { Nombre = "Scarlette", Edad = 20, Ropa = "alguna prenda" };

            /* 
                si bien vemos que tienen (lechu 1 y 2) los mismos valores,
                en cuanto a punteros, tienen direcciones diferentes
            */
            Console.WriteLine($"lechu1 es igual a lechu2 (con Equals)? {lechu1.Equals(lechu2)}\n"); // falso

            /* 
                En cambio si vemos la clase, hemos hecho una método el cual
                compara los valores internos de cada uno (exeptuando la ropa)
                para ver si son la misma persona
            */
            Console.WriteLine($"lechu1 es igual lechu2 (con método)? {lechu1.EqualsInPerson(lechu2)}\n"); // true
            Console.WriteLine($"lechu1 es igual scarlette (con método)? {lechu1.EqualsInPerson(scarlette)}\n"); // falso
                                                                                                                // este ultimo da falso porqeu no son la misma persona.


        }
    }
}