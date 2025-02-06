
using System;

namespace at08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma letra");
			char letra = char.Parse(Console.ReadLine());
			
			int vogal = 0;
			
			if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u') {
				vogal = 0;
				
			} else {
				vogal = 1;
			}
			
			switch (vogal) {
				case 0:
					Console.WriteLine("Vogal");
					break;
				case 1:
					Console.WriteLine("Consoante");
					break;
			}
			
			
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}