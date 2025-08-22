using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDoctors_Click(object sender, EventArgs e)
        {
            DoctorListForm form = new DoctorListForm();
            form.ShowDialog();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm();
            form.ShowDialog();
        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm form = new ManageAppointmentsForm();
            form.ShowDialog();
        }
    }
}
