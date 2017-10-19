﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text.ToLower();
            string password = txt_Password.Text.ToLower();
            switch (user[0])
            {
                case 'p':
                    if (ValidatePassword(password))
                    {
                        new PracticeManagerForm(this).Show();
                        Hide();

                    }
                    break;
                case 'r':
                    if (ValidatePassword(password))
                    {
                        new ReceptionistForm(this).Show();
                        Hide();
                    }
                    break;
                case 'd':
                    if (ValidatePassword(password))
                    {
                        new DoctorForm(this).Show();
                        Hide();

                    }
                    break;
                case 'n':
                    if (ValidatePassword(password))
                    {
                        NurseForm nuf = new NurseForm(this);
                        Hide();

                    }
                    break;
                default:
                    MessageBox.Show("Username not recognized");
                    break;
            }
        }

        bool ValidatePassword(string pass)
        {
            bool validated;
            if (pass == "password")
            {
                validated = true;
            }
            else
            {
                validated = false;
                MessageBox.Show("Password Incorrect, please try again");
            }
            return validated;
        }

        public void ShowLogin()
        {
            Show();
        }
    }
}
