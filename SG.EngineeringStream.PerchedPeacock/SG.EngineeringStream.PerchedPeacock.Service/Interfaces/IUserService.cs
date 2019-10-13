using SG.EngineeringStream.PerchedPeacock.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Service.Interfaces
{
    public interface IUserService
    {
        //User Authenticate(string username, string password);
        //IEnumerable<User> GetAll();
        //User GetById(int id);
        bool RegisterUser(User User,string ConnectionString);

        User SignIn(User User, string ConnectionString);
    }
}
