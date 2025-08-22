using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class ManageAppointmentsForm : Form
    {
        private string connectionString = "Server=localhost;Database=MedicalDB;Integrated Security=True;";
        private SqlDataAdapter adapter;
        private DataSet ds;

        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT a.AppointmentID, d.FullName AS Doctor, 
                                            p.FullName AS Patient, 
                                            a.AppointmentDate, a.Notes
                                     FROM Appointments a
                                     JOIN Doctors d ON a.DoctorID = d.DoctorID
                                     JOIN Patients p ON a.PatientID = p.PatientID";

                    adapter = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Appointments");
                    dgvAppointments.DataSource = ds.Tables["Appointments"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ds == null) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    adapter.UpdateCommand = new SqlCommand(
                        "UPDATE Appointments SET AppointmentDate=@date, Notes=@notes WHERE AppointmentID=@id", conn);

                    adapter.UpdateCommand.Parameters.Add("@date", SqlDbType.DateTime, 0, "AppointmentDate");
                    adapter.UpdateCommand.Parameters.Add("@notes", SqlDbType.VarChar, 200, "Notes");
                    adapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 0, "AppointmentID");

                    int rows = adapter.Update(ds, "Appointments");
                    MessageBox.Show(rows + " appointment(s) updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Appointment deleted.");
                            btnLoad_Click(null, null); // Refresh grid
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }
    }
}
