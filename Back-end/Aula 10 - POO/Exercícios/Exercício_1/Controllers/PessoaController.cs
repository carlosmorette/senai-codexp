using System;
using Exercício_1.Models;

namespace Exercício_1.Controllers {
    public class PessoaController {

        PessoaModel pessoa = new PessoaModel ();

        public void CadastrarPessoa () {
            System.Console.Write ("Digite o Nome da Pessoa: ");
            pessoa.NomePessoa = Console.ReadLine ();

            System.Console.Write ("Digite a Idade da Pessoa: ");
            pessoa.IdadePessoa = int.Parse (Console.ReadLine ());

            System.Console.Write ("Digite o Peso da Pessoa: ");
            pessoa.PesoPessoa = double.Parse (Console.ReadLine ());

            System.Console.Write ("Digite a Altura da Pessoa: ");
            pessoa.AlturaPessoa = double.Parse (Console.ReadLine ());
        }

        public void MostrarPessoa () {
            System.Console.WriteLine ("===============");
            System.Console.WriteLine ($"Nome: {pessoa.NomePessoa}");
            System.Console.WriteLine ($"Idade: {pessoa.IdadePessoa}");
            System.Console.WriteLine ($"Peso: {pessoa.PesoPessoa}Kg");
            System.Console.WriteLine ($"Altura: {pessoa.AlturaPessoa}m");
            System.Console.WriteLine ("===============");

        }

        public void IMCPessoa () {
            double imc = 0;

            imc = pessoa.PesoPessoa / (pessoa.AlturaPessoa * pessoa.AlturaPessoa);

            System.Console.WriteLine ($"IMC: {imc}");

            if (imc < 18.5) {
                System.Console.WriteLine ("Abaixo do peso!");
            } else if (imc >= 18.5 && imc <= 25) {
                System.Console.WriteLine ("Peso normal!");
            } else if (imc >= 26 && imc <= 30) {
                System.Console.WriteLine ("Sobrepeso!");
            } else if (imc >= 31 && imc <= 35) {
                System.Console.WriteLine ("Obesidade grau I");
            } else if (imc >= 36 && imc <= 39) {
                System.Console.WriteLine ("Obesidade grau II");
            } else if (imc >= 40) {
                System.Console.WriteLine ("Obesidade grau III");
            }
        }
    }
}