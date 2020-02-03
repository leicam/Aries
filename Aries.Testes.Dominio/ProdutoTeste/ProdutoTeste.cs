using Aries.Dominio.Entidades.Produto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Testes.Dominio.ProdutoTeste
{
    [TestClass]
    public class ProdutoTeste
    {
        [TestMethod]
        public void ProdutoValido()
        {
            try
            {
                var produto = new Produto();
                produto.Descricao = "TESTE";
                produto.EAN = 123456789;
                produto.Valor = 19.90m;

                if (string.IsNullOrEmpty(produto.Id.ToString()))
                    throw new ArgumentException("Produto inválido!");
            }
            catch(ArgumentException ex)
            {
                Assert.Fail($"Erro ao criar novo produto: {ex.Message}");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Erro ao criar novo produto: {ex.Message}");
            }
        }
    }
}