using Aries.Aplicacao.Interfaces;
using Aries.Dominio.Builders;
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

        public string Adicionar(ClienteDTO dto)
        {
            try
            {
                var registro = new ClienteBuilder()
                    .ComDocumento(dto.Documento)
                    .ComEmail(dto.Email)
                    .ComNome(dto.Nome)
                    .ComSobrenome(dto.Sobrenome)
                    .Build();

                _clienteRepositorio.Adicionar(registro);
                return "Cliente cadastrado com sucesso!";
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public List<ClienteDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public string Remover(ClienteDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}