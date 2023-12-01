using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.UserManagement
{
    public class UserManager
    {
        public void AddUser(string username)
        {
            if (MyUtilityClass.IsDataValid(username))
            {
                MyUtilityClass.LogMessage($"User added: {username}");
                
            }
            else
            {
                MyUtilityClass.LogMessage($"Invalid username: {username}");
            }


        }
    }
 }
