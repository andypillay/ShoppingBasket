using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace QAShoppingBasket
{
    public class ShoppingBasket
    {
        public List<OrderItem> OrderItems { get; private set; }

        public int NumberOfProduct { get { return OrderItems.Count;} }

        public decimal BasketTotal {get 
            {
                decimal total = 0;
                for (int i = 0; i < OrderItems.Count; i++)
			    {
			        total += OrderItems[i].TotalOrder;
			    }
                return total;
            }}

        public int NumberOfItems {get 
            {
                int total = 0;
                for (int i = 0; i < OrderItems.Count; i++)
			    {
			        total += OrderItems[i].Quantity;
			    }
                return total;
            }}

        public ShoppingBasket()
        {
            OrderItems = new List<OrderItem>();
        }

        public bool AddProduct(string productName, decimal latestProductValue)
        {
            return AddProduct(productName,latestProductValue,1);
            
        }

        public bool AddProduct(string productName, decimal latestProductValue, int quantOfProducts)
        {
            if (!string.IsNullOrEmpty(productName) && quantOfProducts > 0)
            {
                OrderItem oi = OrderItems.Find(x => x.ProductName == productName);
                if (oi == null)
                {
                    OrderItem item = new OrderItem(productName, latestProductValue, quantOfProducts);
                    OrderItems.Add(item);
                    return true;
                }
                else
                {  
                    oi.AddItems(latestProductValue, quantOfProducts);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public void RemoveProduct(string productName, int quantOfProducts)
        {
            OrderItem item = OrderItems.Find(x => x.ProductName == productName);
            if (item != null)
            {
                item.RemoveItems(quantOfProducts);
                if (item.Quantity <= 0)
                {
                    OrderItems.Remove(item);
                }
            }
            else throw new KeyNotFoundException("Product Name Not Found");
        }

        public void RemoveProduct(string productName)
        {
            RemoveProduct(productName, OrderItems[FindIndex(productName)].Quantity);
        }

        //Returns current price of item.
        public decimal CurrentPrice(string productName)
        {
            return OrderItems[FindIndex(productName)].LatestPrice;
        }

        //Checks if Item is in basket
        public bool IsProductInBasket(string productName)
        {
            bool inBasket = false;
            OrderItem item = OrderItems.Find(x => x.ProductName == productName);
            if (item != null)
            {
                inBasket = true;
            }
            return inBasket;
        }

        public bool SaveBasket(string inputFile)
        {
            bool successful = false;
            try
            {
                StreamWriter SaveFile = new StreamWriter(inputFile);
                SaveFile.WriteLine("~~~~~~~~~~~~~~~~~~~Reciept~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                SaveFile.WriteLine("[Item Name]\t[Price]\t[Quantity]\t[Item Total]");
                foreach (OrderItem item in OrderItems)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                    SaveFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    SaveFile.WriteLine("\t\t\t\t\t[Basket Total]");
                    SaveFile.WriteLine("\t\t\t\t\t   {0:C}",BasketTotal);
                    SaveFile.Close();
                    successful = true;
                
            }
            catch (FileNotFoundException)
            {
                successful = false;
                throw new FileNotFoundException("File Not Found");
            }
            return successful;
        }

        public int FindIndex(string productName)
        {
            int index = OrderItems.FindIndex(x => x.ProductName == productName);
            if (index <= -1)
            {
                throw new KeyNotFoundException("Product Name Not Found");
            }
            return index;
        }


        public void EditProduct(string oldProductName,string editedProductName,decimal editedPrice, int editedQuantity, OrderItem newItem)
        {
            OrderItem oi = OrderItems.Find(x => x.ProductName == oldProductName);
                if (oi != null) 
                {
                    if (oldProductName == editedProductName)
                    {
                        oi.ChangeItems(editedProductName, editedPrice, editedQuantity);
                        OrderItems.Insert(FindIndex(oldProductName), oi);
                        OrderItems.RemoveAt(FindIndex(oldProductName));    
                    }
                    else if (IsProductInBasket(editedProductName))
                        {
                            RemoveProduct(oldProductName,oi.Quantity);
                            RemoveProduct(editedProductName);
                            AddProduct(editedProductName, editedPrice, editedQuantity);
                        } 
                    else 
                    {
                        System.Windows.Forms.MessageBox.Show("Edited item does not exist in list. First please add to list"); 
                    }  
                }
        }

        public void ClearAll()
        {
            OrderItems.Clear();
        }

        public bool EmptyBasket()
        {
            bool isEmpty = !OrderItems.Any();

            return isEmpty;
        }
    }
}
