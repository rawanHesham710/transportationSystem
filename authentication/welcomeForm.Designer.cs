namespace WinFormsApp1
{
    partial class welcomeForm
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
            PassengerBtn = new Button();
            driverBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PassengerBtn
            // 
            PassengerBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassengerBtn.Location = new Point(221, 150);
            PassengerBtn.Name = "PassengerBtn";
            PassengerBtn.Size = new Size(304, 52);
            PassengerBtn.TabIndex = 0;
            PassengerBtn.Text = "Passenger";
            PassengerBtn.UseVisualStyleBackColor = true;
            PassengerBtn.Click += loginBtnWelcome_Click;
            // 
            // driverBtn
            // 
            driverBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            driverBtn.Location = new Point(221, 248);
            driverBtn.Name = "driverBtn";
            driverBtn.Size = new Size(304, 52);
            driverBtn.TabIndex = 1;
            driverBtn.Text = "Driver";
            driverBtn.UseVisualStyleBackColor = true;
            driverBtn.Click += driverBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 53);
            label1.Name = "label1";
            label1.Size = new Size(329, 27);
            label1.TabIndex = 3;
            label1.Text = "Welcome to our transportation app";
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(driverBtn);
            Controls.Add(PassengerBtn);
            Name = "welcomeForm";
            Text = "welcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PassengerBtn;
        private Button driverBtn;
        private Label label1;
    }
}