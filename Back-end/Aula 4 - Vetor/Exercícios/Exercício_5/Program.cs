using System;

namespace Exercício_5 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 5\n\n");

            int[] nms = new int[10];
            double mult = 0;

            for(int i=0; i <= 9; i++){
                Console.Write($"Digite o {i+1}º valor inteiro: ");
                nms[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i <=9; i++){
                mult = nms[i] *2;
                Console.WriteLine(mult);
            }
        }
    }
}