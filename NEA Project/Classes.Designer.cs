namespace NEA_Project
{
    partial class Classes
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
            BTNyoga = new Button();
            BTNswimming = new Button();
            BTNkarate = new Button();
            BTNwomans_self_defence = new Button();
            BTNbadminton = new Button();
            SuspendLayout();
            // 
            // BTNyoga
            // 
            BTNyoga.Location = new Point(68, 47);
            BTNyoga.Name = "BTNyoga";
            BTNyoga.Size = new Size(75, 23);
            BTNyoga.TabIndex = 0;
            BTNyoga.Text = "Yoga";
            BTNyoga.UseVisualStyleBackColor = true;
            BTNyoga.Click += BTNyoga_Click;
            // 
            // BTNswimming
            // 
            BTNswimming.Location = new Point(149, 47);
            BTNswimming.Name = "BTNswimming";
            BTNswimming.Size = new Size(75, 23);
            BTNswimming.TabIndex = 1;
            BTNswimming.Text = "Swimming";
            BTNswimming.UseVisualStyleBackColor = true;
            BTNswimming.Click += BTNswimming_Click;
            // 
            // BTNkarate
            // 
            BTNkarate.Location = new Point(230, 47);
            BTNkarate.Name = "BTNkarate";
            BTNkarate.Size = new Size(75, 23);
            BTNkarate.TabIndex = 2;
            BTNkarate.Text = "Karate";
            BTNkarate.UseVisualStyleBackColor = true;
            BTNkarate.Click += BTNkarate_Click;
            // 
            // BTNwomans_self_defence
            // 
            BTNwomans_self_defence.Location = new Point(311, 47);
            BTNwomans_self_defence.Name = "BTNwomans_self_defence";
            BTNwomans_self_defence.Size = new Size(130, 23);
            BTNwomans_self_defence.TabIndex = 3;
            BTNwomans_self_defence.Text = "Womans Self Defence";
            BTNwomans_self_defence.UseVisualStyleBackColor = true;
            BTNwomans_self_defence.Click += BTNwomans_self_defence_Click;
            // 
            // BTNbadminton
            // 
            BTNbadminton.Location = new Point(447, 47);
            BTNbadminton.Name = "BTNbadminton";
            BTNbadminton.Size = new Size(75, 23);
            BTNbadminton.TabIndex = 4;
            BTNbadminton.Text = "Badminton";
            BTNbadminton.UseVisualStyleBackColor = true;
            BTNbadminton.Click += BTNbadminton_Click;
            // 
            // Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNbadminton);
            Controls.Add(BTNwomans_self_defence);
            Controls.Add(BTNkarate);
            Controls.Add(BTNswimming);
            Controls.Add(BTNyoga);
            Name = "Classes";
            Text = "Classes";
            ResumeLayout(false);
        }

        #endregion

        private Button BTNyoga;
        private Button BTNswimming;
        private Button BTNkarate;
        private Button BTNwomans_self_defence;
        private Button BTNbadminton;
    }
}