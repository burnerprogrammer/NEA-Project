namespace NEA_Project
{
    partial class Homepage
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
            BTN_classes = new Button();
            BTNbook_member = new Button();
            BTNabout_intructors = new Button();
            BTNview_Bookings = new Button();
            BTNlogout = new Button();
            LBLuser = new Label();
            SuspendLayout();
            // 
            // BTN_classes
            // 
            BTN_classes.Location = new Point(22, 12);
            BTN_classes.Name = "BTN_classes";
            BTN_classes.Size = new Size(75, 23);
            BTN_classes.TabIndex = 0;
            BTN_classes.Text = "Classes ";
            BTN_classes.UseVisualStyleBackColor = true;
            BTN_classes.Click += BTN_classes_Click;
            // 
            // BTNbook_member
            // 
            BTNbook_member.Location = new Point(103, 12);
            BTNbook_member.Name = "BTNbook_member";
            BTNbook_member.Size = new Size(135, 23);
            BTNbook_member.TabIndex = 1;
            BTNbook_member.Text = "Book Membership";
            BTNbook_member.UseVisualStyleBackColor = true;
            // 
            // BTNabout_intructors
            // 
            BTNabout_intructors.Location = new Point(244, 12);
            BTNabout_intructors.Name = "BTNabout_intructors";
            BTNabout_intructors.Size = new Size(151, 23);
            BTNabout_intructors.TabIndex = 2;
            BTNabout_intructors.Text = "About our Instructors";
            BTNabout_intructors.UseVisualStyleBackColor = true;
            BTNabout_intructors.Click += BTNinstructor_Click;
            // 
            // BTNview_Bookings
            // 
            BTNview_Bookings.Location = new Point(401, 12);
            BTNview_Bookings.Name = "BTNview_Bookings";
            BTNview_Bookings.Size = new Size(101, 23);
            BTNview_Bookings.TabIndex = 3;
            BTNview_Bookings.Text = "View Bookings";
            BTNview_Bookings.UseVisualStyleBackColor = true;
            BTNview_Bookings.Click += BTNview_Bookings_Click;
            // 
            // BTNlogout
            // 
            BTNlogout.Location = new Point(508, 12);
            BTNlogout.Name = "BTNlogout";
            BTNlogout.Size = new Size(92, 23);
            BTNlogout.TabIndex = 4;
            BTNlogout.Text = "Log out";
            BTNlogout.UseVisualStyleBackColor = true;
            BTNlogout.Click += button5_Click;
            // 
            // LBLuser
            // 
            LBLuser.AutoSize = true;
            LBLuser.Location = new Point(596, 88);
            LBLuser.Name = "LBLuser";
            LBLuser.Size = new Size(38, 15);
            LBLuser.TabIndex = 5;
            LBLuser.Text = "label1";
            LBLuser.Click += LBLuser_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LBLuser);
            Controls.Add(BTNlogout);
            Controls.Add(BTNview_Bookings);
            Controls.Add(BTNabout_intructors);
            Controls.Add(BTNbook_member);
            Controls.Add(BTN_classes);
            Name = "Homepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_classes;
        private Button BTNbook_member;
        private Button BTNabout_intructors;
        private Button BTNview_Bookings;
        private Button BTNlogout;
        private Label LBLuser;
    }
}