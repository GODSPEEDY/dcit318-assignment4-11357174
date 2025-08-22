using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MedicalAppointmentSystem.Models;

namespace MedicalAppointmentSystem
{
    public partial class AppointmentForm : Form
    {
        private readonly int? _doctorIdPrefill;
        private readonly string _doctorNamePrefill;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        // Overload used when launched from DoctorListForm
        public AppointmentForm(int doctorId, string doctorName) : this()
        {
            _doctorIdPrefill = doctorId;
            _doctorNamePrefill = doctorName;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Book Appointment";

            // Load doctors & patients from DB
            var doctors = DbHelper.GetDoctors();
            var patients = DbHelper.GetPatients();

            cbDoctor.DisplayMember = "FullName";
            cbDoctor.ValueMember = "DoctorID";
            cbDoctor.DataSource = doctors;

            cbPatient.DisplayMember = "FullName";
            cbPatient.ValueMember = "PatientID";
            cbPatient.DataSource = patients;

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDate.MinDate = DateTime.Now.AddMinutes(5);

            if (_doctorIdPrefill.HasValue)
            {
                // Preselect + lock
                cbDoctor.SelectedValue = _doctorIdPrefill.Value;
                cbDoctor.Enabled = false;
                lblHeader.Text = $"Book with: {_doctorNamePrefill}";
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedValue == null || cbPatient.SelectedValue == null)
            {
                MessageBox.Show("Please select both a doctor and a patient.");
                return;
            }

            var selectedDate = dtpDate.Value;
            if (selectedDate <= DateTime.Now)
            {
                MessageBox.Show("Please choose a future date/time.");
                return;
            }

            int doctorId = (int)cbDoctor.SelectedValue;
            int patientId = (int)cbPatient.SelectedValue;
            string notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim();

            // Check availability using ADO.NET (DbHelper -> single connection, multiple result sets)
            if (!DbHelper.IsDoctorAvailable(doctorId, selectedDate))
            {
                MessageBox.Show("This doctor is not available at that time or already booked. Please choose another slot.");
                return;
            }

            var appt = new Appointment
            {
                DoctorID = doctorId,
                PatientID = patientId,
                AppointmentDate = selectedDate,
                Notes = notes
            };

            bool ok = DbHelper.InsertAppointment(appt);
            if (ok)
            {
                MessageBox.Show("Appointment booked successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to book appointment.");
            }
        }
    }
}
