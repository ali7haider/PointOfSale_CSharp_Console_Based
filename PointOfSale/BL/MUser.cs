using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.DL;

namespace PointOfSale.BL
{
    class MUser
    {
        private string userName;
        private string password;
        private string userRole;
       
        public MUser(string userName, string password, string userRole)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = userRole;
        }
        public MUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = "NA";
        }
        static public MUser checkuser(MUser user)
        {
            foreach (MUser storedUser in MUserDL.usersList)
            {
                if (storedUser.userName == user.userName && storedUser.password == user.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
        static public bool isAdmin(MUser user)
        {
            if (user.userRole == "Admin" || user.userRole == "admin")
            {
                return true;
            }
            return false;
        }
        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        public string getUserName()
        {
            return userName; ;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password; 
        }
        public void setRole(string userRole)
        {
            this.userRole=userRole;
        }
        public string getRole()
        {
            return userRole; 
        }

    }
}
