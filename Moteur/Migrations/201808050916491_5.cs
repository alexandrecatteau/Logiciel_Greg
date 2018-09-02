namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.t_erreur", newName: "T_ERR");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.T_ERR", newName: "t_erreur");
        }
    }
}
