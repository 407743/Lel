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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text.ToLower();
            string password = txt_Password.Text.ToLower();
            if (password == "password123")
            {
                switch (user[0])
                {
                    case 'p':
                        break;
                    case 'r':
                        break;
                    case 'd':
                        break;
                    case 'n':
                        break;
                    default:
                        MessageBox.Show("Username not recognized");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Password incorrect");
            }
        }
    }
}
