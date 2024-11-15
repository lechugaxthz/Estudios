
namespace valorDeFuncion
{
    public class Root
    {
        public static void Main()
        {
            Console.WriteLine("Escribe dos numero entero para dar el rango de valores de la siguiente funcon f(x) = x^2 - 2x + 1");

            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(X1, X2).Select(X => X * (X - 2) + 1).ToList().ToString());

            Console.WriteLine(string.Join(" ", Enumerable.Range(X1, X2 - X1 + 1).Select(X => X * (X - 2) + 1).ToList()));
        }
    }
}