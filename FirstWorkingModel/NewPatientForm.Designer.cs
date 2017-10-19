namespace FirstWorkingModel
{
    partial class NewPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_StreetAddress = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_PostCode = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_StreetAddress = new System.Windows.Forms.Label();
            this.lbl_PostCode = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(106, 8);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_StreetAddress
            // 
            this.txt_StreetAddress.Location = new System.Drawing.Point(106, 86);
            this.txt_StreetAddress.Name = "txt_StreetAddress";
            this.txt_StreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_StreetAddress.TabIndex = 1;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(106, 60);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 2;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(106, 34);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 3;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(12, 15);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 4;
            this.lbl_FirstName.Text = "First Name";
            // 
            // txt_PostCode
            // 
            this.txt_PostCode.Location = new System.Drawing.Point(106, 112);
            this.txt_PostCode.Name = "txt_PostCode";
            this.txt_PostCode.Size = new System.Drawing.Size(100, 20);
            this.txt_PostCode.TabIndex = 5;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(11, 37);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 6;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(11, 63);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(78, 13);
            this.lbl_Phone.TabIndex = 7;
            this.lbl_Phone.Text = "Phone Number";
            // 
            // lbl_StreetAddress
            // 
            this.lbl_StreetAddress.AutoSize = true;
            this.lbl_StreetAddress.Location = new System.Drawing.Point(12, 89);
            this.lbl_StreetAddress.Name = "lbl_StreetAddress";
            this.lbl_StreetAddress.Size = new System.Drawing.Size(45, 13);
            this.lbl_StreetAddress.TabIndex = 8;
            this.lbl_StreetAddress.Text = "Address";
            // 
            // lbl_PostCode
            // 
            this.lbl_PostCode.AutoSize = true;
            this.lbl_PostCode.Location = new System.Drawing.Point(12, 115);
            this.lbl_PostCode.Name = "lbl_PostCode";
            this.lbl_PostCode.Size = new System.Drawing.Size(52, 13);
            this.lbl_PostCode.TabIndex = 9;
            this.lbl_PostCode.Text = "Postcode";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(222, 11);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(66, 13);
            this.lbl_DOB.TabIndex = 10;
            this.lbl_DOB.Text = "Date of Birth";
            // 
            // dTP_DOB
            // 
            this.dTP_DOB.Location = new System.Drawing.Point(225, 30);
            this.dTP_DOB.Name = "dTP_DOB";
            this.dTP_DOB.Size = new System.Drawing.Size(200, 20);
            this.dTP_DOB.TabIndex = 11;
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(405, 226);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPatient.TabIndex = 12;
            this.btn_AddPatient.Text = "Add Patient";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.Controls.Add(this.btn_AddPatient);
            this.Controls.Add(this.dTP_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_PostCode);
            this.Controls.Add(this.lbl_StreetAddress);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.txt_PostCode);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_StreetAddress);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "NewPatientForm";
            this.Text = "New Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_StreetAddress;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_PostCode;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_StreetAddress;
        private System.Windows.Forms.Label lbl_PostCode;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dTP_DOB;
        private System.Windows.Forms.Button btn_AddPatient;
    }
}