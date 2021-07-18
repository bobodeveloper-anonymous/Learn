using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.Test
{
    [TestClass]
    public class AddServiceTests
    {
        [TestMethod]
        public void Add_Return_AddedResult()
        {
            // Arrange
            AddService addService = new AddService();
            Stock stock1 = new Stock(1);
            Stock stock2 = new Stock(2);

            // Act
            Stock result = addService.Add(stock1, stock2);

            // Assert
            Assert.AreEqual(3, result.OnHand);
        }
    }
}
