using System;
using Exercício_4.Controllers;

namespace Exercício_4 {
    class Program {
        static void Main (string[] args) {

            CalcController clControl = new CalcController ();

            Console.Clear ();
            int r = 0;

            System.Console.WriteLine ("=====");
            System.Console.WriteLine ("Menu: \n\t 1.Soma \n\t 2.Subtração \n\t 3.Multiplicação \n\t 4.Divisão \n\t 5.Potência \n\n");
            r = int.Parse (Console.ReadLine ());

            if (r == 1) {
                Console.Clear ();
                System.Console.WriteLine ("Opção 1.Soma");
                clControl.Soma ();

            } else if (r == 2) {
                Console.Clear();
                System.Console.WriteLine("Opção 2.Subtração");
                clControl.Subtraco ();
            
            } else if (r == 3) {
                Console.Clear();
                System.Console.WriteLine("Opção 3.Multiplicação");
                clControl.Multi ();

            } else if (r == 4) {
                Console.Clear();
                System.Console.WriteLine("Opção 4.Divisão");
                clControl.Divi ();

            } else if (r == 5) {
                Console.Clear();
                System.Console.WriteLine("Opção 5.Potência");
                // Aqui mostramos o resultado do Poten
                System.Console.WriteLine(clControl.Poten());
            }
        }
    }
}