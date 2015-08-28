using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAShoppingBasket;

namespace Tests
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void OrderItemValid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;

            // Act
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Assert
            Assert.AreEqual("Beans", beans.ProductName);
            Assert.AreEqual(1.00M, beans.LatestPrice);
            Assert.AreEqual(4, beans.Quantity);
           
        }

        [TestMethod]
        [ExpectedException (typeof (ArgumentOutOfRangeException))]
        public void OrderItemInvalid()
        {
            // Arrange  
            string pName = "";
            decimal lPrice = 1.00M;
            int quant = 4;

            // Act
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Assert
        }

        [TestMethod]
        public void AddItemsQuantityAndPriceAdded()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);
            

            // Act
            beans.AddItems(1.00M, 2);
            
            // Assert
            Assert.AreEqual("Beans", beans.ProductName);
            Assert.AreEqual(1.00M, beans.LatestPrice);
            Assert.AreEqual(6, beans.Quantity);
            beans.AddItems(1.00M, 2);
            Assert.AreEqual(8, beans.Quantity);

        }

        [TestMethod]
        public void AddItemsQuantityAdded()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.AddItems(4);

            // Assert
            Assert.AreEqual("Beans", beans.ProductName);
            Assert.AreEqual(1.00M, beans.LatestPrice);
            Assert.AreEqual(8, beans.Quantity);
        }

        [TestMethod]
        public void AddItemQuantityAddedBlank()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.AddItem();

            // Assert

            Assert.AreEqual(5, beans.Quantity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddItemQuantityAddedInvalid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.AddItems(1.00M, -1);

            // Assert
        }

        [TestMethod]
        public void RemoveItemsQuantityValid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.RemoveItems(4);

            // Assert
            Assert.AreEqual(0, beans.Quantity);
        }

        [TestMethod]
        public void RemoveItemsQuantityInvalid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.RemoveItems(5);

            // Assert
            Assert.AreEqual(0, beans.Quantity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveItemsQuantityNegativeInvalid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 4;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.RemoveItems(-1);

            // Assert
        }

        [TestMethod]
        public void RemoveItemQuantityValid()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 2;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.RemoveItem();

            // Assert
            Assert.AreEqual(1, beans.Quantity);
        }

        [TestMethod]
        public void RemoveItemQuantityToZero()
        {
            // Arrange  
            string pName = "Beans";
            decimal lPrice = 1.00M;
            int quant = 1;
            OrderItem beans = new OrderItem(pName, lPrice, quant);

            // Act
            beans.RemoveItem();

            // Assert
            Assert.AreEqual(0, beans.Quantity);
        }



    }
}
