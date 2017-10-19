using System;
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
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Time", typeof(string));
            DataColumn dc2 = new DataColumn("Patient", typeof(string));
            DataColumn dc3 = new DataColumn("Doctor", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            datagrid_Appointments.DataSource = dt;
            dt.Rows.Add("12:00", "Mr Rogers", "Dr. Steve");
            dt.Rows.Add("12:10", "Mr Brown", "Dr Ruth");
            dt.Rows.Add("12:20", "Mrs Green", "Dr Chris");
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            new NewPatientForm().Show();
            Hide();
        }
    }
}
