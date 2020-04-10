using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2 Estrutura de Decisão");

            float pt, cont;

            Console.Write("Digite o valor total das compras: ");
            pt = float.Parse(Console.ReadLine());

            if(pt > 100){
                cont = (pt - 25);
                Console.WriteLine($"Sua compra ficou por R${cont}");
            }else{
                Console.WriteLine($"Sua compra ficou por R${pt}");
            }
        }
    }
}
