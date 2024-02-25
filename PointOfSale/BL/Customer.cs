using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;

namespace PointOfSale.BL
{
    class Customer
    {

        private string name;
        private double inVoice;
        private List<Product> currentBuy = new List<Product>();
        public Customer(string name)
        {
            this.name = name;

        }
        public Customer()
        {

        }
        public double totalInVoice()
        {
            inVoice = 0;
            foreach (Product P in currentBuy)
            {
                inVoice = inVoice + ((P.calculateTax()*P.quantity) + (P.getPPrice()*P.quantity));
            }
            return inVoice;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setInvoice(double inVoice)
        {
            this.inVoice = inVoice;
        }
        public double getInvoice()
        {
            return inVoice;
        }
        public void setCurrentBuy(List<Product> currentBuy)
        {
            this.currentBuy = currentBuy;
        }
        public List<Product> getCurrentBuy()
        {
            return currentBuy;
        }
    }
}
