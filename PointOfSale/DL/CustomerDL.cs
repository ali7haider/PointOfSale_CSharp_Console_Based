using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;

namespace PointOfSale.DL
{
    class CustomerDL
    {

        public static List<Customer> userBuy = new List<Customer>();
        public static List<Product> currentBuy = new List<Product>();
        static public Product isProductAvailable(string name)
        {
            foreach (Product P in ProductDL.productsList)
            {
                if (name == P.getPName())
                {
                    return P;
                }
            }
            return null;
        }
        public static Customer findCustomer(string userName)
        {
            foreach (Customer C in userBuy)
            {
                if (C.getName() == userName)
                {
                    return C;
                }
            }
            return null;
        }
        public static void addCustomerToList(Customer C)
        {
            if (!(userBuy.Contains(C)))
            {
                userBuy.Add(C);
            }

        }
    }
}
