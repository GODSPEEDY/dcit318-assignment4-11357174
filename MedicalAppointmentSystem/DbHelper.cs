using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MedicalAppointmentSystem.Models;

namespace MedicalAppointmentSystem
{
    public static class DbHelper
    {
        private static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        // Get list of doctors
        public static List<Doctor> GetDoctors()
        {
            var list = new List<Doctor>();
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT DoctorID, FullName, Specialty, Availability FROM Doctors", conn))
            {
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Doctor
                            {
                                DoctorID = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Specialty = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Availability = reader.GetBoolean(3)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctors: " + ex.Message);
                }
            }
            return list;
        }

        // Get list of patients
        public static List<Patient> GetPatients()
        {
            var list = new List<Patient>();
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT PatientID, FullName, Email FROM Patients", conn))
            {
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Patient
                            {
                                PatientID = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Email = reader.IsDBNull(2) ? "" : reader.GetString(2)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patients: " + ex.Message);
                }
            }
            return list;
        }

        // Check if doctor is available for a given slot
        public static bool IsDoctorAvailable(int doctorId, DateTime date)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                @"SELECT Availability FROM Doctors WHERE DoctorID=@docId;
                  SELECT COUNT(*) FROM Appointments WHERE DoctorID=@docId AND AppointmentDate=@date;", conn))
            {
                cmd.Parameters.AddWithValue("@docId", doctorId);
                cmd.Parameters.AddWithValue("@date", date);

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return false;
                        bool available = reader.GetBoolean(0);

                        if (!reader.NextResult()) return false;
                        reader.Read();
                        int conflicts = reader.GetInt32(0);

                        return available && conflicts == 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking availability: " + ex.Message);
                    return false;
                }
            }
        }

        // Insert appointment
        public static bool InsertAppointment(Appointment appt)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes) VALUES (@docId, @patId, @date, @notes)", conn))
            {
                cmd.Parameters.AddWithValue("@docId", appt.DoctorID);
                cmd.Parameters.AddWithValue("@patId", appt.PatientID);
                cmd.Parameters.AddWithValue("@date", appt.AppointmentDate);
                cmd.Parameters.AddWithValue("@notes", (object)appt.Notes ?? DBNull.Value);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error booking appointment: " + ex.Message);
                    return false;
                }
            }
        }

        // Get appointments (DataSet for DataGridView)
        public static DataSet GetAppointments(int? patientId = null)
        {
            var ds = new DataSet();
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(@"
                SELECT a.AppointmentID, d.FullName AS Doctor, p.FullName AS Patient,
                       a.AppointmentDate, a.Notes
                FROM Appointments a
                JOIN Doctors d ON a.DoctorID = d.DoctorID
                JOIN Patients p ON a.PatientID = p.PatientID
                WHERE (@patId IS NULL OR a.PatientID=@patId)
                ORDER BY a.AppointmentDate", conn))
            {
                cmd.Parameters.AddWithValue("@patId", (object)patientId ?? DBNull.Value);

                try
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds, "Appointments");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
            return ds;
        }

        // Update appointment date
        public static bool UpdateAppointmentDate(int appointmentId, DateTime newDate)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "UPDATE Appointments SET AppointmentDate=@date WHERE AppointmentID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@date", newDate);
                cmd.Parameters.AddWithValue("@id", appointmentId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating appointment: " + ex.Message);
                    return false;
                }
            }
        }

        // Delete appointment
        public static bool DeleteAppointment(int appointmentId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting appointment: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
