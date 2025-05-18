namespace WindowsFormsApp1
{
    partial class Ride
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
            this.txtuserId = new System.Windows.Forms.TextBox();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.txtstartAddress = new System.Windows.Forms.TextBox();
            this.txtstartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPromoCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtuserId
            // 
            this.txtuserId.BackColor = System.Drawing.SystemColors.Window;
            this.txtuserId.Location = new System.Drawing.Point(12, 43);
            this.txtuserId.Name = "txtuserId";
            this.txtuserId.Size = new System.Drawing.Size(379, 20);
            this.txtuserId.TabIndex = 0;
            // 
            // txtdestination
            // 
            this.txtdestination.AccessibleName = "";
            this.txtdestination.Location = new System.Drawing.Point(12, 107);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(379, 20);
            this.txtdestination.TabIndex = 2;
            // 
            // txtstartAddress
            // 
            this.txtstartAddress.Location = new System.Drawing.Point(12, 168);
            this.txtstartAddress.Name = "txtstartAddress";
            this.txtstartAddress.Size = new System.Drawing.Size(379, 20);
            this.txtstartAddress.TabIndex = 3;
            // 
            // txtstartTime
            // 
            this.txtstartTime.Location = new System.Drawing.Point(12, 237);
            this.txtstartTime.Name = "txtstartTime";
            this.txtstartTime.Size = new System.Drawing.Size(379, 20);
            this.txtstartTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "userId\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "startAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "startTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "destination";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(593, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Promo-Code";
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Location = new System.Drawing.Point(12, 304);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(379, 20);
            this.txtPromoCode.TabIndex = 12;
            // 
            // Ride
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstartTime);
            this.Controls.Add(this.txtstartAddress);
            this.Controls.Add(this.txtdestination);
            this.Controls.Add(this.txtuserId);
            this.Name = "Ride";
            this.Text = "Ride";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserId;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.TextBox txtstartAddress;
        private System.Windows.Forms.TextBox txtstartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPromoCode;
    }
}

