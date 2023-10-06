using System;

namespace reservaHotel
{
	internal class Reserva
	{
		public List<Pessoa> Hospede { get; set; } = new List<Pessoa>(); // Uma lista que irá armazenas um ou mais hospedes. 
		public Suite Suite { get; set; } // Classe do Tipo Suite
		public int diasReservados { get; set; }

		public Reserva(List<Pessoa> hospede, Suite suite, int diasreservados)
		{
			Hospede = hospede;
			this.Suite = suite;
			diasReservados = diasreservados;

		}

		public void cadastrarHospedes(List<Pessoa> cadastroHospedes)
		{
			// Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

			if (Suite.Capacidade >= Hospede.Count) // Se a capacidade de pessoas da Suite for maior que a de Hóspedes.
			{
				Console.WriteLine();
				Console.WriteLine("Tudo certo! Aguarde.."); // Mostre:

			}

			else
			{
				Console.WriteLine(); // Se não: 
				Console.WriteLine("Capacidade insuficiente! O numero de hospedes é maior que o suportado.");
			}



		}

		public void cadastrarSuite(Suite cadastroSuite) // Método Cadastrar Suite
		{
			Suite = cadastroSuite;

		}

		public int quantidadeHospedes(List<Pessoa> hospedes) // Contador de Hospedes
		{

			return Hospede.Count;
		}

		public decimal calcularDiaria(int diaria)
		{
			// TO DO: Retorna o valor da diária

			decimal valor = diasReservados * Suite.Diaria;


			// Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

			if (diasReservados >= 10)
			{
				decimal Desconto = valor - (valor * 0.10M);
				Console.WriteLine();

				Console.WriteLine("Desconto de 10% aplicado por se hospedar 10 dias ou mais conosco..");
                Console.WriteLine();
                
				return Desconto;
			}
			else
			{
				return valor;
			}


		}


	}
}
