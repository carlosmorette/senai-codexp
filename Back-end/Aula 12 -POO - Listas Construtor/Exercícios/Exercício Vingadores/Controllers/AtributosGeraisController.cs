using System;
using Exercício_Vingadores.Models;

namespace Exercício_Vingadores.Controllers {
    public class AtributosGeraisController {

        AtributosGerais atGeral = new AtributosGerais ();

        /// <summary>
        /// Vida é um objeto de característica herdada pelos dois personagens
        /// </summary>
        public int Vida () {
            System.Console.Write ("Vida: ");
            atGeral.Vida = 200;
            return atGeral.Vida;
        }

        /// <summary>
        /// Função que mostra a equipe
        /// </summary>
        public void Equipe () {
            System.Console.Write ("Você é da equipe Vingadores!!\n\n");
        }

        /// <summary>
        /// Pular é um objeto de caracteristica herdada pelos dois personagens
        /// </summary>
        public void Pular () {
            atGeral.Pular = true;
            System.Console.WriteLine ("Personagem Pulou!");
        }

        /// <summary>
        /// Função da cor do Capitão América
        /// </summary>
        public ConsoleColor CapitaoAmerica () {
            Console.Clear ();
            atGeral.CorTexto = Console.BackgroundColor = ConsoleColor.Black;
            atGeral.CorTexto = Console.ForegroundColor = ConsoleColor.Blue;
            return atGeral.CorTexto;
        }

        /// <summary>
        /// Função que mostra a cor do homen de ferro   
        /// </summary>
        public ConsoleColor HomemDeFerro () {
            Console.Clear ();
            atGeral.CorTexto = ConsoleColor.Black;
            atGeral.CorTexto = Console.ForegroundColor = ConsoleColor.Red;
            return atGeral.CorTexto;
        }

        public void CorPadrao(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}