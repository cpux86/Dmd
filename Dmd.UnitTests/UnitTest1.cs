using Dmd.Domain.Modeles.Entityes;
using Dmd.Domain.Repository;
using System;
using Xunit;

namespace Dmd.UnitTests
{
    public class UnitUser
    {
        [Fact]
        public void AddUser()
        {
            User user = new User() { FirstName = "Владимир", LastName="Каськов", Email = "cpux86@mail.ru", Phone = "+79997961175" };
            UserRepository rep = new UserRepository();
            rep.Add(user);
            rep.Save();
        }
    }
}
