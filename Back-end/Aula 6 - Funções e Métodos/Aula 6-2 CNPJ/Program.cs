using System;

namespace exemploCnpj
{
    class Program
    {
        static void Main(string[] args)
        {
            string cnpj;

            Console.WriteLine("Exemplo CNPJ\n");

            Console.Write("Insira o CNPJ para teste: ");
            cnpj = Console.ReadLine();

            Console.WriteLine(ValidaCnpj(cnpj));            
        }

        static bool ValidaCnpj(string cnpjUsuario){

            bool resultado = false;
            
            int[] v1 = {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};
            int[] v2 = {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};            

            string cnpjCalculo = "";
            string digitoVerificador1 = "";
            string digitoVerificador2 = "";

            int calculo = 0;
            int resto = 0;

            cnpjUsuario = cnpjUsuario.Replace("/","");
            cnpjUsuario = cnpjUsuario.Replace(".","");
            cnpjUsuario = cnpjUsuario.Replace("-", "");
            cnpjUsuario = cnpjUsuario.Replace(" ", "");

            cnpjCalculo = cnpjUsuario.Substring(0, 12);

            for(int i = 0; i < 12; i++) {
                calculo = calculo + (int.Parse(cnpjCalculo[i].ToString()) * v1[i]);
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(resto < 2) {
                digitoVerificador1 = "0";
            } else {
                digitoVerificador1 = calculo.ToString();
            }

            if(digitoVerificador1 == cnpjUsuario[12].ToString()) {
                resultado = true;
            }

            cnpjCalculo = cnpjCalculo + digitoVerificador1;

            resto = 0;
            calculo = 0;

            for(int i = 0; i < 13; i++) {
                calculo = calculo + (int.Parse(cnpjCalculo[i].ToString()) * v2[i]);
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(resto < 2) {
                digitoVerificador2 = "0";
            } else {
                digitoVerificador2 = calculo.ToString();
            }

            if(digitoVerificador2 == cnpjUsuario[13].ToString()) {
                resultado = true;
            } else {
                resultado = false;
            }

            return resultado;
        }
    }
}