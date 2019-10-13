using SG.EngineeringStream.PerchedPeacock.Database;
using SG.EngineeringStream.PerchedPeacock.Models;
using SG.EngineeringStream.PerchedPeacock.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Service
{
    public class UserService : IUserService
    {
        Authentication _authentication;
        public UserService()
        {
            _authentication = new Authentication();
        }
        public bool RegisterUser(User User,string ConnectionString)
        {
            return _authentication.RegisterUser(User, ConnectionString);
        }

        public User SignIn(User User, string ConnectionString)
        {
            return _authentication.SignIn(User, ConnectionString);
        }
    }
}
