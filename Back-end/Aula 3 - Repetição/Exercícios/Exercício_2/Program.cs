using System;

namespace Exercício_2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercícios Estrutura de Repetição - Exercício 2");

            int user = 0;
            int tab = 0;
            
            Console.Write ("Digite um número inteiro: ");
            user = int.Parse (Console.ReadLine ());

            for (int cont = 0; cont <= 10; cont++) {
                tab = user * cont;
                Console.WriteLine ($"{user} x {cont} = {tab}");

            }

        }
    }
}