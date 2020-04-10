using System;
using Exercício_3.Models;

namespace Exercício_3.Controllers {
    public class ProdutoController {

        ProdutoModel prodMod = new ProdutoModel ();
        ReservProdutoModel reserv = new ReservProdutoModel ();

        /// <summary>
        /// Função que Cadastra o Produto
        /// </summary>
        public void CadProduto () {
            try {
                System.Console.Write ("Digite o Nome do produto: ");
                prodMod.Nome = Console.ReadLine ();

                System.Console.Write ("Digite a Cor do produto: ");
                prodMod.Cor = Console.ReadLine ();

                System.Console.Write ("Digite o Tamanho do produto: ");
                prodMod.Tamanho = float.Parse (Console.ReadLine ());

                System.Console.Write ("Digite o Preço do produto: ");
                prodMod.Preco = double.Parse (Console.ReadLine ());
            } catch (Exception) {
                System.Console.Write ("ERRO NO CADASTRO!");
            }

        }

        /// <summary>
        /// Função que verifica se o usuário deseja reservar o produto
        /// </summary>
        public void Reserva () {
            try {
                System.Console.Write ("Deseja Reservar o produto?[true/false]: ");
                reserv.Reserva = bool.Parse (Console.ReadLine ());

                if (reserv.Reserva == true) {
                    reserv.Reserva = true;
                    System.Console.WriteLine ("Produto RESERVADO!");
                } else {
                    System.Console.WriteLine ("Produto NÃO RESERVADO!");
                }
            } catch (Exception) {
                System.Console.WriteLine ("ERRO!!");
            }
        }

    }
}