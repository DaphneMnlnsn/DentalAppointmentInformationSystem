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
        static int month, year;

        public string getsetloggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }

        public int getsetMonth
        {
            get { return month; }
            set {  month = value; }
        }

        public int getsetYear
        {
            get { return year; }
            set { year = value; }
        }
    }
}
