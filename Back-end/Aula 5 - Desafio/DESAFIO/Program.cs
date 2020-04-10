    using System;

    namespace Desafio {
        class Program {
            static void Main (string[] args) {
                Console.WriteLine ("DESAFIO");

                string[] nome = new string[5];
                string[] origem = new string[5];
                string[] destino = new string[5];
                DateTime[] data_ida = new DateTime[5];
                DateTime[] data_volta = new DateTime[5];

                string sair = "";

                while (sair != "0") {

                    Console.Write ("Bem vindo ao nosso sistema de Passagem!");
                    Console.WriteLine ("\nMenu : \n 1- Cadastrar\n 2- Listar passagem\n 0- Sair");

                    sair = Console.ReadLine ();
                    NewMethod (nome, origem, destino, data_ida, data_volta, sair);

                }

            }

            private static void NewMethod (string[] nome, string[] origem, string[] destino, DateTime[] data_ida, DateTime[] data_volta, string sair) {
                NewMethod1 (nome, origem, destino, data_ida, data_volta, sair);
            }

            private static void NewMethod1 (string[] nome, string[] origem, string[] destino, DateTime[] data_ida, DateTime[] data_volta, string sair) {
                NewMethod2 (nome, origem, destino, data_ida, data_volta, sair);
            }

            private static void NewMethod2 (string[] nome, string[] origem, string[] destino, DateTime[] data_ida, DateTime[] data_volta, string sair) {
                NewMethod3 (nome, origem, destino, data_ida, data_volta, sair);
            }

            private static void NewMethod3 (string[] nome, string[] origem, string[] destino, DateTime[] data_ida, DateTime[] data_volta, string sair) {
                switch (sair) {
                    case "1":
                        for (int i = 0; i <= 5; i++) {
                            Console.Write ("Entre com o nome do passageiro: ");
                            nome[i] = Console.ReadLine ();

                            Console.Write ("Digite a UF de origem: ");
                            origem[i] = Console.ReadLine ();

                            Console.Write ("Digite o destino: ");
                            destino[i] = Console.ReadLine ();

                            Console.Write ("Digite a Data de Ida: ");
                            data_ida[i] = DateTime.Parse (Console.ReadLine ());

                            Console.Write ("Digite a Data de Volta: ");
                            data_volta[i] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso! :)");
                        }
                        break;
                case "2":
                    for (int i = 0; i <= 4; i++) {
                        if (nome[i] != "" && origem[i] != "" && destino[i] != "" && data_ida[i] != null && data_volta[i] != null) {
                            Console.WriteLine ();
                            Console.WriteLine ($"Passagem Nº{i + 1}");

                            Console.WriteLine (nome[i]);
                            Console.WriteLine (origem[i]);
                            Console.WriteLine (destino[i]);
                            Console.WriteLine (data_ida[i]);
                            Console.WriteLine (data_volta[i]);
                            Console.WriteLine ();
                        }
                        break;
                    }
                case "0":
                    Console.WriteLine ("Obrigado por utilizar nosso sistema!");
                    break;
                default:
                    Console.WriteLine ("Entrada Inválida!");
                    break;
            }
        }
    }
    }