using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            dataGridViewTasks = new DataGridView();
            TaskName = new DataGridViewTextBoxColumn();
            TaskId = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewTextBoxColumn();
            TaskDescription = new DataGridViewTextBoxColumn();
            TaskDueDate = new DataGridViewTextBoxColumn();
            label3 = new Label();
            txtTaskName = new TextBox();
            txtDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerDueDate = new DateTimePicker();
            label7 = new Label();
            cboStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Wide Latin", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(300, 19);
            label1.MaximumSize = new Size(200, 40);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(178, 40);
            label1.TabIndex = 0;
            label1.Text = "To Do App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(358, 73);
            label2.MaximumSize = new Size(200, 40);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(75, 40);
            label2.TabIndex = 1;
            label2.Text = "Tasks";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { TaskName, TaskId, TaskStatus, TaskDescription, TaskDueDate });
            dataGridViewTasks.Location = new Point(111, 126);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.RowTemplate.Height = 29;
            dataGridViewTasks.Size = new Size(553, 168);
            dataGridViewTasks.TabIndex = 2;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // TaskName
            // 
            TaskName.DataPropertyName = "TaskName";
            TaskName.HeaderText = "TaskName";
            TaskName.MinimumWidth = 6;
            TaskName.Name = "TaskName";
            TaskName.Width = 125;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "TaskId";
            TaskId.MinimumWidth = 6;
            TaskId.Name = "TaskId";
            TaskId.Visible = false;
            TaskId.Width = 125;
            // 
            // TaskStatus
            // 
            TaskStatus.DataPropertyName = "TaskStatus";
            TaskStatus.HeaderText = "TaskStatus";
            TaskStatus.MinimumWidth = 6;
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Width = 125;
            // 
            // TaskDescription
            // 
            TaskDescription.DataPropertyName = "TaskDescription";
            TaskDescription.HeaderText = "TaskDescription";
            TaskDescription.MinimumWidth = 6;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Width = 125;
            // 
            // TaskDueDate
            // 
            TaskDueDate.DataPropertyName = "TaskDueDate";
            TaskDueDate.HeaderText = "TaskDueDate";
            TaskDueDate.MinimumWidth = 6;
            TaskDueDate.Name = "TaskDueDate";
            TaskDueDate.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(330, 322);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 3;
            label3.Text = "Add/Edit Task";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(275, 379);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(129, 27);
            txtTaskName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(275, 428);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(138, 27);
            txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(153, 379);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(70, 33);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(141, 428);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 7;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(153, 477);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 8;
            label6.Text = "DueDate:";
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Location = new Point(275, 477);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(250, 27);
            dateTimePickerDueDate.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 522);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 10;
            label7.Text = "Status:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            cboStatus.Location = new Point(279, 517);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(141, 582);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Image = Properties.Resources.phn;
            btnUpdate.Location = new Point(342, 575);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = Properties.Resources.cross;
            btnDelete.Location = new Point(516, 575);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 642);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboStatus);
            Controls.Add(label7);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(txtTaskName);
            Controls.Add(label3);
            Controls.Add(dataGridViewTasks);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewTasks;
        private Label label3;
        private TextBox txtTaskName;
        private TextBox txtDescription;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerDueDate;
        private Label label7;
        private ComboBox cboStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskStatus;
        private DataGridViewTextBoxColumn TaskDescription;
        private DataGridViewTextBoxColumn TaskDueDate;
    }
}
