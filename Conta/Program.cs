using System;
using System.Globalization;

namespace Conta {
    class Program {
        static void Main(string[] args) {

            Cotacao func = new Cotacao();

            Console.Write("Qual é a cotação do dolar?  ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cotacaoFinal = func.Conversao(cotacao, compra);
            double iofFinal = func.Iof(cotacaoFinal) + cotacaoFinal;

            Console.Write("Valor a ser pago em reais = " + iofFinal, "F2", CultureInfo.InvariantCulture);


        }
    }
}

