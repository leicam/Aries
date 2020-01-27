using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Mapeamento
{
    internal class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            ToTable("CLIENTE_EMAIL");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID_EMAIL").IsRequired();
            Property(x => x.IdCliente).HasColumnName("ID_CLIENTE").IsRequired();
            Property(x => x.Valor).HasColumnName("VL_EMAIL").IsRequired();

            HasRequired(x => x.Cliente).WithMany(x => x.Emails).HasForeignKey(x => new { x.IdCliente });
        }
    }
}