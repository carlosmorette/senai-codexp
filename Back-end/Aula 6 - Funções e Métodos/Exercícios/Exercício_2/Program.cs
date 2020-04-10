using System;

namespace Exercício_2 {
    class Program {
        static void Main (string[] args) {
            Dia();
        }

        /// <summary>
        ///  Função que retorna o dia da semana
        /// </summary>
        /// <returns>Retorna Dia da Semana</returns>
        static void Dia () {
            DateTime dia = DateTime.Today;

            Console.WriteLine(dia.DayOfWeek);
        }
    }
}