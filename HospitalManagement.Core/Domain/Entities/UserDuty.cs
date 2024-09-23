using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Entities
{
    public class UserDuty
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Duty Duty { get; set; }
    }
}
