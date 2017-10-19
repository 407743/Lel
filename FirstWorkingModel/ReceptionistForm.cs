using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace FirstWorkingModel
{
    public partial class ReceptionistForm : Form
    {
        public LoginForm RefToLogin { get; set; }
        public ReceptionistForm(LoginForm reflogin)
        {
            try
            {
                RefToLogin = reflogin;
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            datagrid_Patients.DataSource = DataController.Instance().getPatientDataTable();
            datagrid_Appointments.DataSource = DataController.Instance().getAppointmentDataTable();
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
            RefToLogin.ShowLogin();
        }
    }
}
