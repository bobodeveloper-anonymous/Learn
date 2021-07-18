using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Test
{
    [TestClass]
    public class StockServiceTests
    {
       StockService _stockService;

        [TestInitialize]
        public void Setup()
        {
            _stockService = new StockService(0);
        }
        [TestMethod]
        public void Get_ReturnStock()
        {
            // Arrange
            StockService stockService = _stockService;

            // Act && Assert
            Assert.AreEqual(new Stock(0), stockService.Get());
        }

        [TestMethod]
        public void Receive_ReturnAddedStock()
        {
            // Arrange
            StockService stockService = _stockService;

            // Act
            stockService.Receive(1);

            // Assert
            Assert.AreEqual(new Stock(1), stockService.Get());
        }
    }
}
