using System;
using System.IO;
using Aula_10___POO.Models;

namespace Aula_10___POO.Controllers {
    public class ProdutosController {

        ProdutosModel produto = new ProdutosModel ();

        public void CadastrarProduto () {

            try {

                Console.Write ("Digite o ID do Produto: ");
                produto.IdProduto = int.Parse (Console.ReadLine ());

                Console.Write ("Digite o Nome do Produto: ");
                produto.NomeProduto = Console.ReadLine ();

                System.Console.Write ("Digite a Descrição do Produto: ");
                produto.Descricao = Console.ReadLine ();

                System.Console.Write ("Digite o Preço do produto");
                produto.Preco = double.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o ID do Fornecedor: ");
                // produto.Fornecedor.IdFornecedor = int.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o Nome do Fornecedor: ");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine ();

            } catch(Exception ex){
                Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                SalvarErros(ex);
            }

        }

        public void ExibirProduto () {

            System.Console.WriteLine (produto.IdProduto);
            System.Console.WriteLine (produto.NomeProduto);
            System.Console.WriteLine (produto.Descricao);
            System.Console.WriteLine (produto.Preco);

            // System.Console.WriteLine (produto.Fornecedor.IdFornecedor);
            // System.Console.WriteLine (produto.Fornecedor.NomeFornecedor);

        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}