
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número inteiro: ");
			int num = int.Parse(Console.ReadLine());
			
			
			int i = 1;
			Console.WriteLine("Tabuada do {0}", num);
			do{
				
				Console.WriteLine("{0} x {1} = {2}", num, i, num*i);
				i++;
			}while (i <= 10);
					Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
		}
	}