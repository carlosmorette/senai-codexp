namespace Exercício_2.Models {
    public class CelularModel {
        
        //Atribuindo valor
        //public string Cor {get; set; } = Azul;

        //Aqui declaramos os obejtos utilizados no Controller que são Cor,Modelo,Tamanho 
        /// <summary>
        ///  Obejto Cor
        /// </summary>
        /// <value>String</value>
        public string Cor { get; set; }

        /// <summary>
        ///  Obejto Modelo
        /// </summary>
        /// <value>string</value>
        public string Modelo { get; set; }

        /// <summary>
        /// Objeto Tamanho
        /// </summary>
        /// <value>Float</value>
        public float Tamanho { get; set; }

        //Aqui definimos o Ligado, Desligar, Ligacao e EnviarMen
        /// <summary>
        /// Objeto Ligado
        /// </summary>
        /// <value>Bool</value>
        public bool Ligado { get; set; }

        /// <summary>
        /// Objeto Desligar
        /// </summary>
        /// <value>Bool</value>
        public bool Desligar { get; set; }

        /// <summary>
        /// Objeto Ligacao
        /// </summary>
        /// <value>Bool</value>
        public bool Ligacao { get; set; }

        /// <summary>
        /// Obejto Enviar Mensagem
        /// </summary>
        /// <value>Bool</value>
        public bool EnviMen { get; set; }

    }
}