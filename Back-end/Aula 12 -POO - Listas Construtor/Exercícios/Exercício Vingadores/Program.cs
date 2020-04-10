using System;
using Exercício_Vingadores.Controllers;

namespace Exercício_Vingadores {
    class Program {
        static void Main (string[] args) {

            //Lembrando que deu erro devido ao Controller estar com o nome Vingadores
            AtributosGeraisController atControl = new AtributosGeraisController ();

            CapitaoAmericaController capControl = new CapitaoAmericaController ();

            HomemdeFerroController homControl = new HomemdeFerroController ();

            //Iniciando o programa com a cor padrão
            atControl.CorPadrao ();

            Console.Clear ();

            // Declaração de variáveis
            string a = "", e = "", novamente = "", b = "";

            System.Console.WriteLine ("JOGO DOS VINGADORES\n");

            //Variável de decisão de Jogar Novamente
            while (novamente != "0") {
                System.Console.WriteLine ("Escolha seu personagem: ");
                System.Console.WriteLine ("\t1.Capitão América\n\t2.Homem de Ferro");
                System.Console.Write ("Personagem: ");
                e = Console.ReadLine ();

                if (e == "1") {
                    atControl.CapitaoAmerica ();
                    atControl.Equipe ();
                    capControl.Escudo ();
                    Console.Write (atControl.Vida ());

                    while (a != "0") {
                        //Pedindo para escolher a Ação
                        System.Console.WriteLine ("\n\t1.Pular\n\t2.Lançar Escudo\n\t3.Defender-se com Escudo\n\t0.Sair");
                        System.Console.Write ("Escolha sua ação: ");
                        a = Console.ReadLine ();

                        //Opções de Ações do personagem
                        if (a == "1") {

                            System.Console.Write ("===================\nAÇÃO:");
                            atControl.Pular ();
                            System.Console.WriteLine ("===================");

                        } else if (a == "2") {

                            System.Console.Write ("===================\nAÇÃO:");
                            capControl.LancarEscudo ();
                            System.Console.WriteLine ("===================");

                        } else if (a == "3") {

                            System.Console.Write ("===================\nAÇÃO:");
                            capControl.Defender ();
                            System.Console.WriteLine ("===================");

                        } else if (a == "0") {

                            System.Console.WriteLine ("\nSaindo!");
                            System.Console.WriteLine ();

                        }
                    }

                    //Opção 2, jogar com o Homem de Ferro
                } else if (e == "2") {
                    atControl.HomemDeFerro ();
                    atControl.Equipe ();
                    homControl.Armadura ();
                    System.Console.WriteLine (atControl.Vida ());

                    while (b != "0") {
                        System.Console.WriteLine ("\t1.Pular\n\t2.Voar\n\t3.Atirar\n\t0.Sair");
                        System.Console.Write ("Escolha sua ação: ");
                        b = Console.ReadLine ();

                        if (b == "1") {

                            System.Console.Write ("===================\nAÇÃO:");
                            atControl.Pular ();
                            System.Console.WriteLine ("===================");

                        } else if (b == "2") {

                            System.Console.Write ("===================\nAÇÃO:");
                            homControl.Voar ();
                            System.Console.WriteLine ("===================");

                        } else if (b == "3") {

                            System.Console.Write ("===================\nAÇÃO:");
                            homControl.Atirar ();
                            System.Console.WriteLine ("===================");

                        } else if (b == "0") {

                            System.Console.WriteLine ("\nSaindo!\n");
                        }

                    }
                } else {
                    System.Console.WriteLine ("Opção Inválida!");
                }

                //Voltando a cor original do console na hora de fazer a pergunta
                atControl.CorPadrao ();

                // Perguntando se o usuário deseja jogar novamente!
                System.Console.WriteLine ("Deseja jogar novamente?");
                System.Console.WriteLine ("\t1.Sim\n\t0.Não");
                System.Console.Write ("Escolha: ");
                novamente = Console.ReadLine ();
            }

            //Cor padrão
            atControl.CorPadrao ();

            System.Console.WriteLine ("Thanks for playing with us!");

        }
    }
}