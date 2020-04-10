using System;
using System.Collections.Generic;
using Exercício_2.Models;

namespace Exercício_2.Controllers {
    public class CelularControllers {


        CelularModel clModel = new CelularModel0();
        
        public void CadCelular () {

            List<CelularModel> ListCelModel = new List<CelularModel> ();

            string sair = "";

            while (sair != "0") {
                System.Console.WriteLine ("Digite a cor: ");
                string cor = Console.ReadLine ();

                System.Console.WriteLine ("Digite o modelo: ");
                string modelo = Console.ReadLine ();

                System.Console.WriteLine ("Digite o Tamanho: ");
                float tamanho = float.Parse (Console.ReadLine ());

                ListCelModel.Add (new CelularModel (cor, modelo, tamanho));

                System.Console.WriteLine ("Deseja sair? ");
                sair = Console.ReadLine ();
            }

            foreach (CelularModel p in ListCelModel) {
                System.Console.WriteLine (p.Cor);
                System.Console.WriteLine (p.Modelo);
                System.Console.WriteLine (p.Tamanho);
            }

        }

    }
}