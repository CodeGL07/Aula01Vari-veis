using System;

namespace Aula01Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcaternarPalavras();
            VerificarAulaEtec();
        }

        //Antes do fechamento da chave da classe
        public static void ConcaternarPalavras()
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}. Hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("===================");

            Console.WriteLine("Quanto custa um dólar em reais");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Dolar {0:c} em {1:dd/MM/yyyy}", valorDolarReais, DateTime.Now);
            Console.WriteLine(frase2);
            Console.WriteLine("===================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);


            Console.ReadKey();
        }
        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }







    }
}