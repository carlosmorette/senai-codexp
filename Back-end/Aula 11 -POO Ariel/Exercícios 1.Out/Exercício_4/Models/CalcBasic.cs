namespace Exercício_4.Models {

    /// <summary>
    ///  Objetos de uma calculadora básica
    /// </summary>
    public class CalcBasic {

        /// <summary>
        /// Obejto Soma
        /// </summary>
        /// <value>Int</value>
        public int Soma { get; set; } 

        /// <summary>
        /// Obejto Subtracao
        /// </summary>
        /// <value>Int</value>
        public int Subtracao { get; set; }

        /// <summary>
        /// Objeto Multiplicacao
        /// </summary>
        /// <value>Int</value>
        public int Multiplicacao { get; set; }

        /// <summary>
        /// Obejto Divisao
        /// </summary>
        /// <value>Double</value>
        public double Divisao { get; set; }

        /// <summary>
        /// Objeto cien herdado da Calculadora Basic
        /// </summary>
        /// <value></value>
        CalcCien cien {get ; set; }
    }
}