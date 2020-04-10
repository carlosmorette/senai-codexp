using System;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula 2-4 Exercício 1");

            string n1; 
            string comida;

            Console.WriteLine ("1. Hamburguer");
            Console.WriteLine ("2. Cheese Salada");
            Console.WriteLine ("3. Cheese burguer");
            Console.WriteLine ("4. Cheese bacon");

            Console.Write ("Digite a opção desejada: ");
            n1 = Console.ReadLine ();

            switch (n1) {
                case "1":
                    comida = "Você pediu Hamburguer";
                    break;
                case "2":
                    comida = "Você pediu um Cheese Salada";
                    break;
                case "3":
                    comida = "Você pediu um Cheese Burguer";
                    break;
                case "4":
                    comida = "Você pediu um Cheese Burguer";
                    break;
                default:
                    comida = "Opção inválida!";
                    break;

            }
            Console.WriteLine (comida);
        }
    }
}