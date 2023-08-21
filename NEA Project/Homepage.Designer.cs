namespace Prototype1
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
            BTNlogin = new Button();
            LBLusername = new Label();
            LBLpassword = new Label();
            TXTBOXusername = new TextBox();
            TXTBOXpassword = new TextBox();
            BTNregister = new Button();
            SuspendLayout();
            // 
            // BTNlogin
            // 
            BTNlogin.Location = new Point(95, 157);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(65, 26);
            BTNlogin.TabIndex = 0;
            BTNlogin.Text = "LOGIN";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // LBLusername
            // 
            LBLusername.AutoSize = true;
            LBLusername.Location = new Point(12, 79);
            LBLusername.Name = "LBLusername";
            LBLusername.Size = new Size(63, 15);
            LBLusername.TabIndex = 1;
            LBLusername.Text = "Username:";
            // 
            // LBLpassword
            // 
            LBLpassword.AutoSize = true;
            LBLpassword.Location = new Point(12, 121);
            LBLpassword.Name = "LBLpassword";
            LBLpassword.Size = new Size(60, 15);
            LBLpassword.TabIndex = 2;
            LBLpassword.Text = "Password:";
            // 
            // TXTBOXusername
            // 
            TXTBOXusername.Location = new Point(78, 79);
            TXTBOXusername.Name = "TXTBOXusername";
            TXTBOXusername.Size = new Size(100, 23);
            TXTBOXusername.TabIndex = 3;
            // 
            // TXTBOXpassword
            // 
            TXTBOXpassword.Location = new Point(78, 118);
            TXTBOXpassword.Name = "TXTBOXpassword";
            TXTBOXpassword.Size = new Size(100, 23);
            TXTBOXpassword.TabIndex = 4;
            // 
            // BTNregister
            // 
            BTNregister.Location = new Point(21, 189);
            BTNregister.Name = "BTNregister";
            BTNregister.Size = new Size(213, 26);
            BTNregister.TabIndex = 5;
            BTNregister.Text = "Would you like to create an account";
            BTNregister.UseVisualStyleBackColor = true;
            BTNregister.Click += BTNregister_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNregister);
            Controls.Add(TXTBOXpassword);
            Controls.Add(TXTBOXusername);
            Controls.Add(LBLpassword);
            Controls.Add(LBLusername);
            Controls.Add(BTNlogin);
            Name = "Homepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNlogin;
        private Label LBLusername;
        private Label LBLpassword;
        private TextBox TXTBOXusername;
        private TextBox TXTBOXpassword;
        private Button BTNregister;
    }
}