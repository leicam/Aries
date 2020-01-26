using Aries.Aplicacao.Servicos;
using Aries.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteServico = new ClienteServico();
            var cliente1 = new ClienteDTO("Juliano", "Maciel", "08887953945", "juliano.maciel@gmail.com");
            Console.WriteLine(clienteServico.Adicionar(cliente1));
            var cliente2 = new ClienteDTO("Juliano", "Maciel", "08887953945", "juliano.macielgmail.com");
            Console.WriteLine(clienteServico.Adicionar(cliente2));
            Console.ReadKey();
        }
    }
}
