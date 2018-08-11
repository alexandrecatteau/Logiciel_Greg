namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.T_UTL", "Droit_Cle", "dbo.T_DRT");
            //DropIndex("dbo.T_UTL", new[] { "Droit_Cle" });
            //DropTable("dbo.T_DRT");
            //DropTable("dbo.T_UTL");

            CreateTable(
                "dbo.T_UTL",
                c => new
                {
                    CLE = c.Int(nullable: false, identity: true),
                    NOM = c.String(),
                    Droit_Cle = c.Int(),
                })
                .PrimaryKey(t => t.CLE);

            CreateTable(
                "dbo.T_DRT",
                c => new
                {
                    CLE = c.Int(nullable: false, identity: true),
                    NOM = c.String(),
                })
                .PrimaryKey(t => t.CLE);

            CreateIndex("dbo.T_UTL", "Droit_Cle");
            AddForeignKey("dbo.T_UTL", "Droit_Cle", "dbo.T_DRT", "CLE");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.T_UTL",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(),
                        Droit_Cle = c.Int(),
                    })
                .PrimaryKey(t => t.CLE);
            
            CreateTable(
                "dbo.T_DRT",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
            CreateIndex("dbo.T_UTL", "Droit_Cle");
            AddForeignKey("dbo.T_UTL", "Droit_Cle", "dbo.T_DRT", "CLE");
        }
    }
}
