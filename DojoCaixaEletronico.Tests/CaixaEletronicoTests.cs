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
        CaixaEletronico caixaEletronico = new CaixaEletronico();

        [TestMethod]
        public void DeveSacar0QuandoPedido0()
        {
            Assert.IsNotNull(caixaEletronico.saque(0));
        }

        [TestMethod]
        public void DeveSacarUmaNotaDe10QuandoPedir10()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(10);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(10, 1);
            CollectionAssert.AreEqual(notas, resultado);
        }

        [TestMethod]
        public void DeveSacarUmaNotaDe20QuandoPedir20()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(20);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(20, 1);
            CollectionAssert.AreEquivalent(notas, resultado);
        }

        [TestMethod]
        public void DeveSacarUmaNotaDe10EUmaDe20QuandoPedir30()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(30);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(20, 1);
            resultado.Add(10, 1);
            CollectionAssert.AreEquivalent(notas, resultado);
        }

        [TestMethod]
        public void DeveSacarDuasDe20QuandoPedir40()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(40);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(20, 2);
            CollectionAssert.AreEquivalent(notas, resultado);
        }

        [TestMethod]
        public void DeveSacarUmaDe50QuandoPedir50()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(50);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(50, 1);
            CollectionAssert.AreEquivalent(notas, resultado);
        }

        [TestMethod]
        public void DeveSacarUmaDe100QuandoPedir100()
        {
            Dictionary<int, int> notas = caixaEletronico.saque(100);
            Dictionary<int, int> resultado = new Dictionary<int, int>();
            resultado.Add(100, 1);
            CollectionAssert.AreEquivalent(notas, resultado);
        }
    }
}
