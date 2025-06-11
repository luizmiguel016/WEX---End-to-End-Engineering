using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

using Identificador_de_Transações_Suspeitas.Models;

decimal limite = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
int quantidade = int.Parse(Console.ReadLine());

var analisador = new AnalisadorDeTransacoes(limite);

for (int i = 0; i < quantidade; i++)
{
    decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    analisador.AdicionarTransacao(valor);
}

analisador.ExibirRelatorio();