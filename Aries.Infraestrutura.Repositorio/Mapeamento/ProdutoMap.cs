using Aries.Dominio.Entidades.Produto;
using System.Data.Entity.ModelConfiguration;

namespace Aries.Infraestrutura.Repositorio.Mapeamento
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("PRODUTO");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID_PRODUTO");
            Property(x => x.Descricao).HasColumnName("DS_PRODUTO").IsRequired();
            Property(x => x.Valor).HasColumnName("VL_PRODUTO").IsRequired();
            Property(x => x.EAN).HasColumnName("CD_EAN").IsRequired();
            Property(x => x.Prateleira).HasColumnName("DS_PRATELEIRA").IsOptional();
        }
    }
}