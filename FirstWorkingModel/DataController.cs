using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FirstWorkingModel
{
    class DataController
    {
        private DataController()
        {
            List<DataColumn> patientdataColumn = new List<DataColumn>();
            List<DataColumn> appointmentdataColumn = new List<DataColumn>();
            dt_patients = new DataTable();
            dt_appointments = new DataTable();
            patientdataColumn.Add(new DataColumn("First Name", typeof(string)));
            patientdataColumn.Add(new DataColumn("Last Name", typeof(string)));
            patientdataColumn.Add(new DataColumn("Date of Birth", typeof(string)));
            appointmentdataColumn.Add(new DataColumn("Time", typeof(string)));
            appointmentdataColumn.Add(new DataColumn("Patient", typeof(string)));
            appointmentdataColumn.Add(new DataColumn("Doctor/Nurse", typeof(string)));
            foreach (DataColumn d in patientdataColumn)
            {
                DataTablePatients.Columns.Add(d);
            }
            foreach(DataColumn d in appointmentdataColumn)
            {
                DataTableAppointments.Columns.Add(d);
            }
        }
        private static DataController m_getInstance;
        private static DataTable dt_patients;
        private static DataTable dt_appointments;
        public DataTable DataTablePatients { get { return dt_patients; } set { dt_patients = value; } }
        public DataTable DataTableAppointments { get { return dt_appointments; } set { dt_appointments = value; } }

        public static DataController Instance()
        {
            if(m_getInstance == null)
            {
                m_getInstance = new DataController();
            }
            return m_getInstance;
        }

        public DataTable getPatientData()
        {
            return DataTablePatients;
        }

        public DataTable getAppointmentData()
        {
            return DataTableAppointments;
        }

        public void InsertPatientData()
        {
            Patient p = PatientController.Instance().Patients[PatientController.Instance().Patients.Count - 1];
            {
                DataTablePatients.Rows.Add(p.FirstName, p.LastName, p.DOB);
            }
        }
    }
}
