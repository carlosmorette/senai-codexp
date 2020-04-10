using System;
using Aula_11.Models;

namespace Aula_11.Controllers {
    public class CarrosController {

        CarroModel carro = new CarroModel ();
        MotorModel motor = new MotorModel();

        public void Ligar () {
            carro.Ligado = true;
            System.Console.WriteLine ("Ligando Carro!");

        }

        public void Desligar () {
            carro.Ligado = false;
            System.Console.WriteLine ("Desligando Carro...");
        }

        public void Acelerar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro acelerando!");
            } else {
                System.Console.WriteLine ("O carro não está ligado! Impossível Acelerar!");
            }
        }

        public void Frear () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro freiando...");
            } else { 
                System.Console.WriteLine("O carro não está ligado! Impossível frear!");
            }
        }

        public void CadastrarMotor(){

            System.Console.Write("Insira quantos cavalos tem o motor: ");
            motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.Write("Insira quantos cilindros tem o carro: ");
            motor.Cilindros = int.Parse(Console.ReadLine());
            
            System.Console.Write("Insira o modelo do pistão do carro: ");
            motor.Pistao = Console.ReadLine();
            
        }

    }
}