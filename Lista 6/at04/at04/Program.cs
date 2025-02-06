using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma data: ");
                string data = Console.ReadLine();
                DateTime dataPessoa = DateTime.Parse(data);
                if (feriadoConfere(dataPessoa)){
                    Console.WriteLine("A data informada é um feriado nacional.");
                }else{
                    Console.WriteLine("A data informada não é um feriado nacional.");
                }
                Console.ReadKey(true);
			}

            static bool feriadoConfere(DateTime data){
                string dataFormatada = data.ToString("dd/MM");
            
                switch (dataFormatada){
                    case "01/01": // Ano novo
                    case "21/04": // Tiradentes
                    case "01/05": // Dia do Trabalho
                    case "07/09": // Independência do Brasil
                    case "12/10": // Nossa Senhora Aparecida
                    case "02/11": // Finados
                    case "15/11": // Proclamação da República
                    case "25/12": // Natal
                        return true;
                    default:
                        return false;
                    }
            }
	}
}
