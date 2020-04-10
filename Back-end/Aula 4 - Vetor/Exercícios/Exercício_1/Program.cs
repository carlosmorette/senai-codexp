using System;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 1");

            int[] valores = new int[10];
            double mult;

            for (int cont = 0; cont <= 9; cont++) {

                Console.Write ($"Digite o {cont+1} valor: ");
                valores[cont] = int.Parse (Console.ReadLine ());
            }

            for (int cont = 0; cont <=9; cont++){
                Console.WriteLine($"O valor inserido foi: {valores[cont]}");
            }
                
            mult = valores[9] * 5;

            Console.WriteLine ($"A Ultima posição do seu vetor = {valores[9]} multiplicada por 5 ficou por: {mult}");
        }
    }
}