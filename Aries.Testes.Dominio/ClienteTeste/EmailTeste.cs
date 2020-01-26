using Aries.Dominio.Entidades.Cliente;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Testes.Dominio.ClienteTeste
{
    [TestClass]
    public class EmailTeste
    {
        private readonly Cliente _cliente = new Cliente();

        [TestMethod]
        public void EmailInvalido()
        {
            Assert.ThrowsException<ArgumentException>(() => new Email(_cliente, "juliano.macielgmail.com"), "Falha ao validar construção do objeto Email!");
        }

        [TestMethod]
        public void EmailValido()
        {
            try
            {
                var email = new Email(_cliente, "juliano.maciel@gmail.com");
            }
            catch(ArgumentException ex)
            {
                Assert.Fail($"Classe email com excessão {ex.Message}");
            }
        }
    }
}