namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.T_CNX", name: "CleUtilisateur", newName: "CLE_UTILISATEUR");
            RenameIndex(table: "dbo.T_CNX", name: "IX_CleUtilisateur", newName: "IX_CLE_UTILISATEUR");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.T_CNX", name: "IX_CLE_UTILISATEUR", newName: "IX_CleUtilisateur");
            RenameColumn(table: "dbo.T_CNX", name: "CLE_UTILISATEUR", newName: "CleUtilisateur");
        }
    }
}
