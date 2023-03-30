//Crie um programa em C# que solicite ao usuário que digite uma frase. [x]
//Em seguida, o programa deve utilizar métodos da classe string para realizar as seguintes operações:
//--> Imprimir a frase em letras maiúsculas; [x]
//--> Imprimir a frase em letras minúsculas; [x]
//--> Imprimir a quantidade de caracteres da frase; [x]
//--> Imprimir a primeira palavra da frase; [x]
//--> Imprimir a última palavra da frase. [x]
using System;

class Program
{
    static void Main()
    {
        // Solicita que o usuário digite uma frase
        Console.Write("Digite aqui a sua frase: ");
        string frase = Console.ReadLine();

        // Imprime a frase em letras maiúsculas
        Console.WriteLine("Frase em letras maiúsculas: {0}", frase.ToUpper());

        // Imprime a frase em letras minúsculas
        Console.WriteLine("Frase em letras minúsculas: {0}", frase.ToLower());

        // Imprime a quantidade de caracteres da frase
        Console.WriteLine("Quantidade de caracteres da frase: {0}", frase.Length);

        // Separa a primeira palavra da frase
        string[] palavras = frase.Split(' ');
        string primeiraPalavra = palavras[0];

        // Imprime a primeira palavra da frase
        Console.WriteLine("Primeira palavra da frase: {0}", primeiraPalavra);

        // Separa a última palavra da frase
        string ultimaPalavra = palavras[palavras.Length - 1];

        // Imprime a última palavra da frase
        Console.WriteLine("Última palavra da frase: {0}", ultimaPalavra);
    }
}
