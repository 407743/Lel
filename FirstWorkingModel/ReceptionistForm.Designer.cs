namespace FirstWorkingModel
{
    partial class ReceptionistForm
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
            this.tab_receptionist = new System.Windows.Forms.TabControl();
            this.tab_Appointments = new System.Windows.Forms.TabPage();
            this.datagrid_Appointments = new System.Windows.Forms.DataGridView();
            this.tab_Patients = new System.Windows.Forms.TabPage();
            this.datagrid_Patients = new System.Windows.Forms.DataGridView();
            this.btn_NewPatient = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_surgeryname = new System.Windows.Forms.Label();
            this.tab_receptionist.SuspendLayout();
            this.tab_Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Appointments)).BeginInit();
            this.tab_Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Patients)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_receptionist
            // 
            this.tab_receptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_receptionist.Controls.Add(this.tab_Appointments);
            this.tab_receptionist.Controls.Add(this.tab_Patients);
            this.tab_receptionist.Location = new System.Drawing.Point(12, 54);
            this.tab_receptionist.Name = "tab_receptionist";
            this.tab_receptionist.SelectedIndex = 0;
            this.tab_receptionist.Size = new System.Drawing.Size(817, 336);
            this.tab_receptionist.TabIndex = 0;
            // 
            // tab_Appointments
            // 
            this.tab_Appointments.Controls.Add(this.datagrid_Appointments);
            this.tab_Appointments.Location = new System.Drawing.Point(4, 22);
            this.tab_Appointments.Name = "tab_Appointments";
            this.tab_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Appointments.Size = new System.Drawing.Size(809, 352);
            this.tab_Appointments.TabIndex = 0;
            this.tab_Appointments.Text = "Appointments";
            this.tab_Appointments.UseVisualStyleBackColor = true;
            // 
            // datagrid_Appointments
            // 
            this.datagrid_Appointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Appointments.Location = new System.Drawing.Point(6, 6);
            this.datagrid_Appointments.Name = "datagrid_Appointments";
            this.datagrid_Appointments.Size = new System.Drawing.Size(800, 340);
            this.datagrid_Appointments.TabIndex = 0;
            this.datagrid_Appointments.SelectionChanged += new System.EventHandler(this.datagrid_Appointments_SelectionChanged);
            // 
            // tab_Patients
            // 
            this.tab_Patients.Controls.Add(this.datagrid_Patients);
            this.tab_Patients.Controls.Add(this.btn_NewPatient);
            this.tab_Patients.Location = new System.Drawing.Point(4, 22);
            this.tab_Patients.Name = "tab_Patients";
            this.tab_Patients.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Patients.Size = new System.Drawing.Size(809, 310);
            this.tab_Patients.TabIndex = 2;
            this.tab_Patients.Text = "Patients";
            this.tab_Patients.UseVisualStyleBackColor = true;
            // 
            // datagrid_Patients
            // 
            this.datagrid_Patients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Patients.Location = new System.Drawing.Point(6, 6);
            this.datagrid_Patients.Name = "datagrid_Patients";
            this.datagrid_Patients.Size = new System.Drawing.Size(797, 269);
            this.datagrid_Patients.TabIndex = 1;
            // 
            // btn_NewPatient
            // 
            this.btn_NewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewPatient.Location = new System.Drawing.Point(728, 281);
            this.btn_NewPatient.Name = "btn_NewPatient";
            this.btn_NewPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPatient.TabIndex = 0;
            this.btn_NewPatient.Text = "New Patient";
            this.btn_NewPatient.UseVisualStyleBackColor = true;
            this.btn_NewPatient.Click += new System.EventHandler(this.btn_NewPatient_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Logout.Location = new System.Drawing.Point(16, 397);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_surgeryname
            // 
            this.lbl_surgeryname.AutoSize = true;
            this.lbl_surgeryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgeryname.Location = new System.Drawing.Point(19, 9);
            this.lbl_surgeryname.Name = "lbl_surgeryname";
            this.lbl_surgeryname.Size = new System.Drawing.Size(450, 24);
            this.lbl_surgeryname.TabIndex = 2;
            this.lbl_surgeryname.Text = "Over Surgery - Paperless System | Receptionist";
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 432);
            this.Controls.Add(this.lbl_surgeryname);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.tab_receptionist);
            this.Name = "ReceptionistForm";
            this.Text = "Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.tab_receptionist.ResumeLayout(false);
            this.tab_Appointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Appointments)).EndInit();
            this.tab_Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_receptionist;
        private System.Windows.Forms.TabPage tab_Appointments;
        private System.Windows.Forms.DataGridView datagrid_Appointments;
        private System.Windows.Forms.TabPage tab_Patients;
        private System.Windows.Forms.Button btn_NewPatient;
        private System.Windows.Forms.DataGridView datagrid_Patients;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_surgeryname;
    }
}