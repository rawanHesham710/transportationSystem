namespace Transportation_App.Views
{
    partial class Ride_History
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
            Ride_Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Ride_Grid).BeginInit();
            SuspendLayout();
            // 
            // Ride_Grid
            // 
            Ride_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Ride_Grid.Location = new Point(12, 12);
            Ride_Grid.Name = "Ride_Grid";
            Ride_Grid.RowHeadersWidth = 62;
            Ride_Grid.Size = new Size(776, 426);
            Ride_Grid.TabIndex = 0;
            // 
            // Ride_History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ride_Grid);
            Name = "Ride_History";
            Text = "Ride History";
            ((System.ComponentModel.ISupportInitialize)Ride_Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Ride_Grid;
    }
}