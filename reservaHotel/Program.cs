using System;
using System.Globalization;
using reservaHotel;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Bem vindo ao Hotel Hello World!");
		Console.WriteLine("================================================");
		Console.WriteLine();

		// Quantidade pessoas que irão se hospedar

		Console.Write("Digite a quantidade de Hospedes: ");
		int quantidadeHospedes = int.Parse(Console.ReadLine());

		List<Pessoa> hospedesCadastrados = new List<Pessoa>(); // Uma lista que irá armazenar duas ou mais pessoas.

		for (int inicio = 0; inicio < quantidadeHospedes; inicio++)
		{
			// Cria os hospedes e cadastra

			Console.Clear();

			Console.Write("Primeiro Nome: ");
			string nome = Console.ReadLine();

			Console.Write("Sobrenome: ");
			string sobrenome = Console.ReadLine();

			Console.WriteLine();

			Pessoa nomeHospedes = new Pessoa(nome, sobrenome);

			hospedesCadastrados.Add(nomeHospedes); // Adicionaremos o nome e sobrenome dos hospedes na lista.

		}

		// Cadastra o tipo de suite

		Console.Clear();
		Console.WriteLine("Qual o tipo de Suíte? ");
		Console.WriteLine();

		Console.WriteLine("1 - Standard | Capacidade: 4 Pessoas. R$ 30.00 por dia.");
		Console.WriteLine("2 - Deluxe | Capacidade: 8 Pessoas. R$ 70.00 por dia.");
		Console.WriteLine("3 - Premium | Capacidade 15 pessoas R$ 110.00 por dia.");

		Console.WriteLine();

		Console.Write("Digite sua opção: "); // Escolha do usuário
		Suite escolhaSuite = new Suite();


		escolhaSuite.Opcao = int.Parse(Console.ReadLine());

		switch (escolhaSuite.Opcao)
		{
			case 1:
				escolhaSuite = new Suite("Standard", 4, 30.00M, 1);
				break;

			case 2:

				escolhaSuite = new Suite("Deluxe", 8, 70.00M, 2);
				break;
			case 3:

				escolhaSuite = new Suite("Premium", 15, 110.00M, 3);
				break;


		}

		Console.Write("Quantos dias você ficará hospedado? "); // Irá capturar a quantidade de dias hospedados
		int diasHospedados = int.Parse(Console.ReadLine());


		Reserva reservaHotel = new Reserva(hospedesCadastrados, escolhaSuite, diasHospedados); // Classe: reserva.

		reservaHotel.cadastrarHospedes(hospedesCadastrados); // Método Hospedes cadastrados da classe reserva.
		reservaHotel.cadastrarSuite(escolhaSuite); // Método cadastrar suíte da classe reserva.



		// Exibe a quantidade de hóspedes e o valor da diária:


		if (escolhaSuite.Capacidade >= reservaHotel.quantidadeHospedes(hospedesCadastrados))
		{
			Console.WriteLine("================================================");
			Console.WriteLine();

			Console.WriteLine("Nome dos Hospedes:");


			foreach (Pessoa nome in hospedesCadastrados) // Listando o nome dos Hospedes cadastrados.
			{
				Console.WriteLine($"> {nome.Nome} {nome.Sobrenome}");

			}

			Console.WriteLine();


			Console.WriteLine($">> Quantidade de Hospedes: {reservaHotel.quantidadeHospedes(hospedesCadastrados)}"); // quantidade de Hospedes
			Console.WriteLine($">> Suíte: {escolhaSuite.tipoSuite}, Capacidade {escolhaSuite.Capacidade}, Valor da diária R${escolhaSuite.Diaria}"); // Informações sobre o quarto
			Console.WriteLine($">> Dias Hospedados {diasHospedados} | Total R${reservaHotel.calcularDiaria(diasHospedados).ToString("f2")}");


		}

		Console.WriteLine();
		Console.WriteLine("================================================");

















	}
























}
