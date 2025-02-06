using System;

namespace at03
{
	class Program
	{
		public static void Main(string[] args)
		{
			// entrada de dados
			Console.WriteLine("Digite sua data de nascimento dd/MM/yyyy");
			string dataNascTexto =  Console.ReadLine();
			
			DateTime dataNasc;
			DateTime dataAtual = DateTime.Now;
			
			//converte de string para DateTime
			bool conversor = DateTime.TryParse(dataNascTexto, out dataNasc);
			
			// calcula a idade
			int idade = dataAtual.Year - dataNasc.Year;
			
			Console.WriteLine("\nData de nascimento: " + dataNasc.ToString("dd/MM/yyyy"));
			Console.WriteLine("Data de hoje: " + dataAtual.ToString("dd/MM/yyyy"));
			
			// Calcula os meses e dias para subtrair um ano
			if(dataAtual.Month < dataNasc.Month || (dataAtual.Month == dataNasc.Month && dataAtual.Day < dataNasc.Day)){
				idade--;
			}
			// saída de dados
			Console.WriteLine("Você tem {0} anos", idade);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}