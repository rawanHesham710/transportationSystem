namespace Transportation_App.Views
{
    partial class Transport_Goods
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
            Weigh_Box = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            Size_Box = new RichTextBox();
            Submit_btn = new Button();
            label4 = new Label();
            Name_TextBox = new RichTextBox();
            label5 = new Label();
            DestinationBox = new RichTextBox();
            label6 = new Label();
            StartAdressBox = new RichTextBox();
            SuspendLayout();
            // 
            // Weigh_Box
            // 
            Weigh_Box.Location = new Point(71, 166);
            Weigh_Box.Name = "Weigh_Box";
            Weigh_Box.Size = new Size(209, 41);
            Weigh_Box.TabIndex = 0;
            Weigh_Box.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 135);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 232);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 4;
            label1.Text = "Size";
            // 
            // Size_Box
            // 
            Size_Box.Location = new Point(71, 262);
            Size_Box.Name = "Size_Box";
            Size_Box.Size = new Size(209, 41);
            Size_Box.TabIndex = 3;
            Size_Box.Text = "";
            // 
            // Submit_btn
            // 
            Submit_btn.Location = new Point(325, 337);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(112, 34);
            Submit_btn.TabIndex = 6;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = true;
            Submit_btn.Click += Submit_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 33);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 10;
            label4.Text = "Name";
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(71, 64);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(209, 41);
            Name_TextBox.TabIndex = 9;
            Name_TextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 199);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 12;
            label5.Text = "Destination";
            // 
            // DestinationBox
            // 
            DestinationBox.Location = new Point(468, 229);
            DestinationBox.Name = "DestinationBox";
            DestinationBox.Size = new Size(209, 41);
            DestinationBox.TabIndex = 11;
            DestinationBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 103);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 14;
            label6.Text = "Start Address";
            // 
            // StartAdressBox
            // 
            StartAdressBox.Location = new Point(468, 133);
            StartAdressBox.Name = "StartAdressBox";
            StartAdressBox.Size = new Size(209, 41);
            StartAdressBox.TabIndex = 13;
            StartAdressBox.Text = "";
            // 
            // Transport_Goods
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(StartAdressBox);
            Controls.Add(label5);
            Controls.Add(DestinationBox);
            Controls.Add(label4);
            Controls.Add(Name_TextBox);
            Controls.Add(Submit_btn);
            Controls.Add(label1);
            Controls.Add(Size_Box);
            Controls.Add(label2);
            Controls.Add(Weigh_Box);
            Name = "Transport_Goods";
            Text = "Transport Goods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Weigh_Box;
        private Label label2;
        private Label label1;
        private RichTextBox Size_Box;
        private Button Submit_btn;
        private Label label4;
        private RichTextBox Name_TextBox;
        private Label label5;
        private RichTextBox DestinationBox;
        private Label label6;
        private RichTextBox StartAdressBox;
    }
}