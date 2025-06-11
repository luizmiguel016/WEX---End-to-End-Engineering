using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Identificador_de_Transações_Suspeitas.Models
{
    public class AnalisadorDeTransacoes
    {
        public decimal Limite { get; set; }
        // TODO: Crie a lista para armazenar as transações realizadas:
        public List<decimal> Transacoes = new List<decimal>();

        public AnalisadorDeTransacoes(decimal limite)
        {
            Limite = limite;
            Transacoes = new List<decimal>();
        }

        public void AdicionarTransacao(decimal valor)
        {
            // TODO: adicione a transação à lista Transacoes
            Transacoes.Add(valor);
        }

        public List<decimal> ObterTransacoesSuspeitas()
        {
            // TODO: retorne as transações que são superiores ao limite
            return Transacoes.Where(t => t > Limite).ToList();
        }

        public void ExibirRelatorio()
        {
            var suspeitas = ObterTransacoesSuspeitas();

            // TODO: Implemente a condição if para retornar uma mensagem informando que não há transações suspeitas:
            if (suspeitas.Count == 0)
            {
                Console.WriteLine("Nenhuma transação suspeita");
            }

            else
            {
                decimal totalSuspeitas = suspeitas.Sum();
                int numeroSuspeitas = suspeitas.Count();

                string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

                // TODO: imprima o total das transações suspeitas com duas casas decimais
                // e a quantidade de transações suspeitas
                Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
            }
        }
    }
}