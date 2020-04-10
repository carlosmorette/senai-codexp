using System;

namespace Exercício_4 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 3");

            string[] vetA = new string[15];
            string[] vetB = new string[15];
            string[] vetC = new string[30];

            for (int i = 0; i <= 14; i++) {
                Console.Write ($"1Digite a {i+1}ª palavra: ");
                vetA[i] = Console.ReadLine ();
            }

            for (int i = 0; i <= 14; i++) {
                Console.Write ($"2Digite a {i+1}ª palavra: ");
                vetB[i] = Console.ReadLine ();
            }

            for (int i = 0; i <= 14; i++) {
                vetC[i] = vetA[i];
                Console.WriteLine (vetC[i]);
            } // Preenche de 0 a 9;

            for (int i = 15; i <= 29; i++) {
                vetC[i] = vetB[i - 15];
                Console.WriteLine (vetC[i]);
            } // Preenche de 10 a 19;

        }
    }
}