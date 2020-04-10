using System;

namespace Exercício_2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 2");

            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[20];

            for (int contv1 = 0; contv1 <= 9; contv1++) {
                Console.Write ("1Digite o {}valor: ");
                v1[contv1] = int.Parse (Console.ReadLine ());
            }

            for (int contv2 = 0; contv2 <= 9; contv2++) {
                Console.Write ("2Digite o valor: ");
                v2[contv2] = int.Parse (Console.ReadLine ());
            }

            for (int contv3 = 0; contv3 <= 9; contv3++){
                v3[contv3] = v1[contv3];
                Console.WriteLine(v3[contv3]);
            } // Preenche de 0 a 9;

            for(int contv3 = 10; contv3 <= 19; contv3++){
                v3[contv3] = v2[contv3-10];
                Console.WriteLine(v3[contv3]);
            } // Preenche de 10 a 19;
            
        }
    }
}