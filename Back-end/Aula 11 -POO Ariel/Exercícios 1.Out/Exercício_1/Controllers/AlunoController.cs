using System;
using Exercício_1.Models;

namespace Exercício_1.Controllers {
    public class AlunoController {

        AlunoModel alModel = new AlunoModel ();

        /// <summary>
        ///  Função que Cadastra o Aluno e verifica se ele é bolsista
        /// </summary>
        public void Aluno () {
            try {
                System.Console.Write ("Digite seu nome: ");
                alModel.Nome = Console.ReadLine ();

                System.Console.Write ("Digite seu curso: ");
                alModel.Curso = Console.ReadLine ();

                System.Console.Write ("Digite sua idade: ");
                alModel.Idade = int.Parse (Console.ReadLine ());

                //Aqui pedimos que usuário digitasse seu RG e substituímos os caracteres ' ' e '.' por nada, assim evitando erros
                System.Console.Write ("Digite seu RG: ");
                alModel.RG = double.Parse (Console.ReadLine ().Replace (" ", "").Replace (".", " ").Replace ("-", " "));

                //Aqui perguntamos se o usuário é bolsista
                System.Console.Write ("Você é bolsista [true/false] ");
                alModel.Bolsista = bool.Parse (Console.ReadLine ());


                //Caso ele digite que é, o objeto Bolsista fica true e então mostra que ele é bolsista 
                if (alModel.Bolsista == true) {
                    alModel.Bolsista = true;
                    System.Console.WriteLine ($"{alModel.Bolsista}, você é bolsista!");

                //Caso ele digite false ou diferente disso mostra que ele não é
                } else {
                    alModel.Bolsista = false;
                    System.Console.WriteLine ($"{alModel.Bolsista}, você não é bolsista!");

                }
            }catch(Exception){
                System.Console.WriteLine("Desculpe, ocorreu um erro! :( ");
            }
        }
    }
}