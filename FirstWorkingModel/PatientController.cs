using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWorkingModel
{
    public class PatientController
    {
        private static List<Patient> m_patients = new List<Patient>();
        public List<Patient> Patients { get { return m_patients; } set { m_patients = value; } }
        private static PatientController m_getInstance;
        public static PatientController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new PatientController();
            }
            return m_getInstance;
        }

        public void AddPatient(string first, string last, string address, string phone, string postcode, string dob)
        {
            Patients.Add(new Patient(first, last, address, phone, postcode, dob));
            DataController.Instance().InsertPatientData();
        }
    }
}
