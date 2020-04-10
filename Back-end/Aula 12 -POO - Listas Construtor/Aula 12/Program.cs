using System;
using System.Collections.Generic;
using Aula_12__POO___Listas_Construtor.Models;

namespace Aula_12__POO___Listas_Construtor {
    class Program {
        static void Main (string[] args) {

            Console.Clear();

            // Instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel (1, "Maçã   ", "Verde", 3.5);

            // Chamamos um atributo do objeto instanciado
            Console.WriteLine (produto.NomeProduto);

            // Instanciamos nossa classe sem passar parâmetros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel ();

            // Instanciamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;

            //Chamamos a nossa lista que vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel> ();

            // Adicionamos objetos instanciados e atribuidos em nossa lita
            prod.Add (new ProdutoModel (1, "Cenoura", "Laranja", 2.30));
            prod.Add (new ProdutoModel (2, "Mamão", "Laranja", 2.30));
            prod.Add (new ProdutoModel (3, "Tomate", "Vermelho", 2.30));
            prod.Add (new ProdutoModel (4, "Abóbora", "Verde", 2.30));
            prod.Add (new ProdutoModel (5, "Beterraba", "Roxo", 2.30));
            prod.Add (new ProdutoModel (6, "Cachorro-Quente", "Muito bom", 2.30));

            // Lemos os dados da nossa lista
            foreach(ProdutoModel p in prod){
                Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }

            // Chamamos através do indice um atributo específico
            System.Console.WriteLine(prod[4].NomeProduto);

        }
    }
}