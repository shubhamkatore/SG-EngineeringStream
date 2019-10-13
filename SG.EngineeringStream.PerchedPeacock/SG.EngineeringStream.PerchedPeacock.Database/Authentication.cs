using SG.EngineeringStream.PerchedPeacock.DBHelper;
using SG.EngineeringStream.PerchedPeacock.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Database
{
    public class Authentication
    {

        public bool RegisterUser(User user, string ConnectionString)
        {
            var paramDict = new Dictionary<string, string>() {
                {"FirstName",user.FirstName },
                {"LastName",user.LastName },
                {"Email",user.Email },
                {"Username",user.Username },
                {"Password",user.Password },
                {"Role","User" }
            };
            var DataOperation = SQLOperation.ExecuteCommand(ConnectionString, "InsertUser", paramDict);
            return true;
        }

        public User SignIn(User user, string ConnectionString)
        {
            var paramDict = new Dictionary<string, string>() {
                {"Email",user.Email },
                {"Password",user.Password }
            };
            var DataOperation = SQLOperation.ExecuteCommand(ConnectionString, "GetUser", paramDict);
            try
            {
                var DataRow = DataOperation.Rows[0];
                return new User
                {
                    FirstName = DataRow["FirstName"].ToString(),
                    LastName = DataRow["LastName"].ToString(),
                    Email = DataRow["Email"].ToString(),
                    Username = DataRow["Username"].ToString(),
                    Role = DataRow["Role"].ToString(),
                };
            }
            catch (Exception)
            {
                return new User();
            }
            
        }
    }
}
