namespace MedicalAppointmentSystem
{
    partial class MainForm
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
            this.btnViewDoctors = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewDoctors
            // 
            this.btnViewDoctors.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctors.Location = new System.Drawing.Point(285, 158);
            this.btnViewDoctors.Name = "btnViewDoctors";
            this.btnViewDoctors.Size = new System.Drawing.Size(181, 34);
            this.btnViewDoctors.TabIndex = 0;
            this.btnViewDoctors.Text = "View Doctors";
            this.btnViewDoctors.UseVisualStyleBackColor = true;
            this.btnViewDoctors.Click += new System.EventHandler(this.btnViewDoctors_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAppointment.Location = new System.Drawing.Point(285, 198);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(181, 38);
            this.btnBookAppointment.TabIndex = 1;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAppointments.Location = new System.Drawing.Point(285, 242);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(181, 33);
            this.btnManageAppointments.TabIndex = 2;
            this.btnManageAppointments.Text = "Manage Appointments";
            this.btnManageAppointments.UseVisualStyleBackColor = true;
            this.btnManageAppointments.Click += new System.EventHandler(this.btnManageAppointments_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageAppointments);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnViewDoctors);
            this.Name = "MainForm";
            this.Text = "Medical Appointment Booking System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDoctors;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnManageAppointments;
    }
}