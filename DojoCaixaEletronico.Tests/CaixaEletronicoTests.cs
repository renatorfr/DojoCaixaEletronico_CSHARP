using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoCaixaEletronico;

namespace DojoCaixaEletronico.Tests
{
    [TestClass]
    public class CaixaEletronicoTests
    {
        [TestMethod]
        public void DeveSacar0QuandoPedido0()
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Assert.IsNotNull(caixaEletronico.saque(0));
        }

        [TestMethod]
        public void DeveSacarUmaNotaDe10QuandoPedir10()
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Dictionary<int, int> notas = caixaEletronico.saque(10);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(10, 1);
            Assert.AreEqual(notas, resultado);
        }
    }
}
