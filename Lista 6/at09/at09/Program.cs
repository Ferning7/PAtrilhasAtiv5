
using System;

namespace at09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número de 1 a 7 para imprimir um dia");
			int num = int.Parse(Console.ReadLine());
			
			
			int dia = 0;
			
			if (num == 1) {
				dia = 1;
			} else if (num == 2) {
				dia = 2;
			} else if (num == 3) {
				dia = 3;
			} else if (num == 4) {
				dia = 4;
			} else if (num == 5) {
				dia = 5;
			} else if (num == 6) {
				dia = 6;
			} else if (num == 7) {
				dia = 7;
			}
			
			switch (dia) {
				case 1:
					Console.WriteLine("Segunda-Feira");
					break;
				case 2:
					Console.WriteLine("Terça-Feira");
					break;
				case 3:
					Console.WriteLine("Quarta-Feira");
					break;
				case 4:
					Console.WriteLine("Quinta-Feira");
					break;
				case 5:
					Console.WriteLine("Sexta-Feira");
					break;
				case 6:
					Console.WriteLine("Sábado");
					break;
				case 7:
					Console.WriteLine("Domingo");
					break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
