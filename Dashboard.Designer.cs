using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DentalAppointmentInformationSystem
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.logoutPic = new System.Windows.Forms.PictureBox();
            this.servicesBtn = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Label();
            this.staffPic = new System.Windows.Forms.PictureBox();
            this.ptntBtn = new System.Windows.Forms.Label();
            this.patientPic = new System.Windows.Forms.PictureBox();
            this.apptclndrBtn = new System.Windows.Forms.Label();
            this.clndrPic = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.emNameTxtBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dshboardBtn = new System.Windows.Forms.Label();
            this.dshbrdPic = new System.Windows.Forms.PictureBox();
            this.srvcsPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wlcmLbl = new System.Windows.Forms.Label();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srvcsPic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.logoutPic, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.staffPic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ptntBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.patientPic, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.apptclndrBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clndrPic, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.doctorPic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emNameTxtBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dshboardBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dshbrdPic, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.srvcsPic, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 802);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(104, 681);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(238, 101);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoutPic
            // 
            this.logoutPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.logout;
            this.logoutPic.Location = new System.Drawing.Point(29, 709);
            this.logoutPic.Name = "logoutPic";
            this.logoutPic.Size = new System.Drawing.Size(43, 44);
            this.logoutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPic.TabIndex = 13;
            this.logoutPic.TabStop = false;
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesBtn.AutoSize = true;
            this.servicesBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBtn.Location = new System.Drawing.Point(104, 604);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(238, 77);
            this.servicesBtn.TabIndex = 12;
            this.servicesBtn.Text = "List of Services";
            this.servicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffBtn.AutoSize = true;
            this.staffBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(104, 515);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(238, 89);
            this.staffBtn.TabIndex = 11;
            this.staffBtn.Text = "List of Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // staffPic
            // 
            this.staffPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.staffs;
            this.staffPic.Location = new System.Drawing.Point(23, 529);
            this.staffPic.Name = "staffPic";
            this.staffPic.Size = new System.Drawing.Size(55, 61);
            this.staffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffPic.TabIndex = 9;
            this.staffPic.TabStop = false;
            this.staffPic.Click += new System.EventHandler(this.staffPic_Click);
            // 
            // ptntBtn
            // 
            this.ptntBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptntBtn.AutoSize = true;
            this.ptntBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptntBtn.Location = new System.Drawing.Point(104, 426);
            this.ptntBtn.Name = "ptntBtn";
            this.ptntBtn.Size = new System.Drawing.Size(238, 89);
            this.ptntBtn.TabIndex = 8;
            this.ptntBtn.Text = "List of Patients";
            this.ptntBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptntBtn.Click += new System.EventHandler(this.ptntBtn_Click);
            // 
            // patientPic
            // 
            this.patientPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.patients;
            this.patientPic.Location = new System.Drawing.Point(22, 440);
            this.patientPic.Name = "patientPic";
            this.patientPic.Size = new System.Drawing.Size(57, 60);
            this.patientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientPic.TabIndex = 7;
            this.patientPic.TabStop = false;
            this.patientPic.Click += new System.EventHandler(this.patientPic_Click);
            // 
            // apptclndrBtn
            // 
            this.apptclndrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apptclndrBtn.AutoSize = true;
            this.apptclndrBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptclndrBtn.Location = new System.Drawing.Point(104, 337);
            this.apptclndrBtn.Name = "apptclndrBtn";
            this.apptclndrBtn.Size = new System.Drawing.Size(238, 89);
            this.apptclndrBtn.TabIndex = 6;
            this.apptclndrBtn.Text = "Appointment\r\nCalendar";
            this.apptclndrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apptclndrBtn.Click += new System.EventHandler(this.apptclndrBtn_Click);
            // 
            // clndrPic
            // 
            this.clndrPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clndrPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.calendar;
            this.clndrPic.Location = new System.Drawing.Point(25, 358);
            this.clndrPic.Name = "clndrPic";
            this.clndrPic.Size = new System.Drawing.Size(50, 46);
            this.clndrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clndrPic.TabIndex = 5;
            this.clndrPic.TabStop = false;
            this.clndrPic.Click += new System.EventHandler(this.clndrPic_Click);
            // 
            // doctorPic
            // 
            this.doctorPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.SetColumnSpan(this.doctorPic, 2);
            this.doctorPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.profile_icon;
            this.doctorPic.Location = new System.Drawing.Point(88, 3);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(169, 172);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 0;
            this.doctorPic.TabStop = false;
            // 
            // emNameTxtBox
            // 
            this.emNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emNameTxtBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emNameTxtBox, 2);
            this.emNameTxtBox.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.emNameTxtBox.Location = new System.Drawing.Point(3, 178);
            this.emNameTxtBox.Name = "emNameTxtBox";
            this.emNameTxtBox.Size = new System.Drawing.Size(339, 61);
            this.emNameTxtBox.TabIndex = 1;
            this.emNameTxtBox.Text = "label1";
            this.emNameTxtBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "______________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dshboardBtn
            // 
            this.dshboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshboardBtn.AutoSize = true;
            this.dshboardBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshboardBtn.Location = new System.Drawing.Point(104, 263);
            this.dshboardBtn.Name = "dshboardBtn";
            this.dshboardBtn.Size = new System.Drawing.Size(238, 74);
            this.dshboardBtn.TabIndex = 3;
            this.dshboardBtn.Text = "Dashboard";
            this.dshboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dshbrdPic
            // 
            this.dshbrdPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dshbrdPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.dashboard;
            this.dshbrdPic.Location = new System.Drawing.Point(27, 276);
            this.dshbrdPic.Name = "dshbrdPic";
            this.dshbrdPic.Size = new System.Drawing.Size(46, 48);
            this.dshbrdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dshbrdPic.TabIndex = 4;
            this.dshbrdPic.TabStop = false;
            // 
            // srvcsPic
            // 
            this.srvcsPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srvcsPic.Image = global::DentalAppointmentInformationSystem.Properties.Resources.services;
            this.srvcsPic.Location = new System.Drawing.Point(24, 616);
            this.srvcsPic.Name = "srvcsPic";
            this.srvcsPic.Size = new System.Drawing.Size(53, 53);
            this.srvcsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.srvcsPic.TabIndex = 10;
            this.srvcsPic.TabStop = false;
            this.srvcsPic.Click += new System.EventHandler(this.srvcsPic_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12463F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.87537F));
            this.tableLayoutPanel2.Controls.Add(this.wlcmLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dshbrdLbl, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(410, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1003, 94);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // wlcmLbl
            // 
            this.wlcmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wlcmLbl.AutoSize = true;
            this.wlcmLbl.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcmLbl.Location = new System.Drawing.Point(692, 0);
            this.wlcmLbl.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.wlcmLbl.Name = "wlcmLbl";
            this.wlcmLbl.Size = new System.Drawing.Size(291, 94);
            this.wlcmLbl.TabIndex = 1;
            this.wlcmLbl.Text = "Welcome, [name]!";
            this.wlcmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(3, 0);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(246, 94);
            this.dshbrdLbl.TabIndex = 0;
            this.dshbrdLbl.Text = "Dashboard";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1537, 802);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srvcsPic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label wlcmLbl;
        private Label dshbrdLbl;
        private PictureBox doctorPic;
        private Label emNameTxtBox;
        private Label label1;
        private Label dshboardBtn;
        private PictureBox dshbrdPic;
        private Label apptclndrBtn;
        private PictureBox clndrPic;
        private Label servicesBtn;
        private Label staffBtn;
        private PictureBox staffPic;
        private Label ptntBtn;
        private PictureBox patientPic;
        private PictureBox srvcsPic;
        private Label logoutBtn;
        private PictureBox logoutPic;
    }
}