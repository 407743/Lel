using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FirstWorkingModel
{
    public partial class ReceptionistForm : Form
    {
        LoginForm l;
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            datagrid_Patients.DataSource = DataController.Instance().getPatientData();
            datagrid_Appointments.DataSource = DataController.Instance().getAppointmentData();
            datagrid_Patients.AllowUserToDeleteRows = false;
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            new NewPatientForm().Show();
        }

        private void datagrid_Appointments_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Close();
            Show();
        }
    }
}
