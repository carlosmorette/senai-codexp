using System;
using Exercício_2.Models;

namespace Exercício_2.Controllers {
    public class CelularControllers {
        CelularModel clModel = new CelularModel ();

        /// <summary>
        /// Realiza cadastro do celular
        /// </summary>
        public void CadCelular () {

            try {
                System.Console.Write ("Digite a Cor do celular: ");
                clModel.Cor = Console.ReadLine ();

                System.Console.Write ("Digite o Modelo do celular: ");
                clModel.Modelo = Console.ReadLine ();

                System.Console.Write ("Digite o Tamanho do celular: ");
                clModel.Tamanho = float.Parse (Console.ReadLine ());

                System.Console.Write ($"Cor: " + clModel.Cor + "\n" + "Modelo:" +
                    clModel.Modelo + "\n" + "Tamanho: " + clModel.Tamanho + "\n");
            } catch (Exception) {
                System.Console.Write ("Ocorreu um erro! Tente novamente :(");
            }

        }

        /// <summary>
        ///  Função que ve se o celular está ligado
        /// </summary>
        public void Ligado () {
            try {
                clModel.Ligado = true;
                System.Console.WriteLine ("Celular LIGADO!");
            } catch (Exception) {
                System.Console.WriteLine ("ERRO!");
            }
        }

        /// <summary>
        /// Função que ve se o celular esta Desligado
        /// </summary>
        public void Desligar () {
            try {
                clModel.Desligar = false;
                System.Console.WriteLine ("Celular DESLIGADO!");
            } catch (Exception) {
                System.Console.WriteLine ("ERRO!");

            }
        }

        /// <summary>
        /// Função que verifica se o celular esta Ligado, se sim ele realiza a ação de Ligacao
        /// </summary>
        public void Ligacao () {
            try {
                if (clModel.Ligado == true) {
                    System.Console.WriteLine ("Realizando LIGAÇÃO");
                } else {
                    System.Console.WriteLine ("Impossivel! Celular DESLIGADO");
                }
            } catch (Exception) {
                System.Console.WriteLine ("ERRO!");

            }
        }

        /// <summary>
        /// Função que verifica se o celular esta Ligado, se sim ele realiza a ação de Enviar Mensagem
        /// </summary>
        public void Enviar () {
            try {
                if (clModel.Ligado == true) {
                    System.Console.WriteLine ("Enviando Mensagem!");
                } else {
                    System.Console.WriteLine ("Impossível! Celular DESLIGADO");
                }
            } catch (Exception) {
                System.Console.WriteLine ("ERRO!");

            }
        }

    }
}