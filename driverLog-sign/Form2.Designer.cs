namespace db_assign
{
    partial class driverLogin
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
            email = new TextBox();
            label1 = new Label();
            password = new TextBox();
            label2 = new Label();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(35, 116);
            email.Name = "email";
            email.Size = new Size(415, 27);
            email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "email";
            // 
            // password
            // 
            password.Location = new Point(35, 241);
            password.Name = "password";
            password.Size = new Size(415, 27);
            password.TabIndex = 2;
            password.PasswordChar = '●';
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 198);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveCaption;
            loginBtn.Location = new Point(619, 369);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // driverLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(email);
            Name = "driverLogin";
            Text = "driver login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Label label1;
        private TextBox password;
        private Label label2;
        private Button loginBtn;
    }
}