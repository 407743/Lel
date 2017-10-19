using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWorkingModel
{
    public class Patient
    {
        private string m_FirstName;
        private string m_LastName;
        private string m_Address;
        private string m_Postcode;
        private string m_DOB;

        public string FirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string LastName { get { return m_LastName; } set { m_LastName = value; } }
        public string Address { get { return m_Address; } set { m_Address = value; } }
        public string Postcode { get { return m_Postcode; } set { m_Postcode = value; } }
        public string DOB { get { return m_DOB; } set { m_DOB = value; } }

        public Patient(string first, string last, string address, string postcode, string dob)
        {
            FirstName = first;
            LastName = last;
            Address = address;
            Postcode = postcode;
            DOB = dob;
        }
    }
}
