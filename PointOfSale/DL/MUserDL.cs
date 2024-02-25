using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;
using PointOfSale.UI;

namespace PointOfSale.DL
{
    class MUserDL
    {
        public static List<MUser> usersList = new List<MUser>();
        static public void adduserstoList(MUser user)
        {
            usersList.Add(user);
        }
        public static void Storedata(MUser u, string path)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(u.getUserName() + "," + u.getPassword() + "," + u.getRole());
            file.Flush();
            file.Close();
        }
        public static void read_data(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string[] splittedRecord = record.Split(',');
                string name = splittedRecord[0];
                string password = splittedRecord[1];
                string role = splittedRecord[2];
                MUser u = new MUser(name, password, role);
                adduserstoList(u);
            }
            file.Close();

        }
    }
}
