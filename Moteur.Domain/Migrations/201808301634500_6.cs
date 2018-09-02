namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL");
            DropIndex("dbo.T_CNX", new[] { "Utilisateur_Cle" });
            RenameColumn(table: "dbo.T_CNX", name: "Utilisateur_Cle", newName: "CleUtilisateur");
            AlterColumn("dbo.T_CNX", "CleUtilisateur", c => c.Int(nullable: false));
            CreateIndex("dbo.T_CNX", "CleUtilisateur");
            AddForeignKey("dbo.T_CNX", "CleUtilisateur", "dbo.T_UTL", "CLE", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_CNX", "CleUtilisateur", "dbo.T_UTL");
            DropIndex("dbo.T_CNX", new[] { "CleUtilisateur" });
            AlterColumn("dbo.T_CNX", "CleUtilisateur", c => c.Int());
            RenameColumn(table: "dbo.T_CNX", name: "CleUtilisateur", newName: "Utilisateur_Cle");
            CreateIndex("dbo.T_CNX", "Utilisateur_Cle");
            AddForeignKey("dbo.T_CNX", "Utilisateur_Cle", "dbo.T_UTL", "CLE");
        }
    }
}
