using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentInformationSystem
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            populateItems();
        }
        public static int countRows(string tablename, string connStr = null)
        {
            string stmt = string.Format("SELECT COUNT(*) FROM {0}", tablename);
            if (String.IsNullOrEmpty(connStr))
                connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DAISdB.mdf;Integrated Security=True";
            int count = 0;
            using (SqlConnection thisConnection = new SqlConnection(connStr))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }

        private void populateItems()
        {
            StaffInfo[] staffInfos = new StaffInfo[countRows("Staff", null)];
            for(int i = 0; i < staffInfos.Length; i++)
            {
                StaffInfo staffInfo = new StaffInfo();
                /*constring.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    staffInfos[i].employee_id = reader1.GetValue(0).ToString();
                    if (reader1.GetValue(2).ToString().Equals(null) || reader1.GetValue(2).ToString().Equals(""))
                    {
                        staffInfos[i].employee_name = reader1.GetValue(3).ToString() + " " + reader1.GetValue(1).ToString();
                    }
                    else
                    {
                        staffInfos[i].employee_name = reader1.GetValue(3).ToString() + " " + reader1.GetValue(2).ToString() + reader1.GetValue(1).ToString();
                    }
                    if (reader1.GetValue(5).ToString().Equals(null) || reader1.GetValue(2).ToString().Equals(""))
                    {
                    }
                    else
                    {
                        staffInfos[i].age = reader1.GetValue(5).ToString();
                    }
                    staffInfos[i].birthdate = reader1.GetValue(6).ToString();
                    staffInfos[i].role = reader1.GetValue(7).ToString();
                    staffInfos[i].contact = reader1.GetValue(4).ToString();
                    staffInfos[i].password = reader1.GetValue(8).ToString();
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                constring.Close();*/
                staffInfo.employee_id = "Hi";
                staffInfo.employee_name = "Hello";
                staffInfo.age = "13";
                staffInfo.birthdate = "reader1.ToString()";
                staffInfo.role = "reader1.ToString()";
                staffInfo.contact = "GetValue(4).ToString()";
                staffInfo.password = "reader1.GetValue(8).";
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(staffInfo);
                }
            }
        }
    }
}
