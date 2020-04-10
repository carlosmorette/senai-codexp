using System;
using Exercício_3.Controllers;
using Exercício_3.Models;

namespace Exercício_3 {
    class Program {
        static void Main (string[] args) {
            
            ProdutoController prodControl = new ProdutoController();
            ReservProdutoModel reserContol = new ReservProdutoModel();

            prodControl.CadProduto();

            prodControl.Reserva();

        }
    }
}