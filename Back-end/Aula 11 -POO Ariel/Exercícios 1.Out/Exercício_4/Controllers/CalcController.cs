using System;
using Exercício_4.Models;

namespace Exercício_4.Controllers {

    /// <summary>
    /// Calculadora Básica e Ciêntifica
    /// </summary>
    public class CalcController {

        CalcBasic basica = new CalcBasic ();
        CalcCien cient = new CalcCien ();

        /// <summary>
        /// Função que realiza Soma
        /// </summary>
        public void Soma () {
            try {
                int a = 0, b = 0;

                System.Console.Write ("Digite um valor inteiro: ");
                a = int.Parse (Console.ReadLine ());

                System.Console.Write ("Digite outro valor inteiro: ");
                b = int.Parse (Console.ReadLine ());

                basica.Soma = a + b;

                System.Console.WriteLine ("Resultado: " + basica.Soma);
            } catch (Exception) {
                System.Console.WriteLine ("Ops Deu Erro! :(");
            }
        }

        /// <summary>
        /// Função que realiza subtração
        /// </summary>
        public void Subtraco () {
            try {

                int a = 0, b = 0;

                System.Console.Write ("Digite um valor inteiro: ");
                a = int.Parse (Console.ReadLine ());

                System.Console.Write ("Digite outro valor inteiro: ");
                b = int.Parse (Console.ReadLine ());

                basica.Subtracao = a - b;

                System.Console.WriteLine ("Resultado: " + basica.Subtracao);

            } catch (Exception) {
                System.Console.WriteLine ("Ops Deu Erro! :(");
            }
        }

        /// <summary>
        /// Função que realiza Multiplicação
        /// </summary>
        public void Multi () {
            try {
                int a = 0, b = 0;

                System.Console.Write ("Digite um valor inteiro: ");
                a = int.Parse (Console.ReadLine ());

                System.Console.Write ("Digite outro valor inteiro: ");
                b = int.Parse (Console.ReadLine ());

                basica.Multiplicacao = a * b;

                System.Console.WriteLine ("Resultado: " + basica.Multiplicacao);

            } catch (Exception) {
                System.Console.WriteLine ("Ops Deu Erro! :(");
            }
        }

        /// <summary>
        /// Função que realiza Divisão
        /// </summary>
        public void Divi () {
            try {
                int a = 0, b = 0;

                System.Console.Write ("Digite um valor inteiro: ");
                a = int.Parse (Console.ReadLine ());

                System.Console.Write ("Digite outro valor inteiro: ");
                b = int.Parse (Console.ReadLine ());

                basica.Divisao = a / b;

                System.Console.WriteLine ("Resultado: " + basica.Divisao);

            } catch (Exception) {
                System.Console.WriteLine ("Ops Deu Erro! :(");
            }
        }

        /// <summary>
        /// Função que realiza potencia
        /// </summary>
        public double Poten () {
            double a = 0, b = 0;

            //É interessante usar o try quando for possível o Usuário fazer dar merda
            try {

                System.Console.Write ("Digite um valor para Potência: ");
                a = double.Parse (Console.ReadLine ());

                System.Console.Write ("Digite o valor para elevar: ");
                b = double.Parse (Console.ReadLine ());

            } catch (Exception) {
                System.Console.WriteLine ("Ops Deu Erro! :(");
            }

            //O return só guarda o resultado de Math.Pow
            return Math.Pow (a, b);
        }
    }
}