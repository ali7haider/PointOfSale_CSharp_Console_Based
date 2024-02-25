using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    class CustomerUI
    {

        static public void buyProduct()
        {
            Console.Write("Enter Product Name : ");
            string pname = Console.ReadLine();
            Product P = CustomerDL.isProductAvailable(pname);
            if (P != null)
            {
                Console.Write("Enter Product Quantity : ");
                int quantity = int.Parse(Console.ReadLine());
                if (quantity <= P.getStockQuantity())
                {
                    double bill = P.getPPrice() * quantity;
                    P.setStockQuantity(P.getStockQuantity() - quantity);
                    Product P3 = new Product(P.getPName(), P.getPCategory(), P.getPPrice(), quantity, bill);
                    CustomerDL.currentBuy.Add(P3);
                    Console.WriteLine("Products Purchased Successfully");
                }
                else
                {
                    Console.WriteLine("Only " + P.getStockQuantity() + " Products are availble ");
                }


            }
            else
            {
                Console.WriteLine("Stock is not Available");
            }
            MenuUI.clearScreen();
        }
        public static void printInVoice(Customer userName)
        {
            /*Customer C = CustomerDL.findCustomer(userName);
            if (C != null)
            {
                Console.WriteLine(C.getName() + "\t\t" + C.totalInVoice());
                MenuUI.clearScreen();
            }
            MenuUI.clearScreen();
            
*/
            /*Customer C = CustomerDL.findCustomer(userName);*/
            Customer Cus = new Customer();
            double total = Cus.totalInVoice();
            Console.WriteLine(userName.getName() + "\t\t" + userName.getInvoice());
            MenuUI.clearScreen();
        }
    }
}
