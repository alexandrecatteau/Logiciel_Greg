namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_UTL",
                c => new
                {
                    CLE = c.Int(nullable: false, identity: true),
                    NOM = c.String(),
                    Etat = c.Int(),
                })
                .PrimaryKey(t => t.CLE);
        }
        
        public override void Down()
        {
        }
    }
}
