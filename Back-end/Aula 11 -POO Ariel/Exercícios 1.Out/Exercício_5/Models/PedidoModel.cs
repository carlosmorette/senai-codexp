namespace Exercício_5.Models {

    /// <summary>
    /// Características do Pedido
    /// </summary>
    public class PedidoModel {
        
        /// <summary>
        /// Objeto DataPedido
        /// </summary>
        /// <value>int</value>
        public int DataPedido { get; set; }

        /// <summary>
        /// Obejto PizzaPedido atribuido PizzaModel
        /// </summary>
        /// <value></value>
        PizzaModel PizzaPedido { get; set; }

        /// <summary>
        /// Objeto EnderecoPedido
        /// </summary>
        /// <value>String</value>
        public string EnderecoPedido { get; set; }

        /// <summary>
        /// Objeto PrevisaoEntrega
        /// </summary>
        /// <value>int</value>
        public int PrevisaoEntrega { get; set; } //Data do Pedido + 30min

    }
}