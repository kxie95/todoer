namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDateTime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TaskItem", "ScheduledTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaskItem", "ScheduledTime", c => c.DateTime(nullable: false));
        }
    }
}
