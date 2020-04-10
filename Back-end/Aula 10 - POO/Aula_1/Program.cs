using System;
using Aula_10___POO.Controllers;

namespace Aula_10___POO {
    class Program {
        static void Main (string[] args) {            

            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto();

            produto1.ExibirProduto();
        }
    }
}