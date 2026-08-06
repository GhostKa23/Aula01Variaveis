

using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula01variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ConcatenarPalavras(); 
            //CalcularMedia(); //aqui é o que chamamos de método
            //CalcularTabuada();
            VerificarAulaEtec();
        }

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine() ?? "0");
            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular:");
            int tabuada = int.Parse(Console.ReadLine() ?? "0");
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem =
                 string.Format("{0} X {1} = {2}",
                            tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine() ?? "0");

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }

        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite o seu nome");
            string? nome = Console.ReadLine(); //Avise ao C# que a variável pode aceitar valores nulos adicionando "?".//

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1); //writeline serve como um print e o readline serve como input//
            Console.WriteLine("============================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine() ?? "0");//o ??"0" serve para que o codigo entenda que se retornar nulo(não for digitado nada) ele retorne zero.//
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, valorDolarReais); //é possivel reservar e criar um formato usando o format//
            Console.WriteLine(frase2);
            Console.WriteLine("================================");

            string cabecalho = string.Format("{0:dddd},{0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
        }
    }

}

