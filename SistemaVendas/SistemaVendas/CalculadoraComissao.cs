using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public static class CalculadoraComissao
    {
        private static readonly double PorcentagemComissaoVendaBaixa = 0.05;

        private static double ArredondarComissao(double comissao)
        {
            return Math.Floor(comissao * 100) / 100;
        }

        public static double Calcular(double valorVenda)
        {
            double comissao = valorVenda * PorcentagemComissaoVendaBaixa;
            return ArredondarComissao(comissao);
        }
    }
}
