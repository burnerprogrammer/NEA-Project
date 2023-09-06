namespace NEA_Project
{
    partial class viewbooking
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
            GRIDbooking = new DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            User_name = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            Num_of_slots = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GRIDbooking).BeginInit();
            SuspendLayout();
            // 
            // GRIDbooking
            // 
            GRIDbooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRIDbooking.Columns.AddRange(new DataGridViewColumn[] { BookingID, User_name, ClassName, Time, Instructor, Num_of_slots, Delete });
            GRIDbooking.Location = new Point(12, 12);
            GRIDbooking.Name = "GRIDbooking";
            GRIDbooking.RowTemplate.Height = 25;
            GRIDbooking.Size = new Size(776, 350);
            GRIDbooking.TabIndex = 0;
            GRIDbooking.CellContentClick += GRIDbooking_CellContentClick;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "BookingID";
            BookingID.Name = "BookingID";
            // 
            // User_name
            // 
            User_name.HeaderText = "Username";
            User_name.Name = "User_name";
            // 
            // ClassName
            // 
            ClassName.HeaderText = "ClassName";
            ClassName.Name = "ClassName";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Instructor
            // 
            Instructor.HeaderText = "Instructor";
            Instructor.Name = "Instructor";
            // 
            // Num_of_slots
            // 
            Num_of_slots.HeaderText = "Num of slots";
            Num_of_slots.Name = "Num_of_slots";
            // 
            // Delete
            // 
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // viewbooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GRIDbooking);
            Name = "viewbooking";
            Text = "viewbooking";
            ((System.ComponentModel.ISupportInitialize)GRIDbooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GRIDbooking;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn User_name;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn Num_of_slots;
        private DataGridViewButtonColumn Delete;
    }
}