using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FirstWorkingModel
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            datagrid_Patients.DataSource = DataController.Instance().getPatientData();
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            new NewPatientForm().Show();
        }

        private void datagrid_Appointments_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagrid_Appointments.SelectedRows)
            {
                MessageBox.Show("Appointment selected for " + row.Cells[1].Value.ToString() + " at " + row.Cells[0].Value.ToString() + " with " + row.Cells[2].Value.ToString());
            }
        }

        public void RefreshPatientData()
        {
            DataController.Instance().InsertPatientData();
            datagrid_Patients.Refresh();
        }
    }
}
