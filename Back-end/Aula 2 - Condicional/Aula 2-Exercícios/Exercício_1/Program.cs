using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1 Estrutura de Decisão");

            float salario, dt, cont;
            string resposta;

            Console.Write("Digite seu salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Digite o total de suas despesas: ");
            dt = float.Parse(Console.ReadLine());

            cont = salario - dt;

            if (cont >= 0){
                resposta = "Seu saldo é Positivo";
            }else{
                resposta = "Seu salário é Negativo";
            }
            Console.WriteLine(resposta);



        }
    }
}
