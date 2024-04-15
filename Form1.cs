using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using ToDoApp.Context;
using ToDoApp.Entity;
using Task = ToDoApp.Entity.Task; // Alias Task to avoid conflict with System.Threading.Tasks.Task

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        // Initialize context and selectedTask variables
        TaskContext context = new TaskContext();
        Task selectedTask = new Task();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridView(); // Load data into the DataGridView when the form loads

        }

        // Method to load data into the DataGridView

        public void LoadGridView()
        {
            dataGridViewTasks.AutoGenerateColumns = false;
            dataGridViewTasks.DataSource = context.Tasks.ToList();
        }

        // Event handler for when a cell in the DataGridView is clicked

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected task from the clicked row
                DataGridViewRow row = dataGridViewTasks.Rows[e.RowIndex];
                int taskId = Convert.ToInt32(row.Cells["TaskId"].Value);
                selectedTask = context.Tasks.FirstOrDefault(x => x.TaskId == taskId);

                // Display the task details in the input fields
                DisplayTaskDetails(selectedTask);
            }
        }

        // Method to display task details in the input fields

        public void DisplayTaskDetails(Task task)
        {
            txtTaskName.Text = task.TaskName;
            txtDescription.Text = task.TaskDescription;
            dateTimePickerDueDate.Value = task.TaskDueDate;
            cboStatus.SelectedItem = task.TaskStatus;
        }

        // Event handler for the Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task TaskAdd = new Task();
            TaskAdd.TaskName = txtTaskName.Text;
            TaskAdd.TaskDescription = txtDescription.Text;
            TaskAdd.TaskStatus = cboStatus.Text;
            TaskAdd.TaskDueDate = dateTimePickerDueDate.Value;

            context.Tasks.Add(TaskAdd);
            context.SaveChanges();

            ClearInputFields();

            LoadGridView();

        }

        // Event handler for the Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTask != null)
            {
                // Update the selected task with input field values
                selectedTask.TaskName = txtTaskName.Text;
                selectedTask.TaskDescription = txtDescription.Text;
                selectedTask.TaskDueDate = dateTimePickerDueDate.Value;
                selectedTask.TaskStatus = cboStatus.Text;

                // Save changes to the context and reload the DataGridView
                context.SaveChanges();

                LoadGridView();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
        }

        // Event handler for the Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTask != null)
            {
                // Ensure that the selected task has a valid TaskId
                if (selectedTask.TaskId != 0)
                {
                    // Remove the selected task from the context and save changes
                    context.Tasks.Remove(selectedTask);
                    context.SaveChanges();

                    // Reload the DataGridView and clear input fields
                    LoadGridView();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cannot delete task without a valid TaskId.");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }


        // Method to clear input fields
        private void ClearInputFields()
        {
            txtTaskName.Text = "";
            txtDescription.Text = "";
            dateTimePickerDueDate.Value = DateTime.Now;
            cboStatus.SelectedIndex = -1;
        }

        
    }
}
