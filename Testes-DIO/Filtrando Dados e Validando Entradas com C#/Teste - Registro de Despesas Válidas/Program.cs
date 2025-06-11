using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<int> despesas = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > 0)
            {
                despesas.Add(valor);
            }

        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {
            foreach (int valor in despesas)
            {
                Console.WriteLine(valor);
            }

        }
    }
}