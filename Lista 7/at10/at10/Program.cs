
using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num = 0;
			int soma = 0;
			Console.WriteLine("Digite números inteiros: ");
			num = int.Parse(Console.ReadLine());
			
			do{
			soma += num;
				
				if (num < 0) {
					num = 0;
				}
				num = int.Parse(Console.ReadLine());
			}while (num >= 0); 
				
			Console.WriteLine("\nNúmero negativo inserido!\n");
			Console.WriteLine("Soma dos números inseridos (exceto negativo): {0}", soma);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}