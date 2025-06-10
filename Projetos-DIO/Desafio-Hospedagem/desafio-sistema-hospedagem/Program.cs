using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Nome do hóspede 1", sobrenome: "Sobrenome do hóspede 1");
Pessoa p2 = new Pessoa(nome: "Nome do hóspede 2", sobrenome: "Sobrenome do hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 10);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe o tipo da suíte, quantidade de hóspedes, o nome de cada hóspede e o valor da diária
Console.WriteLine(reserva.ExibirSuite());
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
reserva.ObterNomeHospedes();
Console.WriteLine($"Valor reserva: {reserva.CalcularValorDiaria()}");