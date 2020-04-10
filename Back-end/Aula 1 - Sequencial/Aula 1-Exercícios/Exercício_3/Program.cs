using System;

namespace Exercício_3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo ao Exercício 3");

            double salario, conta, venda;

            Console.Write ("Digite seu salário: ");
            salario = double.Parse (Console.ReadLine ());

            Console.Write ("Diga seu total de vendas: ");
            venda = int.Parse (Console.ReadLine ());

            conta = salario + (venda * 0.5);

            Console.WriteLine ($"Seu salário que é R${salario} ficou por R${conta}");

        }
    }
}