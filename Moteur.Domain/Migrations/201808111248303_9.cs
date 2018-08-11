namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.T_UTL", "Droit_Cle", "dbo.T_DRT");
            DropIndex("dbo.T_UTL", new[] { "Droit_Cle" });
            DropColumn("dbo.T_UTL", "Droit_Cle");
            DropTable("dbo.T_DRT");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.T_DRT",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
            AddColumn("dbo.T_UTL", "Droit_Cle", c => c.Int());
            CreateIndex("dbo.T_UTL", "Droit_Cle");
            AddForeignKey("dbo.T_UTL", "Droit_Cle", "dbo.T_DRT", "CLE");
        }
    }
}
