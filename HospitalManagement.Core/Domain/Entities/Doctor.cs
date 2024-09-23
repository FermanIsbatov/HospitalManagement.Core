using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; } 
        public string Firstname {  get; set; }
        public string Lastname {  get; set; }
        public string AreaOfExperties {  get; set; }
        public int InternshipYear {  get; set; }

    }
}
