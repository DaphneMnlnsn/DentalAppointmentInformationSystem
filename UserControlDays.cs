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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void lbldays_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }


    }
}
