using System;

namespace Aula_8_2 {
    class Program {
        static void Main (string[] args) {

            int numero;

            try {
                //Escrevemos um bloco de código
                Console.WriteLine ("Digite um número: ");
                numero = int.Parse (Console.ReadLine ());
                // Variável ex armazena o erro e em seguida mostramos esse erro
            } catch (Exception ex) {
                Console.WriteLine ($"Ops :( Deu ruim.\nErro{ex}");
                //Mostramos a excessão da Regra
                //Erro gerado na aplicação
            }
        }

    }
}
