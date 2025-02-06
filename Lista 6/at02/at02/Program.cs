
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime data1 = new DateTime(2005, 03, 07);
			DateTime data2 = new DateTime(2025, 03, 07);
			TimeSpan diferenca = data2 - data1;
			
			Console.WriteLine("Diferença em dias: " + diferenca.TotalDays);
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}