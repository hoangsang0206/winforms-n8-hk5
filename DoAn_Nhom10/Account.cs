using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Nhom10
{
    class Account
    {
        private string username = "admin";
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password = "123456";
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Account()
        {
        }
    }
}
