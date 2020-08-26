namespace Aries.Infraestrutura.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Unificada_1_0_0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLIENTE",
                c => new
                    {
                        ID_CLIENTE = c.Guid(nullable: false),
                        NM_CLIENTE = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SN_CLIENTE = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_CLIENTE);
            
            CreateTable(
                "dbo.CLIENTE_DOCUMENTO",
                c => new
                    {
                        ID_DOCUMENTO = c.Guid(nullable: false),
                        VL_DOCUMENTO = c.String(nullable: false, unicode: false),
                        ID_CLIENTE = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID_DOCUMENTO)
                .ForeignKey("dbo.CLIENTE", t => t.ID_CLIENTE, cascadeDelete: true)
                .Index(t => t.ID_CLIENTE);
            
            CreateTable(
                "dbo.CLIENTE_EMAIL",
                c => new
                    {
                        ID_EMAIL = c.Guid(nullable: false),
                        VL_EMAIL = c.String(nullable: false, unicode: false),
                        ID_CLIENTE = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID_EMAIL)
                .ForeignKey("dbo.CLIENTE", t => t.ID_CLIENTE, cascadeDelete: true)
                .Index(t => t.ID_CLIENTE);
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        ID_PRODUTO = c.Guid(nullable: false),
                        CD_EAN = c.Int(nullable: false),
                        DS_PRODUTO = c.String(nullable: false, unicode: false),
                        VL_PRODUTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DS_PARTELEIRA = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CLIENTE_EMAIL", "ID_CLIENTE", "dbo.CLIENTE");
            DropForeignKey("dbo.CLIENTE_DOCUMENTO", "ID_CLIENTE", "dbo.CLIENTE");
            DropIndex("dbo.CLIENTE_EMAIL", new[] { "ID_CLIENTE" });
            DropIndex("dbo.CLIENTE_DOCUMENTO", new[] { "ID_CLIENTE" });
            DropTable("dbo.PRODUTO");
            DropTable("dbo.CLIENTE_EMAIL");
            DropTable("dbo.CLIENTE_DOCUMENTO");
            DropTable("dbo.CLIENTE");
        }
    }
}
