namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.T_UTL", "NOM", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.T_UTL", new[] { "NOM" });
        }
    }
}
