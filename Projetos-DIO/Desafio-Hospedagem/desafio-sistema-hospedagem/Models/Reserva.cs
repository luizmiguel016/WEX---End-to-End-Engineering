using System.Diagnostics.Contracts;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        /// <summary>
        /// Cadastrar hóspedes, mas com a regra de não exceder o limite da capacidade da suíte.
        /// </summary>
        /// <param name="hospedes"> Lista de hóspedes cadastrados na reserva.</param>
        /// <exception cref="ArgumentOutOfRangeException">Caso a capacidade exceda, será disparado que o limite foi violado.</exception>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Você tentou reservar uma suíte de {Suite.Capacidade} para {hospedes.Count}. " +
                                                      $"Favor, escolha outra suíte.");
            }
        }

        /// <summary>
        /// Cadastro da suíte no sistema.
        /// </summary>
        /// <param name="suite">Tipo da suíte, capacidade e o valor da diária.</param>
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public string ExibirSuite()
        {
            return $"Tipo da suíte: {Suite.TipoSuite}, Capacidade: {Suite.Capacidade}, Valor diária: {Suite.ValorDiaria}";
        }

        /// <summary>
        /// Imprime um relatório de quantos hóspedes estão cadastrados na reserva.
        /// </summary>
        /// <returns>Retorna a quantidade de hóspedes.</returns>
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        /// <summary>
        /// Exibir nome dos hóspedes inclusos na reserva.
        /// </summary>
        public void ObterNomeHospedes()
        {
            int hospede = 0;

            foreach (Pessoa nomes in Hospedes)
            {
                hospede++;
                Console.WriteLine($"{hospede}º Hóspede: {nomes.NomeCompleto}");
            }
        }

        /// <summary>
        /// Calcula o valor da diária. Caso os dias sejam maior ou igual a 10, conceder um desconto de 10%.
        /// </summary>
        /// <returns>Valor das diárias.</returns>
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor * 10 / 100;
            }

            return valor;
        }
    }
}