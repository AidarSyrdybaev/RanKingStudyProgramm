using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingAppProject
{
    class User
    {
       public string Login;
       public string Password;

        public User(string _Login, string _Password)
        {
            Login = _Login;
            Password = _Password;
        }
    }
}
