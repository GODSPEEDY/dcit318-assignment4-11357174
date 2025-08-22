using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentSystem.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public bool Availability { get; set; }
    }

    public class Patient
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
    }
}