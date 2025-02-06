
using System;

namespace at07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escolha uma cor: ");
			Console.WriteLine("Vermelho\nAzul\nVerde\n");
			string cor = Console.ReadLine();
			
			int escolha = 0;
			
			if (cor.ToLower() == "vermelho") {
				escolha = 1;
			} else if (cor.ToLower() == "azul") {
				escolha = 2;
			} else if (cor.ToLower() == "verde") {
				escolha = 3;
			}
			
			switch (escolha) {
				case 1:
					Console.WriteLine("Cor: Vermelho");
					break;
				case 2: 
					Console.WriteLine("Cor: Azul");
					break;
				case 3:
					Console.WriteLine("Cor: Verde");
					break;
				default: 
					Console.WriteLine("Inválido");
					break;
			} 
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}