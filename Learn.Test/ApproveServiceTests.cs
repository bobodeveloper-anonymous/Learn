using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Test
{
    [TestClass]
    public class ApproveServiceTests
    {
        ApproveService _approveService;
        Mock<IStockService> _stockServiceMock;
        
        [TestInitialize]
        public void SetUp()
        {
            _stockServiceMock = new Mock<IStockService>();
            _approveService = new ApproveService(_stockServiceMock.Object);
        }
        [TestMethod]
        public void Approve_UpdateRequestStatus()
        {
            // Arrange
            
            // Act
            Request request = _approveService.Approve(RequestId(1));

            // Assert
            Assert.AreEqual("Approve", request.Status);
        }

        [TestMethod]
        public void Approve_RemoveFromStock()
        {
            // Arrange


            // Act
            Request request = _approveService.Approve(RequestId(1));

            // Assert
            _stockServiceMock.Verify(x => x.Remove(1), Times.Once);
        }

        private int RequestId(int requestId)
        {
            return requestId;
        }

    }
}
