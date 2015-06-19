using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SistemaVendas;
using TesteVendas;


namespace TesteVendas
{
    [TestClass]
    public class RoyaltiesTest
    {

        private Mock<IRepositorioVendas> mockRepository = null;
        private CalculadoraRoyalties calculadoraRoyalties = null;

        [TestInitialize]
        public void TestInit()
        {
            mockRepository = new Mock<IRepositorioVendas>();
            calculadoraRoyalties = new CalculadoraRoyalties(mockRepository.Object);
        }

        [TestMethod]
        public void Calculo_Royalties_com_Valor_No_Mes_Zerado()
        {
            double ValorRoyaltiesEsperado = 0;
            int mes = 3;
            int ano = 2015;
        
            mockRepository
               .Setup(repositorioVenda => repositorioVenda.GetVendas(mes, ano))
               .Returns(new List<double>() );

            double totalRoyalties = calculadoraRoyalties.Calcular(mes, ano);

            Assert.AreEqual(ValorRoyaltiesEsperado, totalRoyalties );

        }

        [TestMethod]
        public void Calculo_Royalties_com_Valor_No_Mes_um()
        {
            double ValorRoyaltiesEsperado = 19;
            int valor = 100;
            int mes = 1;
            int ano = 2015;
        
            mockRepository
               .Setup(repositorioVenda => repositorioVenda.GetVendas(mes, ano))
               .Returns(new List<double>() { valor });

            double totalRoyalties = calculadoraRoyalties.Calcular(mes, ano);

            Assert.AreEqual(ValorRoyaltiesEsperado, totalRoyalties);


        }
    }
}
