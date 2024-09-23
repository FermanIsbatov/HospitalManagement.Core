using HospitalManagement.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class PatientMedicalReport
    {
        public int Id {  get; set; }
        public Patient Patient { get; set; }
        public string MedicalHistory { get; set; }
        public string Treatment { get; set; }
        public Disease Disease { get; set; }
    }
}
