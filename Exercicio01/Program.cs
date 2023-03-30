//// Escreva um programa que receba uma frase do usuário e converta todas as palavraspara o formato &quot;Title Case&quot;, ou
// seja, todas as primeiras letras das palavras devem ser maiúsculas.
using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite aqui a sua frase:\n ");
        string fraseDoUsuario = Console.ReadLine();

        string[] palavrasFrase = fraseDoUsuario.Split(' ');

        for (int i = 0; i < palavrasFrase.Length; i++)
        {
            palavrasFrase[i] = char.ToUpper(palavrasFrase[i][0]) + palavrasFrase[i].Substring(1).ToLower();
        }

        string fraseTitleCase = string.Join(" ", palavrasFrase);
        Console.WriteLine($"\nA Frase com letras maiúsculas será: {fraseTitleCase}");
    }   
}

