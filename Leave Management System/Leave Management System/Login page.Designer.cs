namespace Leave_Management_System
{
    partial class Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            this.EmployeeLogin = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EmployeeUser = new System.Windows.Forms.TextBox();
            this.EmployeeNo = new System.Windows.Forms.Button();
            this.PW = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeLogin
            // 
            resources.ApplyResources(this.EmployeeLogin, "EmployeeLogin");
            this.EmployeeLogin.Name = "EmployeeLogin";
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmployeeUser
            // 
            resources.ApplyResources(this.EmployeeUser, "EmployeeUser");
            this.EmployeeUser.ForeColor = System.Drawing.Color.Black;
            this.EmployeeUser.Name = "EmployeeUser";
            this.EmployeeUser.TextChanged += new System.EventHandler(this.EmployeeNumber_TextChanged);
            // 
            // EmployeeNo
            // 
            resources.ApplyResources(this.EmployeeNo, "EmployeeNo");
            this.EmployeeNo.Name = "EmployeeNo";
            this.EmployeeNo.UseVisualStyleBackColor = true;
            this.EmployeeNo.Click += new System.EventHandler(this.EmployeeNo_Click);
            // 
            // PW
            // 
            resources.ApplyResources(this.PW, "PW");
            this.PW.Name = "PW";
            this.PW.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.Password.UseVisualStyleBackColor = true;
            // 
            // Login_page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PW);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmployeeUser);
            this.Controls.Add(this.EmployeeNo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.EmployeeLogin);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.Name = "Login_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmployeeLogin;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox EmployeeUser;
        private System.Windows.Forms.Button EmployeeNo;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Button Password;
    }
}