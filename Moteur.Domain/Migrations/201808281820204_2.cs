namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL");
            DropIndex("dbo.T_CNX", new[] { "Utilisateur_Cle" });
            DropColumn("dbo.T_CNX", "Utilisateur_Cle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.T_CNX", "Utilisateur_Cle", c => c.Int());
            CreateIndex("dbo.T_CNX", "Utilisateur_Cle");
            AddForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL", "CLE");
        }
    }
}
