namespace Aries.Infraestrutura.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Unificada_1100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        ID_PRODUTO = c.Guid(nullable: false),
                        CD_EAN = c.Int(nullable: false),
                        DS_PRODUTO = c.String(nullable: false, unicode: false),
                        VL_PRODUTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PRODUTO");
        }
    }
}
