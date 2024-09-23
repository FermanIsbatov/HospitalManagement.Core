using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IUserDutyRepository
    {
        void Add(UserDuty userduty);
        void Delete(int id);
        List<UserDuty> GetByUserId(int userid);
        List<UserDuty> GetByDutyId(int dutyid);
    }
}
