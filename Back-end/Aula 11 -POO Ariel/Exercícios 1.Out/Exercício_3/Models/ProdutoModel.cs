namespace Exercício_3.Models {
    
    /// <summary>
    /// Objetos referentes a características do produto
    /// </summary>
    public class ProdutoModel {

        /// <summary>
        /// Objeto Nome
        /// </summary>
        /// <value>String</value>
        public string Nome { get; set; }

        /// <summary>
        /// Objeto Cor
        /// </summary>
        /// <value>String</value>
        public string Cor { get; set; }

        /// <summary>
        /// Objeto Tamanho
        /// </summary>
        /// <value>Float</value>
        public float Tamanho { get; set; }

        /// <summary>
        /// Objeto Preco
        /// </summary>
        /// <value>Double</value>
        public double Preco { get; set; }

        //ReservProdutoModel armazena a resposta bool de se deseja ou não fazer a reserva
        /// <summary>
        /// Chamado Model ReservProduto
        /// </summary>
        /// <value>Bool</value>
        public ReservProdutoModel Reserv {get; set;}
    }
}