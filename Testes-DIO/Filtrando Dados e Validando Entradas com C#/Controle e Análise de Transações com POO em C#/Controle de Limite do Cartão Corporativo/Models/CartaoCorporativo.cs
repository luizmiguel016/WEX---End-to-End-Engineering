
using System.Globalization;

namespace ControleDeLimiteDoCartaoCorporativo.Models
{
    public class CartaoCorporativo
    {
        public decimal Limite { get; }
        public List<decimal> Transacoes { get; }

        public CartaoCorporativo(decimal limite)
        {
            Limite = limite;
            Transacoes = new List<decimal>();
        }

        public void AdicionarTransacao(decimal valor)
        {
            Transacoes.Add(valor);
        }

        public decimal CalcularTotal()
        {
            return Transacoes.Sum();
        }

        public bool UltrapassouLimite()
        {
            return CalcularTotal() > Limite;
        }

        public void ExibirResumo()
        {
            decimal total = CalcularTotal();
            Console.WriteLine("Total gasto: " + total.ToString("F2", CultureInfo.InvariantCulture));

            if (UltrapassouLimite())
            {
                Console.WriteLine("Limite ultrapassado");
            }
            else
            {
                Console.WriteLine("Limite OK");
            }
                
        }
    }
}