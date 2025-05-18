namespace db_assign
{
    partial class driverForm
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
            name = new TextBox();
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            license = new TextBox();
            label5 = new Label();
            color = new TextBox();
            label6 = new Label();
            model = new TextBox();
            label7 = new Label();
            type = new TextBox();
            label8 = new Label();
            capacity = new TextBox();
            label9 = new Label();
            sebmit = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = SystemColors.Window;
            name.Location = new Point(60, 84);
            name.Name = "name";
            name.Size = new Size(586, 27);
            name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "name";
            // 
            // email
            // 
            email.Location = new Point(60, 192);
            email.Name = "email";
            email.Size = new Size(586, 27);
            email.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 155);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "email";
            // 
            // phone
            // 
            phone.Location = new Point(60, 306);
            phone.Name = "phone";
            phone.Size = new Size(586, 27);
            phone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 267);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "phone";
            // 
            // password
            // 
            password.Location = new Point(60, 415);
            password.Name = "password";
            password.Size = new Size(586, 27);
            password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 377);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "password";
            // 
            // license
            // 
            license.Location = new Point(60, 520);
            license.Name = "license";
            license.Size = new Size(586, 27);
            license.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 484);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 9;
            label5.Text = "license number";
            // 
            // color
            // 
            color.Location = new Point(60, 629);
            color.Name = "color";
            color.Size = new Size(586, 27);
            color.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 589);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "car color";
            // 
            // model
            // 
            model.Location = new Point(60, 731);
            model.Name = "model";
            model.Size = new Size(586, 27);
            model.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 697);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 13;
            label7.Text = "model";
            // 
            // type
            // 
            type.Location = new Point(60, 852);
            type.Name = "type";
            type.Size = new Size(586, 27);
            type.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 797);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 15;
            label8.Text = "type";
            // 
            // capacity
            // 
            capacity.Location = new Point(60, 948);
            capacity.Name = "capacity";
            capacity.Size = new Size(586, 27);
            capacity.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 914);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 17;
            label9.Text = "capacity";
            // 
            // sebmit
            // 
            sebmit.BackColor = SystemColors.GradientActiveCaption;
            sebmit.Location = new Point(644, 1014);
            sebmit.Name = "sebmit";
            sebmit.Size = new Size(94, 29);
            sebmit.TabIndex = 18;
            sebmit.Text = "submit";
            sebmit.UseVisualStyleBackColor = false;
            sebmit.Click += sebmit_Click;
            // 
            // driverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 1055);
            Controls.Add(sebmit);
            Controls.Add(label9);
            Controls.Add(capacity);
            Controls.Add(label8);
            Controls.Add(type);
            Controls.Add(label7);
            Controls.Add(model);
            Controls.Add(label6);
            Controls.Add(color);
            Controls.Add(label5);
            Controls.Add(license);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(phone);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(name);
            Name = "driverForm";
            Text = "driver sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox phone;
        private Label label3;
        private TextBox password;
        private Label label4;
        private TextBox license;
        private Label label5;
        private TextBox color;
        private Label label6;
        private TextBox model;
        private Label label7;
        private TextBox type;
        private Label label8;
        private TextBox capacity;
        private Label label9;
        private Button sebmit;
    }
}