namespace Transportation_App.Views
{
    partial class Checkout
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
            Payment_Method = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Fees_Lable = new Label();
            Checkout_btn = new Button();
            SuspendLayout();
            // 
            // Payment_Method
            // 
            Payment_Method.FormattingEnabled = true;
            Payment_Method.Items.AddRange(new object[] { "Cash", "Card", "Digital Wallet" });
            Payment_Method.Location = new Point(251, 204);
            Payment_Method.Name = "Payment_Method";
            Payment_Method.Size = new Size(307, 33);
            Payment_Method.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 176);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Payment Method";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "Total Fees:";
            // 
            // Fees_Lable
            // 
            Fees_Lable.AutoSize = true;
            Fees_Lable.Location = new Point(426, 121);
            Fees_Lable.Name = "Fees_Lable";
            Fees_Lable.Size = new Size(22, 25);
            Fees_Lable.TabIndex = 3;
            Fees_Lable.Text = "0";
            // 
            // Checkout_btn
            // 
            Checkout_btn.Location = new Point(348, 284);
            Checkout_btn.Name = "Checkout_btn";
            Checkout_btn.Size = new Size(112, 34);
            Checkout_btn.TabIndex = 4;
            Checkout_btn.Text = "Checkout";
            Checkout_btn.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Checkout_btn);
            Controls.Add(Fees_Lable);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Payment_Method);
            Name = "Checkout";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Payment_Method;
        private Label label1;
        private TextBox textBox1;
        private Label Fees_Lable;
        private Button Checkout_btn;
    }
}