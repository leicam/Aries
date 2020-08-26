using Aries.Dominio.Entidades.Cliente;
using System.Data.Entity.ModelConfiguration;

namespace Aries.Infraestrutura.Repositorio.Mapeamento
{
    internal class DocumentoMap : EntityTypeConfiguration<Documento>
    {
        public DocumentoMap()
        {
            ToTable("CLIENTE_DOCUMENTO");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID_DOCUMENTO").IsRequired();
            Property(x => x.IdCliente).HasColumnName("ID_CLIENTE").IsRequired();
            Property(x => x.Valor).HasColumnName("VL_DOCUMENTO").IsRequired();

            HasRequired(x => x.Cliente).WithMany(x => x.Documentos).HasForeignKey(x => new { x.IdCliente });
        }
    }
}
