using System;

namespace Exercício_2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula 2-4 Exercício 2");

            double peso, np, calc;
            string pesoFinal;

            Console.Write ("Digite seu peso: ");
            peso = double.Parse (Console.ReadLine ());

            Console.Write ("Digite o número do planeta: ");
            np = double.Parse (Console.ReadLine ());

            switch (np) {
                case 1:
                    calc = (peso * 0.37) / 10;
                    pesoFinal = $"Seu peso em Mercúrio ficou por {calc}";
                    break;
                case 2:
                    calc = (peso * 0.88) / 10;
                    pesoFinal = $"Seu peso em Vênus ficou por {calc}";
                    break;
                case 3:
                    calc = (peso * 0.38) / 10;
                    pesoFinal = $"Seu peso em Marte ficou por {calc}";
                    break;
                case 4:
                    calc = (peso * 2.64) / 10;
                    pesoFinal = $"Seu peso em Jupiter ficou por {calc}";
                    break;
                case 5:
                    calc = (peso * 1.15) / 10;
                    pesoFinal = $"Seu peso em Saturno ficou por {calc}";
                    break;
                case 6:
                    calc = (peso * 1.17) / 10;
                    pesoFinal = $"Seu peso em Urano ficou por {calc}";
                    break;
                default:
                    pesoFinal = "Planeta errado!";
                    break;
            }
            Console.WriteLine(pesoFinal);
        }
    }
}