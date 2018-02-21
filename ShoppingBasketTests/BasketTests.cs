using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingBasket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Tests
{
    [TestClass()]
    public class BasketTests
    {
        [TestMethod()]
        public void GreetingTest()
        {
            using (var sw = new StringWriter())
            {
                // Arrange
                Basket basket = new Basket("na");
                Console.SetOut(sw);

                // Act
                basket.Greeting();
                var output = sw.ToString();

                // Assert
                Assert.AreEqual("Hello, na" + Environment.NewLine, output);
            }

        }
    }
}