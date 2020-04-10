using System;

namespace Aula_9 {
    class Program {
        static void Main (string[] args) {

            //Declarando objeto

            AlunoModel aluno = new AlunoModel();

            System.Console.Write ("Insira seu nome: ");
            aluno.Nome = Console.ReadLine ();

            System.Console.Write ("Insira o nome do seu curo: ");
            aluno.Curso = Console.ReadLine ();

            System.Console.Write ("Insira seu RA");
            aluno.RA = Console.ReadLine ();

            System.Console.Write ("");
            aluno.idade = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Nome: " + aluno.Nome);
            System.Console.WriteLine ("Curso: " + aluno.Curso);
            System.Console.WriteLine ("RA: " + aluno.RA);
            System.Console.WriteLine ("Idade: "+ aluno.Idade);
        }
    }
}