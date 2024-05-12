using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalAppointmentInformationSystem
{
    internal class Variables
    {
        static string loggedIn;

        public string getsetloggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }
    }
}
