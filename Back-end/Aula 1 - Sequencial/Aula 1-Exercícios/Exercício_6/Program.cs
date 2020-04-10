using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Exercício 6");

            double salario, divida, op;

            Console.Write("Diga seu salário: ");
            salario = float.Parse(Console.ReadLine());
            
            Console.Write("Diga o valor de suas dívidas: ");
            divida = float.Parse(Console.ReadLine());

            op = salario - divida;

            Console.Write($"Você recebe R${salario}, tem que pagar R${divida}, então vai ficar com R${op}");

        }
    }
}
