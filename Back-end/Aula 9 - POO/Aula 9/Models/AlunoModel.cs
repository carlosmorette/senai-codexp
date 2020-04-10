using System;

namespace Aula_9.Models {
    public class AlunoModel {
        // Atributos
        /// <summary>
        ///  Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome { get; set; }

        /// <summary>
        /// Curso do aluno
        /// </summary>
        /// <value>string</value>
        public string Curso { get; set; }

        /// <summary>
        /// RA do aluno
        /// </summary>
        /// <value>string</value>
        public string RA { get; set; }

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int idade { get; set; }

        /// <summary>
        ///  Comportamento Estudar
        /// </summary>
        public void Estudar () {
            Console.WriteLine ("Estou estudando!");
        }

        // Comportamento
        /// <summary>
        ///  Comportamento Pedir Intervalo
        /// </summary>
        public void PedirIntervalo () {
            Console.WriteLine ("Pode fazer intervalo aee!");
            Console.WriteLine ("QUERO CAFÉÉE");
        }

        /// <summary>
        /// Comportamento Pedir Ajuda
        /// </summary>
        public void PedirAjuda () {
            Console.WriteLine ("Paulo, chega ae");
        }
    }
}