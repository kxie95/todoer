namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskItemUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaskItem", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaskItem", "Description", c => c.String());
        }
    }
}
