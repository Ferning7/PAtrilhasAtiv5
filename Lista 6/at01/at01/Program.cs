
using System;

namespace at01
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime dataH = DateTime.Now;
			
			Console.WriteLine("Data atual: " + dataH.ToString("dd/MM/yyyy"));
			Console.WriteLine("Hora atual: "+dataH.ToString("HH:mm:ss"));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}