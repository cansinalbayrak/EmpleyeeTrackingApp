using EmployeeTrackingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Services
{
    public interface ISystemUserService : IService<SystemUser>
    {
        //Sisteme kayıt olma ve  giriş fonksiyonları
        public bool IsStrongPassword(string password);
        public bool IsSpecialCharacter(char character);
        public bool IsUserExist(string username);
        public int IsAccountTrue(string username, string password);
        //public bool IsUserOwner();
         
    }
}
