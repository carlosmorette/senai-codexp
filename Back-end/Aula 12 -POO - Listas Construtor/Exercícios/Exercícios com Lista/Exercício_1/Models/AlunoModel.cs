namespace Exercício_1.Models {

    /// <summary>
    ///  Modelo de Aluno
    /// </summary>
    public class AlunoModel {

        //Aqui declaramos o objeto utilizado no Controller que são Nome, Curso, Idade, RG e Bolsista

        /// <summary>
        ///  Objeto Nome
        /// </summary>
        /// <value>String</value>
        public string Nome { get; set; }

        /// <summary>
        ///  Objeto Curso
        /// </summary>
        /// <value>String</value>
        public string Curso { get; set; }

        /// <summary>
        ///  Obejto Idade
        /// </summary>
        /// <value>Int</value>
        public int Idade { get; set; }

        /// <summary>
        ///  Obejto RG
        /// </summary>
        /// <value>Double</value>
        public double RG { get; set; }

        /// <summary>
        /// Obejto Bolsista
        /// </summary>
        /// <value>bool</value>
        public bool Bolsista { get; set; }

        public AlunoModel (string nome, string curso, int idade, double rg, bool bolsista) {
            this.Nome = nome;
            this.Curso = curso;
            this.Idade = idade;
            this.RG = rg;
            this.Bolsista = bolsista;
        }

    }
}