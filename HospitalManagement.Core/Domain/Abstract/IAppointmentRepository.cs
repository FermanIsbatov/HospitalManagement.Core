using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IAppointmentRepository
    {
        void Add(Appointment appointment);  
        void Update(Appointment appointment);
        void Delete(int id);
        Appointment Get(int id);
        List<Appointment> GetAll(); 
    }
}
