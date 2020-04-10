using Exercício_5.Models;
using System;

namespace Exercício_5.Controllers {
    public class PedidoController {

        PedidoModel pedMod = new PedidoModel ();
        PizzaModel pizMod = new PizzaModel ();

        /// <summary>
        /// Função que realiza o pedido do Usuário
        /// </summary>
        public void PedidoUsu () {

            try {
                System.Console.WriteLine ("==============");
                System.Console.WriteLine ("Bem Vindo\n");

                System.Console.Write ("Informe Data do seu Pedido:\nEx: 24.12.2010 ");
                pedMod.DataPedido = int.Parse (Console.ReadLine ().Replace(".","").Replace(" ",""));


                System.Console.WriteLine ("Informe o jeito que deseja a Pizza: ");
                System.Console.Write ("Tipo [Doce ou Salgada]: ");
                pizMod.Tipo = Console.ReadLine ();

                System.Console.Write ("Nome: ");
                pizMod.Nome = Console.ReadLine ();

                System.Console.Write ("Preço: ");
                pizMod.Preco = double.Parse (Console.ReadLine ());

                System.Console.Write ("Tamanho [Pequena ,Media ou Grande]: ");
                pizMod.Tamanho = Console.ReadLine ();

                System.Console.WriteLine ();

                System.Console.Write ("Informe o Endereço do Pedido: ");
                pedMod.EnderecoPedido = Console.ReadLine ();

                System.Console.Write ("Previsão de Entrega: ");

                //Aqui atribuimos Data, Agora, e mais 30 minutos no pedido
                pedMod.PrevisaoEntrega = DateTime.Now.Minute+30;

                //Aqui mostramos a Hora e a Previsão de Entrega que é os Minutos de agora + 30
                System.Console.WriteLine($"{DateTime.Now.Hour}:{pedMod.PrevisaoEntrega}");

                System.Console.WriteLine ("PEDIDO CONCLUÍDO!");
            } catch(Exception){
                System.Console.WriteLine("Ops, deu erro! :(");
            }

        }

    }
}