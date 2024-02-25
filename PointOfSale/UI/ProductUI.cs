using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    class ProductUI
    {
       
        static public Product addProduct()
        {
            Console.Write("Enter Product Name : ");
            string pName = Console.ReadLine();
            Console.Write("Enter Product Category : ");
            string pCategory = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int pPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter Available Stock: ");
            int stockQuantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Threshold Stock : ");
            int stockThreshold = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added Successfully");
            MenuUI.clearScreen();
            Product P = new Product(pName, pCategory, pPrice, stockQuantity, stockThreshold);
            return P;
        }
        static public void viewAllProduct()
        {
            Console.WriteLine("Name\t\tCategory\t\tPrice\t\tStockQuantity\t\tStockThreshold");
            foreach (Product P in ProductDL.productsList)
            {
                Console.WriteLine(P.getPName() + "\t\t" + P.getPCategory() + "\t\t\t" + P.getPPrice() + "\t\t" + P.getStockQuantity() + "\t\t\t" + P.getStockTreshold());
            }
            MenuUI.clearScreen();
        }
        static public void highestUnitPriceProduct()
        {
            Product P = ProductDL.highestPrice();
            Console.WriteLine("Name\t\tCategory\t\tPrice\t\tStockQuantity\t\tStockThreshold");
            Console.WriteLine(P.getPName() + "\t\t" + P.getPCategory() + "\t\t\t" + P.getPPrice() + "\t\t" + P.getStockQuantity() + "\t\t\t" + P.getStockTreshold());
            MenuUI.clearScreen();
        }
        static public void showSalestaxProduct()
        {
            Console.WriteLine("Name\t\tCategory\t\tPrice\t\tStockQuantity\t\tStockThreshold\t\tTax");
            foreach (Product P in ProductDL.productsList)
            {
                Console.WriteLine(P.getPName() + "\t\t" + P.getPCategory() + "\t\t\t" + P.getPPrice() + "\t\t" + P.getStockQuantity() + "\t\t\t" + P.getStockTreshold() + "\t\t\t" + P.calculateTax());
            }
            MenuUI.clearScreen();
        }
        static public void showThresholdProduct()
        {
            Console.WriteLine("Name\t\tCategory\t\tPrice\t\tStockQuantity\t\tStockThreshold\t\tTax");
            foreach (Product P in ProductDL.productsList)
            {
                if (P.getStockQuantity() <= P.getStockTreshold())
                {
                    Console.WriteLine(P.getPName() + "\t\t" + P.getPCategory() + "\t\t\t" + P.getPPrice() + "\t\t" + P.getStockQuantity() + "\t\t\t" + P.getStockTreshold());
                }
                MenuUI.clearScreen();
            }
        }
    }
}
