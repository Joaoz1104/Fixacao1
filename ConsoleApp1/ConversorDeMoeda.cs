using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConversorDeMoeda
    {
        private readonly double Cotaçao = 5.00;
        public double Dolar { get; set; }
        double Valor = 0;
        public double ValorReais()
        {
            Valor = (Cotaçao * Dolar) * 6 / 100 + (Cotaçao * Dolar);
            return Valor;
        }
        public override string ToString()
        {
            return $"Valor a ser pago em reais: {ValorReais()}";
        }
    }
}
