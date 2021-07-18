using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Test
{
    [TestClass]
    public class RequestServiceTests
    {
        [TestMethod]
        public void Get_ReturnRequest()
        {
            // Arrange
            RequestService requestService = new RequestService();

            // Act && Assert
            Assert.AreEqual(new Request() { Id = 1, Status = "Request" } ,requestService.Get(1));
        }

        
    }
}
