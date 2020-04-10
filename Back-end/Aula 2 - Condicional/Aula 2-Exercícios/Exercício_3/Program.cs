using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3 Estrutura de Decisão");

            int n1, n2;

            Console.Write("Escreva o 1º número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Escreva o 2º número: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                Console.WriteLine($"O Número {n1} é maior que o número {n2}");
            }else{
                Console.WriteLine($"O Número {n2} é maior que o número {n1}");
            }

        }
    }
}
