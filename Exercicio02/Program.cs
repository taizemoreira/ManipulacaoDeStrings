//Dada uma string contendo uma frase, escreva um programa em C# que conte o número de palavras na frase e
//imprima o resultado.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nDigite aqui a sua frase:");
        string fraseDoUsuario = Console.ReadLine();

        int numeroDePalavras = fraseDoUsuario.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.Write("");
        Console.WriteLine("\nA frase digitada possui {0} palavra(s).", numeroDePalavras);
    }
}
