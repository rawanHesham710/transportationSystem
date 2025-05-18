namespace WinFormsApp1
{
    partial class userLoginForm
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
            loginBtn = new Button();
            label1 = new Label();
            loginEmailField = new TextBox();
            loginPassField = new TextBox();
            loginEmailTxt = new Label();
            loginPassTxt = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(537, 391);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "submit";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 43);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back";
            // 
            // loginEmailField
            // 
            loginEmailField.Location = new Point(43, 210);
            loginEmailField.Name = "loginEmailField";
            loginEmailField.Size = new Size(436, 27);
            loginEmailField.TabIndex = 2;
            // 
            // loginPassField
            // 
            loginPassField.Location = new Point(43, 300);
            loginPassField.Name = "loginPassField";
            loginPassField.Size = new Size(436, 27);
            loginPassField.TabIndex = 3;
            loginPassField.PasswordChar = '●';
            // 
            // loginEmailTxt
            // 
            loginEmailTxt.AutoSize = true;
            loginEmailTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginEmailTxt.Location = new Point(43, 175);
            loginEmailTxt.Name = "loginEmailTxt";
            loginEmailTxt.Size = new Size(59, 20);
            loginEmailTxt.TabIndex = 4;
            loginEmailTxt.Text = "Email:";
            // 
            // loginPassTxt
            // 
            loginPassTxt.AutoSize = true;
            loginPassTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginPassTxt.Location = new Point(43, 264);
            loginPassTxt.Name = "loginPassTxt";
            loginPassTxt.Size = new Size(87, 20);
            loginPassTxt.TabIndex = 5;
            loginPassTxt.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 87);
            label2.Name = "label2";
            label2.Size = new Size(384, 21);
            label2.TabIndex = 6;
            label2.Text = "Please enter your email and password to continue";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(label2);
            Controls.Add(loginPassTxt);
            Controls.Add(loginEmailTxt);
            Controls.Add(loginPassField);
            Controls.Add(loginEmailField);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label1;
        private TextBox loginEmailField;
        private TextBox loginPassField;
        private Label loginEmailTxt;
        private Label loginPassTxt;
        private Label label2;
    }
}
