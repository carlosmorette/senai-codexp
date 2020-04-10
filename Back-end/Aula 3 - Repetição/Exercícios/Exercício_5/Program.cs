using System;

namespace Exercício_5 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Exercícios Estrutura de Repetição - Exercício 5");

            int func, cont  = 1;
            double sal = 0, media = 0, acm = 0;

            Console.Write ("Digite a quantidade de funcionários: ");
            func = int.Parse (Console.ReadLine ());

            do {
                Console.Write ($"Digite o salário do {cont}º funcionário: ");
                sal = double.Parse(Console.ReadLine());
                acm = acm + sal;
                cont++;
            } while (cont <= func);

            media = acm / func;

            //ToString("F2") serve para determinar a quantidade de casas depois da virgula
            Console.WriteLine($"A média de salários é : R${media.ToString("F2")}");
        }
    }
}