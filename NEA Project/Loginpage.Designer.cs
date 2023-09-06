namespace Prototype1
{
    partial class Loginpage
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
            LBLLOGINusername = new Label();
            LBLLOGINpassword = new Label();
            TXTBOXusername = new TextBox();
            TXTBOXpassword = new TextBox();
            BTNregister = new Button();
            SuspendLayout();
            // 
            // BTNlogin
            // 
            BTNlogin.Location = new Point(237, 208);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(65, 26);
            BTNlogin.TabIndex = 0;
            BTNlogin.Text = "LOGIN";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // LBLLOGINusername
            // 
            LBLLOGINusername.AutoSize = true;
            LBLLOGINusername.Location = new Point(154, 130);
            LBLLOGINusername.Name = "LBLLOGINusername";
            LBLLOGINusername.Size = new Size(63, 15);
            LBLLOGINusername.TabIndex = 1;
            LBLLOGINusername.Text = "Username:";
            // 
            // LBLLOGINpassword
            // 
            LBLLOGINpassword.AutoSize = true;
            LBLLOGINpassword.Location = new Point(154, 172);
            LBLLOGINpassword.Name = "LBLLOGINpassword";
            LBLLOGINpassword.Size = new Size(60, 15);
            LBLLOGINpassword.TabIndex = 2;
            LBLLOGINpassword.Text = "Password:";
            // 
            // TXTBOXusername
            // 
            TXTBOXusername.Location = new Point(220, 130);
            TXTBOXusername.Name = "TXTBOXusername";
            TXTBOXusername.Size = new Size(100, 23);
            TXTBOXusername.TabIndex = 3;
            TXTBOXusername.Text = "adam";
            // 
            // TXTBOXpassword
            // 
            TXTBOXpassword.Location = new Point(220, 169);
            TXTBOXpassword.Name = "TXTBOXpassword";
            TXTBOXpassword.Size = new Size(100, 23);
            TXTBOXpassword.TabIndex = 4;
            TXTBOXpassword.Text = "as";
            // 
            // BTNregister
            // 
            BTNregister.Location = new Point(163, 240);
            BTNregister.Name = "BTNregister";
            BTNregister.Size = new Size(213, 26);
            BTNregister.TabIndex = 5;
            BTNregister.Text = "Would you like to create an account";
            BTNregister.UseVisualStyleBackColor = true;
            BTNregister.Click += BTNregister_Click;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNregister);
            Controls.Add(TXTBOXpassword);
            Controls.Add(TXTBOXusername);
            Controls.Add(LBLLOGINpassword);
            Controls.Add(LBLLOGINusername);
            Controls.Add(BTNlogin);
            Name = "Loginpage";
            Text = "Loginpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNlogin;
        private Label LBLLOGINusername;
        private Label LBLLOGINpassword;
        private TextBox TXTBOXusername;
        private TextBox TXTBOXpassword;
        private Button BTNregister;
    }
}