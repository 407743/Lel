using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FirstWorkingModel
{
    public partial class DoctorForm : Form
    {
        public LoginForm RefToLogin { get; set; }
        public DoctorForm(LoginForm reflogin)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
