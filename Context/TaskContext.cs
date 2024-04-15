using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;

namespace ToDoApp.Context
{
    // TaskContext class for interacting with the database
    public class TaskContext : DbContext
    {
        // Constructor
        public TaskContext() : base()
        {

        }

        // DbSet to interact with the Task entity in the database
        public DbSet<Entity.Task> Tasks { get; set; }

        // Method to configure the database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection to use SQL Server
            optionsBuilder.UseSqlServer(@"Server=.;Database=TaskDB;Trusted_Connection=True;TrustServerCertificate=True;");
            
        }

        
    }
}
