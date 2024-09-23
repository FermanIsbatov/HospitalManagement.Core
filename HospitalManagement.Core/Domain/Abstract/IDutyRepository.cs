using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IDutyRepository
    {
        void Add(Duty duty);
        void Update(Duty duty);
        void Delete(int id);
        Duty Get(int id);
        List<Duty> GetAll();
    }
}
