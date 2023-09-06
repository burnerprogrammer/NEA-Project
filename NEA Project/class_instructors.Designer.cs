namespace NEA_Project
{
    partial class class_instructors
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
            BTNyoga_instructor = new Button();
            BTNswimming_instructor = new Button();
            BTNkarate_instructor = new Button();
            BTNwomans_self_defence_instructor = new Button();
            BTNbadminton_instructor = new Button();
            SuspendLayout();
            // 
            // BTNyoga_instructor
            // 
            BTNyoga_instructor.Location = new Point(100, 38);
            BTNyoga_instructor.Name = "BTNyoga_instructor";
            BTNyoga_instructor.Size = new Size(75, 23);
            BTNyoga_instructor.TabIndex = 0;
            BTNyoga_instructor.Text = "Yoga";
            BTNyoga_instructor.UseVisualStyleBackColor = true;
            BTNyoga_instructor.Click += button1_Click;
            // 
            // BTNswimming_instructor
            // 
            BTNswimming_instructor.Location = new Point(181, 38);
            BTNswimming_instructor.Name = "BTNswimming_instructor";
            BTNswimming_instructor.Size = new Size(75, 23);
            BTNswimming_instructor.TabIndex = 1;
            BTNswimming_instructor.Text = "Swimming";
            BTNswimming_instructor.UseVisualStyleBackColor = true;
            BTNswimming_instructor.Click += button2_Click;
            // 
            // BTNkarate_instructor
            // 
            BTNkarate_instructor.Location = new Point(262, 38);
            BTNkarate_instructor.Name = "BTNkarate_instructor";
            BTNkarate_instructor.Size = new Size(75, 23);
            BTNkarate_instructor.TabIndex = 2;
            BTNkarate_instructor.Text = "Karate";
            BTNkarate_instructor.UseVisualStyleBackColor = true;
            BTNkarate_instructor.Click += BTNkarate_instructor_Click;
            // 
            // BTNwomans_self_defence_instructor
            // 
            BTNwomans_self_defence_instructor.Location = new Point(343, 38);
            BTNwomans_self_defence_instructor.Name = "BTNwomans_self_defence_instructor";
            BTNwomans_self_defence_instructor.Size = new Size(131, 23);
            BTNwomans_self_defence_instructor.TabIndex = 3;
            BTNwomans_self_defence_instructor.Text = "Womans self defence";
            BTNwomans_self_defence_instructor.UseVisualStyleBackColor = true;
            BTNwomans_self_defence_instructor.Click += BTNwomans_self_defence_instructor_Click;
            // 
            // BTNbadminton_instructor
            // 
            BTNbadminton_instructor.Location = new Point(480, 38);
            BTNbadminton_instructor.Name = "BTNbadminton_instructor";
            BTNbadminton_instructor.Size = new Size(75, 23);
            BTNbadminton_instructor.TabIndex = 4;
            BTNbadminton_instructor.Text = "Badminton";
            BTNbadminton_instructor.UseVisualStyleBackColor = true;
            BTNbadminton_instructor.Click += BTNbadminton_instructor_Click;
            // 
            // class_instructors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNbadminton_instructor);
            Controls.Add(BTNwomans_self_defence_instructor);
            Controls.Add(BTNkarate_instructor);
            Controls.Add(BTNswimming_instructor);
            Controls.Add(BTNyoga_instructor);
            Name = "class_instructors";
            Text = "class_instructors";
            ResumeLayout(false);
        }

        #endregion

        private Button BTNyoga_instructor;
        private Button BTNswimming_instructor;
        private Button BTNkarate_instructor;
        private Button BTNwomans_self_defence_instructor;
        private Button BTNbadminton_instructor;
    }
}