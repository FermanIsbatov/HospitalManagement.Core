using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IPatientRepository
    {
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
        Patient Get(int id);
        List<Patient> GetAll();
    }
}
