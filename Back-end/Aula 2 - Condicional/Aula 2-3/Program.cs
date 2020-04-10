using System;

namespace Aula_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            /*
            Como ja atribuimos anteriormente, mudamos 
            o estada da variavel para verdadeira caso
            entre nessa condição
             */
            if(idade > 17){
                entrada = true;
            }

            if(entrada == true){
                retorno = "Entrada permitida!!!";
            }else{
                retorno = "Entrada não permitida :(";
            }
            
            Console.WriteLine(retorno);

        }
    }
}
