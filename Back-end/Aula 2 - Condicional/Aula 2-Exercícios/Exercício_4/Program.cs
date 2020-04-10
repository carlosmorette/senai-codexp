using System;

namespace Exercício_4 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercício 4 Estrutura de Decisão");

            double total;

            Console.Write ("Digite o valor total da compra: ");
            total = double.Parse (Console.ReadLine ());

            if (total > 100 && total < 1000) {
                total  = total - (total * 0.015);
            } else {
                Console.WriteLine ("Sua compra ficou Menor que 100 ou Maior que 1000");
            }

            Console.WriteLine ($"Sua conta ficou por R${total}");
        }
    }
}