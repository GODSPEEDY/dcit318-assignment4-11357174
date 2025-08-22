using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class DoctorListForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        public DoctorListForm()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var table = new System.Data.DataTable();
                        table.Load(reader);
                        dgvDoctors.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }
        // Add this method to DoctorListForm.cs to fix CS1061
        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the "Book Appointment" button column
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDoctors.Columns["colBook"].Index)
            {
                // You can add your booking logic here, e.g.:
                // var doctorId = dgvDoctors.Rows[e.RowIndex].Cells["DoctorId"].Value;
                MessageBox.Show("Book Appointment clicked for row " + e.RowIndex);
            }
        }
        // Add this method to DoctorListForm.cs to fix CS1061
        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            // You can add initialization logic here, such as loading doctors into the grid.
            LoadDoctors();
        }
    }
}
