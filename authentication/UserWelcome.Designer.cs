namespace WinFormsApp1
{
    partial class UserWelcome
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
            UserSignupBtn = new Button();
            userloginBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserSignupBtn
            // 
            UserSignupBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserSignupBtn.Location = new Point(279, 128);
            UserSignupBtn.Name = "UserSignupBtn";
            UserSignupBtn.Size = new Size(241, 59);
            UserSignupBtn.TabIndex = 0;
            UserSignupBtn.Text = "Sign up";
            UserSignupBtn.UseVisualStyleBackColor = true;
            UserSignupBtn.Click += UserSignupBtn_Click;
            // 
            // userloginBtn
            // 
            userloginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userloginBtn.Location = new Point(279, 229);
            userloginBtn.Name = "userloginBtn";
            userloginBtn.Size = new Size(241, 58);
            userloginBtn.TabIndex = 1;
            userloginBtn.Text = "Login";
            userloginBtn.UseVisualStyleBackColor = true;
            userloginBtn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 46);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 2;
            label1.Text = "Hello Passenger";
            label1.Click += label1_Click;
            // 
            // UserWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(userloginBtn);
            Controls.Add(UserSignupBtn);
            Name = "UserWelcome";
            Text = "UserWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSignupBtn;
        private Button userloginBtn;
        private Label label1;
    }
}