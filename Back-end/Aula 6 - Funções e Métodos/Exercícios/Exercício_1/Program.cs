using System;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {

            double valorUsu = 0, porc = 0;

            //Usando esse bloco para Ler o valor do Produto e Desconto, caso ocorra algum erro ele para...
            try {
                //Pedindo o valor
                Console.Write ("Digite o valor do produto: ");
                valorUsu = double.Parse (Console.ReadLine ());

                //Pedindo a porcentagem de desconto
                Console.Write ("Digite o valor do desconto: ");
                porc = double.Parse (Console.ReadLine ().Replace ("%", ""));
                Console.WriteLine ($"Você ira pagar: R${Desconto(valorUsu, porc).ToString("F2")}");

            } catch (Exception) {
                Console.WriteLine ("Os dados devem ser numéricos!");
            }

        }

        /// <summary>
        ///  Função que calcula Desconto em cima de um valor
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="porcentagem"></param>
        /// <returns>Valor com Desconto</returns>
        static double Desconto (double valor, double porcentagem) {
            double resultado = valor - (valor * porcentagem) / 100;

            return resultado;
        }
    }
}