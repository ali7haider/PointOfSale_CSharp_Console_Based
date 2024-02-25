using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;


namespace PointOfSale.UI
{
    class MUserUI
    {
        public static MUser takeinputforsignin()
        {
            Console.Clear();
            MenuUI.header();
            Console.Write("Enter UserName : ");
            string name = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            MUser user = new MUser(name, password);
            return user;
        }
        public static MUser takeinputforsignup()
        {
            Console.Clear();
            MenuUI.header();
            Console.Write("Enter UserName : ");
            string name = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.Write("Enter Role : ");
            string role = Console.ReadLine();
            MUser user = new MUser(name, password, role);
            Console.WriteLine("User Succesfully Added");
            MenuUI.clearScreen();
            return user;
        }
    }
}
