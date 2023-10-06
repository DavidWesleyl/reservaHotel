using System;


namespace reservaHotel
{
	internal class Suite
	{
		public string tipoSuite { get; set; }
		public int Capacidade { get; set; }
		public decimal Diaria { get; set; }
        public int Opcao { get; set; } // O parametro opção não será exatamente um parâmetro, irá servir apenas para identificar o tipo de quarto no programa principal.


		public Suite()
		{

		}

		public Suite(string tiposuite, int capacidade, decimal diaria, int opcao)
		{
			tipoSuite = tiposuite;
			Capacidade = capacidade;
			Diaria = diaria;
			int Opcao = opcao; 
		}



	}
}
