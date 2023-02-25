// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using numerosparess.Entidades;
using numerosparess.Negocio;

internal class Program
{
    private static void Main(string[] args)
    {
        Numeros numeros = new Numeros();
        ClsNumeros clsnumeros = new ClsNumeros();


        Console.WriteLine("Ingresa el numero inical");
        numeros.num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el numero final");
        numeros.num2 = int.Parse(Console.ReadLine());

        ClsNumeros.Imprimirnumeros(numeros);
    }
}