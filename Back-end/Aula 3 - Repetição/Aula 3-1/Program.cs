using System;

namespace Aula_3___Repetição {
    class Program {
        static void Main (string[] args) {
            /*
                Laços Contados são feitos para os que ja sabem quantas voltas (loops) vão dar
                Laços Condicionais são usados quando não se sabe quantas voltas (lopps) o programa vai dar
            */

            //Laço contado - FOR - Incremente (+) [1] Definir a variavel contadora, [2] coloca a condição e por fim[3] coloca o contador para rodar *
            for (int cont = 1; cont <= 100; cont++) {

                //Verificamos se o número é difetente de 2
                if (cont % 2 != 0) {
                    Console.WriteLine ("For 0-100 - " + cont);
                }
            }

            //Laço contado - FOR - Decremento (-)
            for (int cont2 = 100; cont2 >= 1; cont2--) {

                if (cont2 % 2 != 0) {
                    Console.WriteLine ("For 100-0 - " + cont2);
                }
            }

            //Laço condicional - While
            double acumuladora = 0;
            double nota = 0;
            int cont3 = 0;
            string sair = "";

            //Conteúdo da variável double transformado em String, no caso o 0
            while (sair != "sim") {
                Console.Write ("Digite a nota de um aluno: ");
                nota = double.Parse (Console.ReadLine ());

                acumuladora += nota;
                cont3++;

                //Variavel sair é como um botão para sair
                Console.Write ("Deseja sair da aplicação? [sim/nao]: ");
                sair = Console.ReadLine ().ToLower (); //ToLower serve para deixar os caracteres em minúsculo.

            }

            Console.WriteLine ($"Média das notas : {acumuladora / cont3}");

            //====================================
            int n;
            int cont3 = 0;
            int acm = 0;
            do {
                Console.Write ("Digite um número inteiro: ");
                n = int.Parse (Console.ReadLine ());
                cont3 = cont3 + 1;

                if (n % 3 == 0) {
                    acm = acm + n;
                }

            } while (cont3 <= 20);

            Console.WriteLine (acm);
        }
    }
}