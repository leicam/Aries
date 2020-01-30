using Aries.Aplicacao.Interfaces;
using Aries.Dominio.Builders;
using Aries.Dominio.Entidades.Cliente;
using Aries.DTO.Cliente;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;

namespace Aries.Aplicacao.Servicos
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AddOrUpdate(ClienteDTO dto)
        {
            try
            {
                var registro = new ClienteBuilder()
                    .ComDocumento(dto.Documento)
                    .ComEmail(dto.Email)
                    .ComNome(dto.Nome)
                    .ComSobrenome(dto.Sobrenome)
                    .Build();

                _clienteRepositorio.AdicionarOuAlterar(registro);
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public List<ClienteDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}