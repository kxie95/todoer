using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class TaskItem
    {
        public int TaskItemID { get; set; }
        public DateTime ScheduledTime { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

    }
}