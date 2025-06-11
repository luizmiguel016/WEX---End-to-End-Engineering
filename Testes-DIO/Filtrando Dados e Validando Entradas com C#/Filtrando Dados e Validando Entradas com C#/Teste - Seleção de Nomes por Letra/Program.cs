using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string linhaDeNomes = Console.ReadLine();

        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine());

        List<string> filtrados = nomes
            .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (filtrados.Count == 0)
        {
            Console.WriteLine("Nenhum nome encontrado");
        }
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}