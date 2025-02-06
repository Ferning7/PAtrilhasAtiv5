
using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Crie uma nova senha: ");
			int senha = int.Parse(Console.ReadLine());
			
			int senhaTentativa;
			int tentativas = 3;
			
			while (tentativas != 0) {
				Console.WriteLine("Digite a senha: ");
				senhaTentativa = int.Parse(Console.ReadLine());
				
				if (senhaTentativa != senha) {
					tentativas--;
					Console.WriteLine("Senha incorreta! {0} tentativas restantes.", tentativas);
				} else {
					Console.WriteLine("Acesso concedido!");
					break;
				}
			}
			if (tentativas == 0) {
				Console.WriteLine("Acesso Negado.");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}