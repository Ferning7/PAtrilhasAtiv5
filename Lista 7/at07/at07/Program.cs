
using System;

namespace at07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro positivo: ");
			int num = int.Parse(Console.ReadLine());
			int i = 0;
			int numPar = 0;
			
			do{
				if(i % 2 == 0){
					Console.WriteLine(i);
				}
				i++;
			} while (i <= num);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}