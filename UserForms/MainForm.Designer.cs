namespace Transportation_App.Views
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            rideHistory = new ToolStripMenuItem();
            vehicleTypes = new ToolStripMenuItem();
            Profile = new ToolStripMenuItem();
            New_Ride = new Button();
            Hello_Massage = new RichTextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { rideHistory, vehicleTypes, Profile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // rideHistory
            // 
            rideHistory.Name = "rideHistory";
            rideHistory.Size = new Size(125, 29);
            rideHistory.Text = "Ride History";
            rideHistory.Click += rideHistory_Click;
            // 
            // vehicleTypes
            // 
            vehicleTypes.Name = "vehicleTypes";
            vehicleTypes.Size = new Size(132, 29);
            vehicleTypes.Text = "Vehicle Types";
            vehicleTypes.Click += vehicleTypes_Click;
            // 
            // Profile
            // 
            Profile.Name = "Profile";
            Profile.Size = new Size(78, 29);
            Profile.Text = "Profile";
            Profile.Click += Profile_Click;
            // 
            // New_Ride
            // 
            New_Ride.BackColor = SystemColors.ActiveCaption;
            New_Ride.Location = new Point(125, 342);
            New_Ride.Name = "New_Ride";
            New_Ride.Size = new Size(169, 49);
            New_Ride.TabIndex = 1;
            New_Ride.Text = "New Ride";
            New_Ride.UseVisualStyleBackColor = false;
            New_Ride.Click += NewRide_Click;
            // 
            // Hello_Massage
            // 
            Hello_Massage.Location = new Point(29, 51);
            Hello_Massage.Name = "Hello_Massage";
            Hello_Massage.Size = new Size(462, 59);
            Hello_Massage.TabIndex = 2;
            Hello_Massage.Text = "Hello ${user.name}";
            Hello_Massage.ZoomFactor = 2F;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(511, 342);
            button1.Name = "button1";
            button1.Size = new Size(172, 49);
            button1.TabIndex = 3;
            button1.Text = "Transport Goods";
            button1.UseVisualStyleBackColor = false;
            button1.Click += TransportGoods_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Hello_Massage);
            Controls.Add(New_Ride);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem rideHistory;
        private ToolStripMenuItem vehicleTypes;
        private ToolStripMenuItem Profile;
        private Button New_Ride;
        private RichTextBox Hello_Massage;
        private Button button1;
    }
}