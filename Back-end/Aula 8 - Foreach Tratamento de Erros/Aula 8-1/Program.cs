using System;

namespace Aula_8 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            string[] v1 = { "A", "B", "C","D","E"};

            //Laço de Repetição Foreach
            foreach (string xpto in v1) {
                Console.WriteLine(xpto);
            }

        }
    }
}