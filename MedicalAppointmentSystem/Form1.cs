using MedicalAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestDb_Click(object sender, EventArgs e)
        {
            List<Doctor> doctors = DbHelper.GetDoctors();

            if (doctors.Count == 0)
            {
                MessageBox.Show("No doctors found in database.");
                return;
            }

            string result = "Doctors List:\n\n";
            foreach (var doc in doctors)
            {
                result += $"{doc.DoctorID} - {doc.FullName} ({doc.Specialty}) | Available: {(doc.Availability ? "Yes" : "No")}\n";
            }

            MessageBox.Show(result, "Doctors");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Add any initialization logic needed when the form loads
        }
    }
}
