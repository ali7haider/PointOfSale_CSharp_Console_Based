using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");
            Console.WriteLine("                 Point Of Sale                          ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");

        }
        public static string menu()
        {
            Console.Clear();
            header();
            Console.WriteLine("[1]- Sign In");
            Console.WriteLine("[2]- Sign Up");
            Console.WriteLine("[3]- Exit");
            Console.Write("Your Option.....");
            string op = Console.ReadLine();
            return op;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey();
            Console.Clear();
        }
        static public string adminMenu()
        {
            Console.Clear();
            MenuUI.header();
            Console.WriteLine("[1]-Add Product");
            Console.WriteLine("[2]-View All Products");
            Console.WriteLine("[3]-Find Product with highest Unit Price");
            Console.WriteLine("[4]-View Sales Tax of All Products");
            Console.WriteLine("[5]-Product to Be Ordered");
            Console.WriteLine("[6]-Exit");
            Console.Write("Your Option......");
            string op = Console.ReadLine();
            return op;
        }
        static public string customerMenu()
        {
            Console.Clear();
            MenuUI.header();
            Console.WriteLine("[1]-View All the Products");
            Console.WriteLine("[2]-Buy the Product");
            Console.WriteLine("[3]-Generate Invoice");
            Console.WriteLine("[4]-Exit");
            Console.Write("Your Option......");
            string op = Console.ReadLine();
            return op;
        }
    }
}
