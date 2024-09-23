using HospitalManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core.Domain.Abstract
{
    public interface IUserRepository
    {
        void Add (User user);
        void Update (User user);
        void Delete(int id);
        User Get (int id);
        List<User> GetAll ();   
    }
}
