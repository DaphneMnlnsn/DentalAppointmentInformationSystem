namespace DentalAppointmentInformationSystem
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldays = new System.Windows.Forms.Label();
            this.lblsched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(47, 12);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(27, 20);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            this.lbldays.Click += new System.EventHandler(this.lbldays_Click);
            // 
            // lblsched
            // 
            this.lblsched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsched.Location = new System.Drawing.Point(0, 41);
            this.lblsched.Name = "lblsched";
            this.lblsched.Size = new System.Drawing.Size(115, 41);
            this.lblsched.TabIndex = 1;
            this.lblsched.Text = "label1";
            this.lblsched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblsched);
            this.Controls.Add(this.lbldays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(115, 82);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblsched;
    }
}
