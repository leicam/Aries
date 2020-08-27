using System;

namespace Aries.DTO.Cliente
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }

        public ClienteDTO() { }

        public ClienteDTO(string nome, string sobrenome, string documento, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
        }

        public ClienteDTO(Guid id, string nome, string sobrenome, string documento, string email)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
        }
    }
}