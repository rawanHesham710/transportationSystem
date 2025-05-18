namespace WinFormsApp1
{
    partial class driverWelcome
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
            label1 = new Label();
            DriverloginBtn = new Button();
            DriverSignupBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 105);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 5;
            label1.Text = "Hello Driver";
            // 
            // DriverloginBtn
            // 
            DriverloginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DriverloginBtn.Location = new Point(280, 288);
            DriverloginBtn.Name = "DriverloginBtn";
            DriverloginBtn.Size = new Size(241, 58);
            DriverloginBtn.TabIndex = 4;
            DriverloginBtn.Text = "Login";
            DriverloginBtn.UseVisualStyleBackColor = true;
            DriverloginBtn.Click += DriverloginBtn_Click;
            // 
            // DriverSignupBtn
            // 
            DriverSignupBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DriverSignupBtn.Location = new Point(280, 187);
            DriverSignupBtn.Name = "DriverSignupBtn";
            DriverSignupBtn.Size = new Size(241, 59);
            DriverSignupBtn.TabIndex = 3;
            DriverSignupBtn.Text = "Sign up";
            DriverSignupBtn.UseVisualStyleBackColor = true;
            DriverSignupBtn.Click += DriverSignupBtn_Click;
            // 
            // driverWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(DriverloginBtn);
            Controls.Add(DriverSignupBtn);
            Name = "driverWelcome";
            Text = "driverWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button DriverloginBtn;
        private Button DriverSignupBtn;
    }
}