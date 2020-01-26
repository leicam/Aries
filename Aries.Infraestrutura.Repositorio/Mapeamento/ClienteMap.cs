using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Mapeamento
{
    internal class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("CLIENTE");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID_CLIENTE").IsRequired();
            Property(x => x.Nome).HasColumnName("NM_CLIENTE").HasMaxLength(100).IsVariableLength().IsRequired();
            Property(x => x.Sobrenome).HasColumnName("SN_CLIENTE").HasMaxLength(100).IsVariableLength().IsRequired();
        }
    }
}
