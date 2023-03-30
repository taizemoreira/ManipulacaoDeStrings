//Desenvolva uma aplicação que
//troque cada letra de um texto por outra do alfabeto X posições a frente,
//onde X pode ser escolhido por você (cifra de César)
//a.Exemplo com X=2:
//b. “DIEGO” passará a ser “FKGIQ”
using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nDigite aqui o seu texto: ");
        string texto = Console.ReadLine();

        Console.Write("\nDigite o valor de X: ");
        int valorDeX = int.Parse(Console.ReadLine());

        string textoCifrado = CifraDeCesar(texto, valorDeX);

        Console.WriteLine("\nTexto original: {0}", texto);
        Console.WriteLine("\nTexto cifrado: {0}", textoCifrado);
    }

    static string CifraDeCesar(string texto, int valorDeX)
    {
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        string textoCifrado = "";

        foreach (char caracter in texto)
        {
            if (char.IsLetter(caracter))
            {
                char novoCaracter = (char)((caracter + valorDeX - 'a') % 26 + 'a');
                textoCifrado += novoCaracter;
            }
            else
            {
                textoCifrado += caracter;
            }
        }

        return textoCifrado;
    }
}
