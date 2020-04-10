using System;
using Aula_11.Controllers;

namespace Aula_11 {
    class Program {
        static void Main (string[] args) {

            CarrosController carro = new CarrosController();
            CarrosEletricosControllers carroEletrico = new CarrosEletricosControllers();

            Console.Clear(); //Limpa a tela do terminal.

            carroEletrico.Ligar();

            carroEletrico.CarregarBateria(15);

            System.Console.WriteLine($"Carga do carro: {carroEletrico.StatusBateria()}");

            
        
        }
    }
}