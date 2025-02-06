
using System;

namespace at06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Insira um número: ");
			int num = int.Parse(Console.ReadLine());
			
			
			int decisao;
			if (num == 0) {
				decisao = 0;
			}else if (num > 0) {
				decisao = 1;
			} else{
				decisao = 2;
			}
			
		
			
			switch(decisao){
				case 0:
					Console.WriteLine("Zero");
					break;
				case 1:
					Console.WriteLine("Positivo");
					break;
				case 2:
					Console.WriteLine("Negativo");
					break;
					
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}