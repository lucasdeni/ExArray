using System;
using System.Globalization;

namespace ExArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um número de pessoas: "); //Criando a variável de entrada
            int n = int.Parse(Console.ReadLine()); //Criando vetor com o número da variável de entrada
            double[] vetor = new double[n]; 
            for (int i = 0; i < n; i++) //Utilização do comando for para percorrer o vetor
            {
                Console.Write("Altura da pessoa: ");
                vetor [i] = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture); //Entrada dos elementos no vetor pelo usuário
            }
            double soma = 0; //Variável soma      
            for (int i = 0; i < n; i++) //Utilização do for para percorrer o vetor
            {
                soma += vetor[i]; //Soma dos elementos inseridos
            }
            double media = soma / n; //Declaração da variável media
            Console.WriteLine("A média total das pessoas inseridas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
