using System;

namespace Exercício_6 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 5\n\n");

            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.Write ($"Digite o {i+1}º valor do Vetor A: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++) {
                Console.Write ($"Digite o {i+1}º valor do Vetor B: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++) {
                vetorC[i] = vetorA[i] + vetorB[i];
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine (vetorC[i]);
            }

        }
    }
}