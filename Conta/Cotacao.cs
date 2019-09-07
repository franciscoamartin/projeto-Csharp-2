using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Conta {
    class Cotacao {

        public double valor;
        public double dolar;
        public double iof = 6;



        public double Conversao(double valor, double dolar) {
            return (valor * dolar);
        }

        public double Iof(double dolar) {
            return (iof * dolar / 100.00);
        }


    }
}
