using System;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercícios Estrutura de Repetição - Exercício 1");

            //[1] Definir a variavel contadora, [2]coloca a condição e por fim [3]coloca o contador para rodar
            //for (int cont = 1; cont <= 100; cont++) {

            double cubo = 0;
            for (int cont = 0; cont <= 100; cont++){
                cubo = cont *cont *cont;
                Console.WriteLine(cubo);
            }
        }
    }
}