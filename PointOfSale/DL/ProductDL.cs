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
    class ProductDL
    {
        public static List<Product> productsList = new List<Product>();
        public static void addproductToList(Product P)
        {
            productsList.Add(P);
        }
        public static Product highestPrice()
        {
            int highest = 0;
            Product Pro = new Product();
            foreach (Product P in productsList)
            {
                if(P.getPPrice()>highest)
                {
                    highest = P.getPPrice();
                    Pro = P;

                }
            }
            return Pro;
        }
        public static void StoreInFile()
        {
            string path = "products.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var P in productsList)
            {
                file.WriteLine(P.getPName() + "," + P.getPCategory() + "," + P.getPPrice() + "," + P.getStockQuantity() + "," + P.getStockTreshold());
            }
            file.Flush();
            file.Close();
        }
        public static bool ReadFromFile()
        {
            string path = "products.txt";
            StreamReader file = new StreamReader(path);
            string record = "";
            if(File.Exists(path))
            {
                while((record=file.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string category = splittedRecord[1];
                    int price = int.Parse(splittedRecord[2]);
                    int quantity = int.Parse(splittedRecord[3]);
                    int threshold = int.Parse(splittedRecord[4]);
                    Product P = new Product(name, category, price, quantity, threshold);
                    addproductToList(P);
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
