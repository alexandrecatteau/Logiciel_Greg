namespace Moteur.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_PAR",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        NOM = c.String(),
                        VALEUR = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_PAR");
        }
    }
}
