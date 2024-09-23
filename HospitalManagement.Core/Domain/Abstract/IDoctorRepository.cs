using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);
        void Update(Doctor doctor); 
        void Delete(int  id);
        Doctor Get(int id);
        List<Doctor> GetAll();
    }
}
