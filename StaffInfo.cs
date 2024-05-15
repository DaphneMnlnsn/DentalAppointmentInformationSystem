using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentInformationSystem
{
    public partial class StaffInfo : UserControl
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private string _employee_id;
        private string _employee_name;
        private string _age;
        private string _birthdate;
        private string _role;
        private string _contact;
        private string _password;

        private void StaffInfo_Load(object sender, EventArgs e)
        {

        }

        public string employee_id
        {
            get { return employee_id; }
            set { employee_id = value; emplyeeNumLbl.Text = value; }
        }
        public string employee_name
        {
            get { return employee_name; }
            set { employee_name = value; fullNameLbl.Text = value; }
        }
        public string age
        {
            get { return age; }
            set { age = value; ageLbl.Text = value.ToString(); }
        }
        public string birthdate
        {
            get { return birthdate; }
            set { birthdate = value; bdateLbl.Text = value; }
        }
        public string role
        {
            get { return role; }
            set { role = value; roleLbl.Text = value; }
        }
        public string contact
        {
            get { return contact; }
            set { contact = value; contactLbl.Text = value; }
        }
        public string password
        {
            get { return password; }
            set { password = value; passLbl.Text = value; }
        }

    }
}
