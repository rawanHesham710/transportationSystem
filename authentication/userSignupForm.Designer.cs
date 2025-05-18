namespace WinFormsApp1
{
    partial class userSignupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fNameTxt = new Label();
            submitBtn = new Button();
            userNameField = new TextBox();
            phoneField = new TextBox();
            phoneTxt = new Label();
            lastNameTxt = new Label();
            emailTxt = new Label();
            passwordTxt = new Label();
            emailField = new TextBox();
            passwordField = new TextBox();
            lastNameField = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // fNameTxt
            // 
            fNameTxt.AutoSize = true;
            fNameTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fNameTxt.Location = new Point(39, 93);
            fNameTxt.Name = "fNameTxt";
            fNameTxt.Size = new Size(96, 20);
            fNameTxt.TabIndex = 0;
            fNameTxt.Text = "First name:";
            // 
            // submitBtn
            // 
            submitBtn.FlatAppearance.BorderColor = Color.Black;
            submitBtn.FlatAppearance.BorderSize = 4;
            submitBtn.FlatStyle = FlatStyle.Popup;
            submitBtn.Location = new Point(545, 506);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 29);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += button1_Click;
            // 
            // userNameField
            // 
            userNameField.BackColor = SystemColors.Window;
            userNameField.Location = new Point(39, 127);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(476, 27);
            userNameField.TabIndex = 2;
            // 
            // phoneField
            // 
            phoneField.Location = new Point(40, 358);
            phoneField.Name = "phoneField";
            phoneField.Size = new Size(475, 27);
            phoneField.TabIndex = 3;
            // 
            // phoneTxt
            // 
            phoneTxt.AutoSize = true;
            phoneTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneTxt.Location = new Point(40, 325);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(131, 20);
            phoneTxt.TabIndex = 4;
            phoneTxt.Text = "Phone Number:";
            // 
            // lastNameTxt
            // 
            lastNameTxt.AutoSize = true;
            lastNameTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTxt.Location = new Point(39, 171);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(95, 20);
            lastNameTxt.TabIndex = 5;
            lastNameTxt.Text = "Last name:";
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(40, 246);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(59, 20);
            emailTxt.TabIndex = 6;
            emailTxt.Text = "Email:";
            // 
            // passwordTxt
            // 
            passwordTxt.AutoSize = true;
            passwordTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(40, 411);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(87, 20);
            passwordTxt.TabIndex = 7;
            passwordTxt.Text = "Password:";
            // 
            // emailField
            // 
            emailField.Location = new Point(40, 278);
            emailField.Name = "emailField";
            emailField.Size = new Size(475, 27);
            emailField.TabIndex = 8;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(40, 446);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(475, 27);
            passwordField.TabIndex = 9;
            // 
            // lastNameField
            // 
            lastNameField.Location = new Point(40, 205);
            lastNameField.Name = "lastNameField";
            lastNameField.Size = new Size(475, 27);
            lastNameField.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 34);
            label1.Name = "label1";
            label1.Size = new Size(228, 27);
            label1.TabIndex = 11;
            label1.Text = "Signing up as passenger";
            // 
            // userSignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 556);
            Controls.Add(label1);
            Controls.Add(lastNameField);
            Controls.Add(passwordField);
            Controls.Add(emailField);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(lastNameTxt);
            Controls.Add(phoneTxt);
            Controls.Add(phoneField);
            Controls.Add(userNameField);
            Controls.Add(submitBtn);
            Controls.Add(fNameTxt);
            Name = "userSignupForm";
            Text = "Sign up as passenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fNameTxt;
        private Button submitBtn;
        private TextBox userNameField;
        private TextBox phoneField;
        private Label phoneTxt;
        private Label lastNameTxt;
        private Label emailTxt;
        private Label passwordTxt;
        private TextBox emailField;
        private TextBox passwordField;
        private TextBox lastNameField;
        private Label label1;
    }
}
