namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskItem",
                c => new
                    {
                        TaskItemID = c.Int(nullable: false, identity: true),
                        ScheduledTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TaskItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskItem");
        }
    }
}
