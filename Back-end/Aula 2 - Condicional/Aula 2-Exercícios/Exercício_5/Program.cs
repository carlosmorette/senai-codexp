using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 5 Estrutua de Decisão");

            int n1,n2,n3;

            Console.Write("Digite o 1º valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º valor: ");
            n2 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o 3º valor: ");
            n3 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3){
                Console.WriteLine("1º valor é maior!");
            }else if(n2 > n1 && n2 > n3){
                Console.WriteLine("2º valor é maior!");
            }else if (n3 > n2 && n3 > n1){
                Console.WriteLine("3cd .º valor é maior!");
            }
        }
    }
}
