using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ToDoList.Models
{
    public class TaskItem
    {
        public int TaskItemID { get; set; }
        [Required]
        public string Description { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool IsCompleted { get; set; }

    }
}