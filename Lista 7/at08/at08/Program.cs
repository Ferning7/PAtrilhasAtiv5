
using System;

namespace at03
{
	class Program
	{
		public static void Main(string[] args)
		{
			int nums, total = 0;
			string i = "";
			
			do{
				Console.WriteLine("Insira um número inteiro:");
				nums = int.Parse(Console.ReadLine());
				total += nums;
				
				Console.WriteLine("Aperte 's' para finalizar, ou qualquer letra para continuar: ");
				i = Console.ReadLine().ToLower();
				
				
				
			}while (i != "s");
			Console.WriteLine("A soma dos números inseridos: {0}", total);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}