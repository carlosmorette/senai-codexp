using System;

namespace Exercício_3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercícios Estrutura de Repetição - Exercício 3");

            int n = 0;
            int cont = 1;

            Console.Write ("Digite um valor: ");
            n = int.Parse (Console.ReadLine ());

            while (cont <= n) {
                
                if (cont % 5 == 0) {
                    Console.WriteLine ("While 0-100 - " + cont);
                }
                cont++;
            }
        }
    }
}