//Desenvolva um programa em C# que leia o arquivo cidades.csv e dê a possibilidade de apresentar as cidades agrupadas pela primeira letra ou pelo estado que pertence.
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = "Cidades.csv";
            char separador = ';';
            Dictionary<string, List<string>> cidadesPorLetra = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> cidadesPorEstado = new Dictionary<string, List<string>>();

            using (StreamReader sr = new StreamReader(arquivo))
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] campos = linha.Split(separador);
                    string nome = campos[0];
                    string estado = campos[1];

                    // Agrupa as cidades por letra inicial
                    string letraInicial = nome.Substring(0, 1).ToUpper();
                    if (!cidadesPorLetra.ContainsKey(letraInicial))
                    {
                        cidadesPorLetra[letraInicial] = new List<string>();
                    }
                    cidadesPorLetra[letraInicial].Add(nome);

                    // Agrupa as cidades por estado
                    if (!cidadesPorEstado.ContainsKey(estado))
                    {
                        cidadesPorEstado[estado] = new List<string>();
                    }
                    cidadesPorEstado[estado].Add(nome);
                }
            }

            // Apresenta as cidades agrupadas por letra inicial
            Console.WriteLine("Cidades agrupadas por letra inicial:");
            foreach (string letraInicial in cidadesPorLetra.Keys)
            {
                Console.WriteLine($"{letraInicial}:");
                foreach (string cidade in cidadesPorLetra[letraInicial])
                {
                    Console.WriteLine($"  - {cidade}");
                }
            }

            // Apresenta as cidades agrupadas por estado
            Console.WriteLine("Cidades agrupadas por estado:");
            foreach (string estado in cidadesPorEstado.Keys)
            {
                Console.WriteLine($"{estado}:");
                foreach (string cidade in cidadesPorEstado[estado])
                {
                    Console.WriteLine($"  - {cidade}");
                }
            }

            Console.ReadKey();
        }
    }
}
