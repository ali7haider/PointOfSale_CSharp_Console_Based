using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class Product
    {
        private string pName;
        private string pCategory;
        private int pPrice;
        private int stockQuantity;
        private int stockThreshold;
        public double tBill;
        public int quantity;
        public Product(string pName,string pCategory,int pPrice,int stockQuantity,int stockThreshold)
        {
            this.pName = pName;
            this.pCategory = pCategory;
            this.pPrice = pPrice;
            this.stockQuantity = stockQuantity;
            this.stockThreshold = stockThreshold;
        }
        public Product(string pName,string pCategory,int pPrice,int stockQuantity)
        {
            this.pName = pName;
            this.pCategory = pCategory;
            this.pPrice = pPrice;
            this.stockQuantity = stockQuantity;
        }
        public Product(string pName, string pCategory, int pPrice, int quantity,double bill)
        {
            this.pName = pName;
            this.pCategory = pCategory;
            this.pPrice = pPrice;
            this.tBill = bill;
            this.quantity = quantity;
        }
        public Product()
        {

        }
        public float calculateTax()
        {
            float tax;
            if(pCategory=="Grocery")
            {
                tax = pPrice * 0.1F;
            }
            else if (pCategory == "Fruit")
            {
                tax = pPrice * 0.05F;
            }
            else
            {
                tax = pPrice * 0.15F;
            }
            return tax;
        }
        public void setPName(string pName)
        {
            this.pName = pName;
        }
        public string getPName()
        {
            return pName;
        }
        public void setPCategory(string pCategory)
        {
            this.pCategory = pCategory;
        }
        public string getPCategory()
        {
            return pCategory;
        }
        public void setPPrice(int pPrice)
        {
            this.pPrice = pPrice;
        }
        public int getPPrice()
        {
            return pPrice ;
        }
        public void setStockQuantity(int stockQuantity)
        {
            this.stockQuantity=stockQuantity;
        }
        public int getStockQuantity()
        {
            return stockQuantity;
        }
        public void setStockThreshold(int stockThreshold)
        {
            this.stockThreshold = stockThreshold;
        }
        public int getStockTreshold()
        {
            return stockThreshold;
        }
    }
}
