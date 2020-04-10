using System;
using Exercício_1.Controllers;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {

            Console.Clear();

            PessoaController pess = new PessoaController();

            pess.CadastrarPessoa();

            pess.MostrarPessoa();

            pess.IMCPessoa();
        }
    }
}