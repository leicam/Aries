namespace Aries.Infraestrutura.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Unificada_1000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CLIENTE",
                c => new
                    {
                        ID_CLIENTE = c.Guid(nullable: false),
                        NM_CLIENTE = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SN_CLIENTE = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_CLIENTE)                ;
            
            CreateTable(
                "CLIENTE_DOCUMENTO",
                c => new
                    {
                        ID_DOCUMENTO = c.Guid(nullable: false),
                        VL_DOCUMENTO = c.String(nullable: false, unicode: false),
                        ID_CLIENTE = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID_DOCUMENTO)                
                .ForeignKey("CLIENTE", t => t.ID_CLIENTE, cascadeDelete: true)
                .Index(t => t.ID_CLIENTE);
            
            CreateTable(
                "CLIENTE_EMAIL",
                c => new
                    {
                        ID_EMAIL = c.Guid(nullable: false),
                        VL_EMAIL = c.String(nullable: false, unicode: false),
                        ID_CLIENTE = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID_EMAIL)                
                .ForeignKey("CLIENTE", t => t.ID_CLIENTE, cascadeDelete: true)
                .Index(t => t.ID_CLIENTE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CLIENTE_EMAIL", "ID_CLIENTE", "CLIENTE");
            DropForeignKey("CLIENTE_DOCUMENTO", "ID_CLIENTE", "CLIENTE");
            DropIndex("CLIENTE_EMAIL", new[] { "ID_CLIENTE" });
            DropIndex("CLIENTE_DOCUMENTO", new[] { "ID_CLIENTE" });
            DropTable("CLIENTE_EMAIL");
            DropTable("CLIENTE_DOCUMENTO");
            DropTable("CLIENTE");
        }
    }
}
