using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class DoctorAppointment
    {
        public int Id { get; set; }
        public Doctor Doctor {  get; set; }
        public Appointment Appointment { get; set; }
        public string InterviewNotesWithPatient {  get; set; }
        public string TreatmentProcess {  get; set; }
    }
}
