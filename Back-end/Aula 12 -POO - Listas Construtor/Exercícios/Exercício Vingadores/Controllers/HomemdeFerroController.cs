using Exercício_Vingadores.Models;

namespace Exercício_Vingadores.Controllers {
    public class HomemdeFerroController {
        
        HomemdeFerroModel homMod = new HomemdeFerroModel ();

        /// <summary>
        /// Função Armadura Homem de Ferro
        /// </summary>
        public void Armadura () {
            System.Console.WriteLine ("Você está de Armadura!");
        }

        /// <summary>
        /// Função que voa
        /// </summary>
        public void Voar () {
            homMod.Voar = true;
            System.Console.WriteLine ("Homem de Ferro está Voando!");
        }

        /// <summary>
        /// Função que atira
        /// </summary>
        public void Atirar () {
            homMod.Atirar = true;
            System.Console.WriteLine ("Homem de Ferro está Atirando!");
        }


    }
}