namespace NEA_Project
{
    partial class Registerpage
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
            BTNsignup = new Button();
            LBLREGISTRATIONusername = new Label();
            LBLREGISTRATIONpassword = new Label();
            TXTBOXusername = new TextBox();
            TXTBOXpassword = new TextBox();
            LBLREGISTRATIONconfirmpassword = new Label();
            TXTBOXconfirmpassword = new TextBox();
            SuspendLayout();
            // 
            // BTNsignup
            // 
            BTNsignup.Location = new Point(216, 179);
            BTNsignup.Name = "BTNsignup";
            BTNsignup.Size = new Size(75, 23);
            BTNsignup.TabIndex = 0;
            BTNsignup.Text = "Sign Up";
            BTNsignup.UseVisualStyleBackColor = true;
            BTNsignup.Click += BTNSignup_Click;
            // 
            // LBLREGISTRATIONusername
            // 
            LBLREGISTRATIONusername.AutoSize = true;
            LBLREGISTRATIONusername.Location = new Point(120, 72);
            LBLREGISTRATIONusername.Name = "LBLREGISTRATIONusername";
            LBLREGISTRATIONusername.Size = new Size(63, 15);
            LBLREGISTRATIONusername.TabIndex = 1;
            LBLREGISTRATIONusername.Text = "Username:";
            // 
            // LBLREGISTRATIONpassword
            // 
            LBLREGISTRATIONpassword.AutoSize = true;
            LBLREGISTRATIONpassword.Location = new Point(120, 108);
            LBLREGISTRATIONpassword.Name = "LBLREGISTRATIONpassword";
            LBLREGISTRATIONpassword.Size = new Size(60, 15);
            LBLREGISTRATIONpassword.TabIndex = 2;
            LBLREGISTRATIONpassword.Text = "Password:";
            // 
            // TXTBOXusername
            // 
            TXTBOXusername.Location = new Point(202, 69);
            TXTBOXusername.Name = "TXTBOXusername";
            TXTBOXusername.Size = new Size(100, 23);
            TXTBOXusername.TabIndex = 3;
            // 
            // TXTBOXpassword
            // 
            TXTBOXpassword.Location = new Point(202, 105);
            TXTBOXpassword.Name = "TXTBOXpassword";
            TXTBOXpassword.PasswordChar = '*';
            TXTBOXpassword.Size = new Size(100, 23);
            TXTBOXpassword.TabIndex = 4;
            // 
            // LBLREGISTRATIONconfirmpassword
            // 
            LBLREGISTRATIONconfirmpassword.AutoSize = true;
            LBLREGISTRATIONconfirmpassword.Location = new Point(76, 143);
            LBLREGISTRATIONconfirmpassword.Name = "LBLREGISTRATIONconfirmpassword";
            LBLREGISTRATIONconfirmpassword.Size = new Size(107, 15);
            LBLREGISTRATIONconfirmpassword.TabIndex = 5;
            LBLREGISTRATIONconfirmpassword.Text = "Confirm Password:";
            // 
            // TXTBOXconfirmpassword
            // 
            TXTBOXconfirmpassword.Location = new Point(202, 140);
            TXTBOXconfirmpassword.Name = "TXTBOXconfirmpassword";
            TXTBOXconfirmpassword.PasswordChar = '*';
            TXTBOXconfirmpassword.Size = new Size(100, 23);
            TXTBOXconfirmpassword.TabIndex = 6;
            // 
            // Registerpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 598);
            Controls.Add(TXTBOXconfirmpassword);
            Controls.Add(LBLREGISTRATIONconfirmpassword);
            Controls.Add(TXTBOXpassword);
            Controls.Add(TXTBOXusername);
            Controls.Add(LBLREGISTRATIONpassword);
            Controls.Add(LBLREGISTRATIONusername);
            Controls.Add(BTNsignup);
            Name = "Registerpage";
            Text = "resgister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNsignup;
        private Label LBLREGISTRATIONusername;
        private Label LBLREGISTRATIONpassword;
        private TextBox TXTBOXusername;
        private TextBox TXTBOXpassword;
        private Label LBLREGISTRATIONconfirmpassword;
        private TextBox TXTBOXconfirmpassword;
    }
}