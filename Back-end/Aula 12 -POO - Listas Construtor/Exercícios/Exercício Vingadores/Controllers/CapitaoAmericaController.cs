using Exercício_Vingadores.Models;

namespace Exercício_Vingadores.Controllers {
    public class CapitaoAmericaController {

        CapitãoAmericaModel capMod = new CapitãoAmericaModel ();

        public void Escudo () {
            System.Console.WriteLine ("Você está de escudo!");
        }

        /// <summary>
        /// Função que Lança o Escudo
        /// </summary>
        public void LancarEscudo () {
            if (capMod.Defender != true) {
                capMod.LancarEscudo = true;
                System.Console.WriteLine ("Capitão América LANÇOU O ESCUDO");
            } else {
                capMod.LancarEscudo = false;
                System.Console.WriteLine ("Impossível Lançar, você está defendendo!");
            }
        }

        /// <summary>
        /// Função que defende
        /// </summary>
        public void Defender () {
            if (capMod.LancarEscudo != true) {
                capMod.Defender = true;
                System.Console.WriteLine ("Capitão Américas DEFENDEU");
            } else {
                capMod.Defender = false;
                System.Console.WriteLine ("Impossível Defender, você lançou o escudo!");
            }
        }
    }
}