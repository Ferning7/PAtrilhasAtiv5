
using System;

namespace at5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escolha uma opção abaixo:");
			Console.Write("1)\n2)\n3)\n");
			int escolha = int.Parse(Console.ReadLine());
			
			switch (escolha) {
				case 1:
					Console.WriteLine("Opção 1");
					break;
				case 2:
					Console.WriteLine("Opção 2");
					break;
				case 3: 
					Console.WriteLine("Opção 3");
					break;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}