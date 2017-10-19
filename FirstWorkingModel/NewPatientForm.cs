using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWorkingModel
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
            dTP_DOB.MaxDate = DateTime.Today;
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            PatientController.Instance().AddPatient(txt_FirstName.Text, txt_LastName.Text, txt_StreetAddress.Text, txt_Phone.Text,txt_PostCode.Text, dTP_DOB.Value.ToString("dd-MM-yyyy"));
            Close();
        }
    }
}
