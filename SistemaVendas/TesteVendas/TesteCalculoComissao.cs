using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas;

namespace TesteVendas
{
    [TestClass]
    public class TesteCalculoComissao
    {
        [TestMethod]
        public void Valor_inteiro_menor_de_10000_retorna_5_porcento()
        {
            int valorVenda = 1000;
            int valorEsperado = 50;
            double retorno = 0;

            retorno = CalculadoraComissao.Calcular(valorVenda);

            Assert.AreEqual(valorEsperado, retorno);
        }

        [TestMethod]
        public void Valor_igual_10000_retorna_5_porcento()
        {
            int valorVenda = 10000;
            int valorEsperado = 500;
            double retorno = 0;

            retorno = CalculadoraComissao.Calcular(valorVenda);

            Assert.AreEqual(valorEsperado, retorno);
        }

        [TestMethod]
        public void Valor_real_menor_de_10000_retorna_5_porcento_arredondado()
        {
            double valorVenda = 1.99;
            double valorEsperado = 0.09;
            double retorno = 0;

            retorno = CalculadoraComissao.Calcular(valorVenda);

            Assert.AreEqual(valorEsperado, retorno);
        }
    }
}