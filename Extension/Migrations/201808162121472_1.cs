namespace Extension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.T_ERR_EXT", newName: "T_ERR");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.T_ERR", newName: "T_ERR_EXT");
        }
    }
}
