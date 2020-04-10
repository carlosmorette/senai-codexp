using System;
using System.Collections.Generic;
using Exercício_1.Models;

namespace Exercício_1.Controllers {
    public class AlunoController {

        public void Aluno () {

            // Chamamos a lista e chamamos ela de alCons
            List<AlunoModel> alCons = new List<AlunoModel> ();

            alCons.Add (new AlunoModel ("Carlos ", "Code XP", 17, 542284790, true));
            alCons.Add (new AlunoModel ("Vitoria ", "Gastronomia", 20, 346542987, false));
            alCons.Add (new AlunoModel ("Alberto ", "Direito", 23, 651937245, true));
            alCons.Add (new AlunoModel ("Leticia ", "Informática", 25, 875612309, false));
            alCons.Add (new AlunoModel ("Marcia ", "Engenharua", 30, 978653410, true));

            /*
                Aqui mostramos os elementos atribuitos dentro de cada objeto
                No caso mostramos os nomes (Carlos, Vitoria, Alberto...)
                E mostramos também a Idade (17, 20, 23...)
            
            */
            foreach (AlunoModel MostAluMod in alCons) {
                System.Console.Write (MostAluMod.Nome);
                System.Console.WriteLine (MostAluMod.Idade);
            }
            System.Console.WriteLine("========");

            System.Console.Write(alCons[2].Nome);
            System.Console.WriteLine(alCons[2].Bolsista);

        }
    }
}