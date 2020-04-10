using System;
using Exercício_2.Controllers;

namespace Exercício_2 {
    class Program {
        static void Main (string[] args) {

            CelularControllers clControl = new CelularControllers ();

            Console.Clear ();

            clControl.CadCelular ();

            clControl.Desligar ();
            clControl.Ligado ();

            clControl.Ligacao ();
            clControl.Enviar ();


            //É interessante entender o processo, aqui o Celular Desliga e Liga assim executando a Ligação e Enviando a Mensagem

        }
    }
}