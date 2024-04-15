using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ToDoApp.Entity
{

    // Task entity class representing tasks in the application
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; } // Unique identifier for the task

        [Required]
        public string TaskName { get; set; } // Name of the task

        [Required]
        public string TaskDescription { get; set; } // Description of the task

        [Required]
        public DateTime TaskDueDate { get; set; } // Due date of the task

        [Required]
        public string TaskStatus { get; set; }  // Status of the task (e.g., Pending, In Progress, Completed)
    }
}
