namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_CNX",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        DATE = c.DateTime(nullable: false),
                        NOMPROJET = c.String(),
                        Utilisateur_Cle = c.Int(),
                    })
                .PrimaryKey(t => t.CLE)
                .ForeignKey("dbo.T_UTL", t => t.Utilisateur_Cle)
                .Index(t => t.Utilisateur_Cle);
            
            CreateTable(
                "dbo.T_ERR",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        DATE = c.DateTime(nullable: false),
                        MESSAGE = c.String(),
                        STACKTRACE = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
            CreateTable(
                "dbo.T_PAR",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(),
                        VALEUR = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
            CreateTable(
                "dbo.T_UTL",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(maxLength: 100),
                        ETAT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CLE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL");
            DropIndex("dbo.T_CNX", new[] { "Utilisateur_Cle" });
            DropTable("dbo.T_UTL");
            DropTable("dbo.T_PAR");
            DropTable("dbo.T_ERR");
            DropTable("dbo.T_CNX");
        }
    }
}
