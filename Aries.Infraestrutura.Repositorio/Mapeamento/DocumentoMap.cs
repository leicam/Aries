using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Mapeamento
{
    internal class DocumentoMap : EntityTypeConfiguration<Documento>
    {
        public DocumentoMap()
        {
            ToTable("CLIENTE_DOCUMENTO");
            HasKey(x => x.Id);
            HasRequired(x => x.Cliente).WithMany(x => x.Documentos).Map(x => x.MapKey("ID_CLIENTE"));

            Property(x => x.Id).HasColumnName("ID_DOCUMENTO").IsRequired();
            Property(x => x.Cliente.Id).HasColumnName("ID_CLIENTE").IsRequired();
            Property(x => x.Valor).HasColumnName("VL_DOCUMENTO").IsRequired();
        }
    }
}
