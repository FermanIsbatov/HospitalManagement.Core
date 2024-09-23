﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }  
        public string PatientCondition {  get; set; } 
        public DateTime AppointmentDate {  get; set; }
    }
}
