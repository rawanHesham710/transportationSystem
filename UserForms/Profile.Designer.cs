namespace Transportation_App.Views
{
    partial class Profile
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
            FullName = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Email = new RichTextBox();
            label3 = new Label();
            Phone_Number = new RichTextBox();
            Edit_btn = new Button();
            Submit_btn = new Button();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.Enabled = false;
            FullName.Location = new Point(41, 52);
            FullName.Name = "FullName";
            FullName.Size = new Size(276, 50);
            FullName.TabIndex = 0;
            FullName.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 130);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // Email
            // 
            Email.Enabled = false;
            Email.Location = new Point(41, 158);
            Email.Name = "Email";
            Email.Size = new Size(276, 50);
            Email.TabIndex = 2;
            Email.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 245);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // Phone_Number
            // 
            Phone_Number.Enabled = false;
            Phone_Number.Location = new Point(41, 273);
            Phone_Number.Name = "Phone_Number";
            Phone_Number.Size = new Size(276, 50);
            Phone_Number.TabIndex = 4;
            Phone_Number.Text = "";
            // 
            // Edit_btn
            // 
            Edit_btn.Location = new Point(599, 174);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(112, 34);
            Edit_btn.TabIndex = 6;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = true;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Submit_btn
            // 
            Submit_btn.Location = new Point(599, 236);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(112, 34);
            Submit_btn.TabIndex = 7;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = true;
            Submit_btn.Click += Submit_btn_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit_btn);
            Controls.Add(Edit_btn);
            Controls.Add(label3);
            Controls.Add(Phone_Number);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(label1);
            Controls.Add(FullName);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox FullName;
        private Label label1;
        private Label label2;
        private RichTextBox Email;
        private Label label3;
        private RichTextBox Phone_Number;
        private Button Edit_btn;
        private Button Submit_btn;
    }
}