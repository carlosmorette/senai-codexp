using System;

namespace Exercício_3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 3");

            string[] vet = new string[3];

            for (int cont = 0; cont <= 2; cont++) {
                Console.Write ("Digite o Nome do produto: ");
                vet[cont] = Console.ReadLine ();

                Console.Write ("Digite a Cor do produto: ");
                vet[cont] = Console.ReadLine ();

                Console.Write ("Digite o Tamanho do produto: ");
                vet[cont] = Console.ReadLine ();

                Console.Write ("Digite o Preço do produto: ");
                vet[cont] = Console.ReadLine ();

            }

            // for (int cont2 = 0; cont2 <= 2; cont2++) {
            //     Console.WriteLine (vet[0]);
            //     Console.WriteLine (vet[1]);
            //     Console.WriteLine (vet[2]);
            // }

        }
    }
}