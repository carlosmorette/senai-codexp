using System;

namespace Exercício_4 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercícios Estrutura de Repetição - Exercício 4");

            int valor = 0;
            int cont = 0;
            int media = 0;
            int acm = 0;
            int contNega = 0;

            while (cont <= 20) {
                Console.Write ($"Digite um valor: ");
                valor = int.Parse (Console.ReadLine ());

                if (valor >= 0) {
                    Console.WriteLine($"Valor positivo: {valor}");
                } else{
                    acm = acm + valor;
                    contNega++;
                }
                cont++;
            }

            media = acm / contNega;

            Console.WriteLine($"Média dos números negativos: {media}");
        }
    }
}