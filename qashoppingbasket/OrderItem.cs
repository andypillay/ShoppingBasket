using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAShoppingBasket
{
    public class OrderItem
    {

        private string productName;

        public string ProductName
        {
            get { return productName; }
            private set 
            {
                if (productName == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Product Name is Empty");
                }
                productName = value; 
            }
        }



        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            private set
            {
                if (Quantity < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity is Negative or Zero");
                }
                quantity = value;
            }
        }

        private decimal latestPrice;

        public decimal LatestPrice
        {
            get { return latestPrice; }
            private set
            {
                if (LatestPrice < 0)
                {
                    throw new ArgumentOutOfRangeException("Price is Negative");
                }
                latestPrice = value;
            }
        }

        public decimal TotalOrder { get { return LatestPrice * Quantity; } }

        public OrderItem(string pName, decimal lPrice):this (pName, lPrice, 1)
        {

        }

        public OrderItem(string pName, decimal lPrice,int quant)
        {
            if (lPrice < 0 || quant <= 0 || pName == string.Empty)
            {
                throw new ArgumentOutOfRangeException("Invalid");
            }
            ProductName = pName;
            LatestPrice = lPrice;
            Quantity = quant;
        }

        public int AddItems(decimal lPrice, int quant)
        {
            LatestPrice = lPrice;
            return AddItems(quant);
        }

        public int AddItems(int quant)
        {
            if (quant <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid");
            }
            Quantity += quant;
            return Quantity;
        }

        public int AddItem()
        {
            Quantity ++;
            return Quantity;
        }

        public int ChangeItems(string pName,decimal lPrice, int quant)
        {
            ProductName = pName;
            LatestPrice = lPrice;
            return ChangeItems(quant);
        }

        public int ChangeItems(int quant)
        {
            return Quantity = quant;
        }
        

        public int RemoveItems(int quant)
        {
            if (quant <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid");
            }
            Quantity -= quant;
            if (Quantity < 0)
            {
                quantity = 0;
            }
            return Quantity;
        }

        public int RemoveItem()
        {
            return RemoveItems(1);
        }

        public override string ToString()
        {
            string productName = ProductName.PadRight(15);
            string latestPrice = String.Format("{0:C}",LatestPrice).PadRight(5);
            string quantity = String.Format("{0}", Quantity).PadRight(5);
            string total = String.Format("{0:C}", TotalOrder).PadLeft(15);
            return string.Format("{0}\t{1}\t{2}\t{3}",productName,latestPrice,quantity,total);
        }

    }
}
