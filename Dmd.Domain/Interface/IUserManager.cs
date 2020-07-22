using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Interface
{
    interface IUserManager
    {
        void CreateUser();
        //void GetUser();
        void EditUser();
        void DeleteUser();
    }
}
