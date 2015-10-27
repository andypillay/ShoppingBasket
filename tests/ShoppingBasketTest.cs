using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAShoppingBasket;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    [TestClass]
    public class ShoppingBasketTest
    {
        [TestMethod]
        public void AddProductValid()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();

            // Act
            meal.AddProduct("Beans", 1.00M, 4);

            // Assert
            Assert.AreEqual("Beans", meal.OrderItems[0].ProductName);
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);
            Assert.AreEqual(4, meal.OrderItems[0].Quantity);
        }

        [TestMethod]
        public void AddProductNoQuantityValid()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();

            // Act
            meal.AddProduct("Beans", 1.00M);

            // Assert
            Assert.AreEqual("Beans", meal.OrderItems[0].ProductName);
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);
            Assert.AreEqual(1, meal.OrderItems[0].Quantity);
        }

        [TestMethod]
        public void RemoveProductValid()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.RemoveProduct("Beans", 2);

            // Assert
            Assert.AreEqual("Beans", meal.OrderItems[0].ProductName);
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);
            Assert.AreEqual(2, meal.OrderItems[0].Quantity);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void RemoveProductInvalidName()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.RemoveProduct("bananas", 2);

            // Assert
            Assert.AreEqual("Beans", meal.OrderItems[0].ProductName);
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);
            Assert.AreEqual(2, meal.OrderItems[0].Quantity);
        }

        [TestMethod]
        public void RemoveProductEqualsZero()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.RemoveProduct("Beans", 4);

            // Assert
            Assert.IsFalse(meal.OrderItems.Exists(x => x.ProductName == "Beans"));
        }

        [TestMethod]
        public void RemoveProduct()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.RemoveProduct("Beans");

            // Assert
            Assert.IsFalse(meal.OrderItems.Exists(x => x.ProductName == "Beans"));
        }

        [TestMethod]
        public void CurrentPriceWorking()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.CurrentPrice("Beans");

            // Assert
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void CurrentPriceCantFindProduct()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act
            meal.CurrentPrice("Pie");

            // Assert
            Assert.AreEqual(1.00M, meal.OrderItems[0].LatestPrice);

        }

        [TestMethod]
        public void IsProductInBasketValid()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act

            // Assert
            Assert.IsTrue(meal.IsProductInBasket("Beans"));
        }

        [TestMethod]
        public void IsProductInBasketInvalid()
        {
            // Arrange  
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);

            // Act

            // Assert
            Assert.IsFalse(meal.IsProductInBasket("Pie"));
        }

        [TestMethod]
        public void CreatedFile()
        {
            // Arrange 
            string inputFile = @"C:\Development\InputData.txt";
            ShoppingBasket meal = new ShoppingBasket();
            meal.AddProduct("Beans", 1.00M, 4);



            // Act
            meal.SaveBasket(inputFile);
            

            // Assert
            Assert.IsTrue(File.Exists(@"C:\Development\InputData.txt"));
        }

    }

}
