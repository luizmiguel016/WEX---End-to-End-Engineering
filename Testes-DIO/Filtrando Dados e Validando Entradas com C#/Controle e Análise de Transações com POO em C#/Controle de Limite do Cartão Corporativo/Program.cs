using System.Globalization;
using ControleDeLimiteDoCartaoCorporativo.Models;

decimal limite = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int quantidade = int.Parse(Console.ReadLine());

var cartao = new CartaoCorporativo(limite);

for (int i = 0; i < quantidade; i++)
{
    decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    cartao.AdicionarTransacao(valor);
}

cartao.ExibirResumo();