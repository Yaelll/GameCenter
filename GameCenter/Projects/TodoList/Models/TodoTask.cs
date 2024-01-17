using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.Projects.TodoList.Models
{
    class TodoTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsComplete { get; set; }

        public TodoTask(int id, string description)
        {
            Id = id;
            Description = description;
            CreateDate = DateTime.Now;
            IsComplete = false;
        }
    }
}

