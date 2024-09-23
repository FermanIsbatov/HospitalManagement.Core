using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class Patient
    {
        public int Id {  get; set; }
        public string Firstname {  get; set; }
        public string Lastname { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string ContactInformation {  get; set; } 
    }
}
