using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWorkingModel
{
    public partial class NurseForm : Form
    {
        private LoginForm RefToLogin { get; set; }
        public NurseForm(LoginForm reflogin)
        {
            try
            {
                RefToLogin = reflogin;
            }
            catch(Exception e)
            {
                Debug.Print(e.Message);
            }
            InitializeComponent();
        }
    }
}
