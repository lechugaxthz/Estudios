using System;
using Clases;

namespace ConsoleAplication1
{
    public class ProgramLiterals
    {
        public static void Literals()
        {

            /* NUMERICOS */

            /* int -> <enteros> */
            int i = 5;

            /* 
                uint -> 0 + <naturales> 
                
                es necesario usar el sufijo "u" o "U" para 
                indicarle al compilador que el valor guardado 
                pertenece a uint (a pesar de indicarlo con el tipado)
                porque sinó, lo toma como un int y puede que, a ciertos
                valores, en los int no llegue y esto termine en un error
            */
            uint ui = 5U;

            /* 
                como vimos antes en 
                int // uint

                long -> <enteros>

                ulong -> <naturales>

                con la diferencia de la cantidad de memoria destinada
                al guardado de estos valores.
            */
            long l = 5L;

            ulong ul = 5ul;

            /* 
                sbyte -> entero de un solo byte (8 bits)

                va desde -128 -> 127
                el 0 lo toma dentre los positivos
            */
            sbyte sb = 127;

            /* 
                decimal -> <reales>

                es necesario usar el sufijo "m" o "M" para estos
            */
            decimal dm = 30.5m;

            /* 
                double -> <reales>

                es necesario usar el sufijo "d" o "D" para estos
            */
            double dd = 30.5d;

            /* 
                float -> <reales>

                es necesario usar el sufijo "f" o "F" para estos
            */
            float f = 30.5f;

            /* 
                tanto decimal, double, como float hacen lo mismo,
                guardan numeros decimales, con la diferencia de
                espacio de memoria utilizado

                float -> hasta 4 bytes (32 bits)
                double -> hasta 8 bytes (64 bits)
                decimal -> hasta 16 bytes (128 bits)

                si vamos a trabajar eficientemente, tenemos que saber
                rango de valores vamos a tratar.
            */


            /* CARACTERES */

            /* 
                string -> "A-Z,a-z,{<simbols>},{<numericos>}"

                se define con comillas dobles ("")
            */
            string s = "hola mundo :D";

            /* 
                char -> "A-Z,a-z,{<simbols>},{<numericos>}[0]"

                se define con comillas simples ('') de longitud 1

                no son validos los espacios vacios (' ')

                el valor default de un char es '\0'
            */
            char c = 'h';

            /* BOOLEANO */

            /* 
                bool -> {true, false}
            */
            bool b = true;
        }

    }
    /* OPERACIONES */

    public class ProgramOperators()
    {

        /* suma de numeros complejos (parte real y compleja) */
        public struct Complex
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }


            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex
                {
                    Real = c1.Real + c2.Real,
                    Imaginary = c1.Imaginary + c2.Imaginary
                };
            }

            public override readonly string ToString()
            {
                return $"{Real} + {Imaginary}";
            }
        }

        /* cadinales */
        public struct Cardinal
        {
            public double X { get; set; }
            public double Y { get; set; }

            public static Cardinal operator +(Cardinal c1, Cardinal c2)
            {
                return new Cardinal
                {
                    X = c1.X + c2.X,
                    Y = c1.Y + c2.Y
                };
            }

            public readonly double Longitud()
            {
                return Math.Sqrt(X * X + Y * Y);
            }

        }

        /* Equivalencias */
        /* 
            la igualdad entre otras formas ya la conocemos
            como entre tipos primitivos.
            pero en lo que consta a tipos no primitivos... :
        */
        /* igualdad entre clases */
        /* 
            las clases no pueden ser evaluadas por igualdad a 
            menos que sean la misma (es decir, que tengan el la
            misma direccion de memoria). si queremos comparar valores
            de las clases de por sí, debemos implementar metodos propios
            ya que por <clase 1>.Equeals(<clase 2>) no nos va a funcionar
            porque no tienen la misma direccion de memoria

            en cambio, implementar, como dije, metodos dentro de nuestra 
            <clase> que nos permita pasale una segunda <clase> para comparar
        */

    }
}