using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaVendas;

namespace TesteVendas
{
    public class CalculadoraRoyalties
    {
        IRepositorioVendas repVendas;
        public CalculadoraRoyalties(IRepositorioVendas repVendas)
        {
            this.repVendas = repVendas;
        }

        public double Calcular(int mes, int ano)
        {
            List<double> valoresVendas = repVendas.GetVendas(mes, ano);

            double totalVendaLiquida = 0;

            for (int i = 0; i < valoresVendas.Count; i++)
            {
                double comissao = CalculadoraComissao.Calcular(valoresVendas[i]);
                totalVendaLiquida += (valoresVendas[i] -  comissao ) ;
            }

            
            return totalVendaLiquida * 0.2 ;
        }


    }

}
