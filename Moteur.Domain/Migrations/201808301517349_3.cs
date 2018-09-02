namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_CNX", "Utilisateur_Cle", c => c.Int());
            CreateIndex("dbo.T_CNX", "Utilisateur_Cle");
            AddForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL", "CLE");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL");
            DropIndex("dbo.T_CNX", new[] { "Utilisateur_Cle" });
            DropColumn("dbo.T_CNX", "Utilisateur_Cle");
        }
    }
}
