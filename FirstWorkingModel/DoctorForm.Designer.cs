namespace FirstWorkingModel
{
    partial class DoctorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage_Appointments = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabpage_CurrentPatient = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpage_Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabpage_CurrentPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage_Appointments);
            this.tabControl1.Controls.Add(this.tabpage_CurrentPatient);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage_Appointments
            // 
            this.tabpage_Appointments.Controls.Add(this.dataGridView1);
            this.tabpage_Appointments.Location = new System.Drawing.Point(4, 22);
            this.tabpage_Appointments.Name = "tabpage_Appointments";
            this.tabpage_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_Appointments.Size = new System.Drawing.Size(651, 222);
            this.tabpage_Appointments.TabIndex = 0;
            this.tabpage_Appointments.Text = "Appointments";
            this.tabpage_Appointments.UseVisualStyleBackColor = true;
            this.tabpage_Appointments.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabpage_CurrentPatient
            // 
            this.tabpage_CurrentPatient.Controls.Add(this.button1);
            this.tabpage_CurrentPatient.Controls.Add(this.dataGridView2);
            this.tabpage_CurrentPatient.Location = new System.Drawing.Point(4, 22);
            this.tabpage_CurrentPatient.Name = "tabpage_CurrentPatient";
            this.tabpage_CurrentPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_CurrentPatient.Size = new System.Drawing.Size(651, 222);
            this.tabpage_CurrentPatient.TabIndex = 1;
            this.tabpage_CurrentPatient.Text = "Current Patient";
            this.tabpage_CurrentPatient.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 184);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(592, 266);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prescribe Medication";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 297);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorForm";
            this.Text = "Doctor";
            this.tabControl1.ResumeLayout(false);
            this.tabpage_Appointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabpage_CurrentPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage_Appointments;
        private System.Windows.Forms.TabPage tabpage_CurrentPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button button1;
    }
}