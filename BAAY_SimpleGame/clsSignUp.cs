 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAAY_SimpleGame
{
    class clsSignUp
    {
        public string username;
        public string password;
        public string confirmPassword;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }

        public static Dictionary<string, string> signup = new Dictionary<string, string>();
    }
}

