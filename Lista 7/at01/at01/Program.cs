
using System;

namespace at01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int x = int.Parse(Console.ReadLine());
			
			int i = 0;
			
			Console.WriteLine("Valores pares de 0 à {0}", x);
			while (i <= x) {
				if (i%2 == 0) {
					Console.WriteLine(i);
				}
				i++;
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}