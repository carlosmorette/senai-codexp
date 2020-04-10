using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Exercício 4");

            float real, dolar, conv;

            Console.Write("Digite o valor do Real(R$): ");
            real = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Dólar (US$): ");
            dolar = float.Parse(Console.ReadLine());

            conv = real * dolar;

            Console.WriteLine($"Sua conversão deu o seguinte resultado: U${conv}");
        }
    }
}
