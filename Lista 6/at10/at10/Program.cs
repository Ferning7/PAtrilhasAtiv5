
using System;

namespace at10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escolha um tamanho de camiseta: P, M, G");
			char tamanho = char.Parse(Console.ReadLine());
			
			int size = 0;
			if (tamanho == 'P' || tamanho == 'p') {
				size = 1;
			} else if (tamanho == 'M' || tamanho == 'm') {
				size = 2;
			} else if (tamanho == 'G' || tamanho == 'g') {
				size = 3;
			}
			
			
			switch (size) {
				case 1:
					Console.WriteLine("Tamanho Pequeno");
					break;
				case 2:
					Console.WriteLine("Tamanho Médio");
					break;
				case 3:
					Console.WriteLine("Tamanho Grande");
					break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}