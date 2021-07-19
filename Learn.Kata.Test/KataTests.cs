using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Learn.Kata.Test
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void UniqueInOrder_ReturnUniqueInOrderIsPrimitive()
        {
            // Assert
            CollectionAssert.AreEquivalent("ABCDAB".ToList(), Kata.UniqueInOrder("AAAABBBCCDAABBB").ToList());

            CollectionAssert.AreEquivalent("".ToList(), Kata.UniqueInOrder("").ToList());

            CollectionAssert.AreEquivalent(new int[] { 1, 2, 3 }
            , Kata.UniqueInOrder( new int[] { 1, 2, 2, 3, 3 }).ToArray());
        }

        [TestMethod]
        public void UniqueInOrder_ReturnEmpty_WhenNullInput()
        {
            List<int> nullList = null;
            // Assert
            Assert.IsTrue(Kata.UniqueInOrder(nullList).Count() == 0);

        }

        [TestMethod]
        public void UniqueInOrder_ReturnUniqueInOrder_WhenInputIsObject()
        {
            List<Employee> employees = new List<Employee> { new Employee { Name = "name" } };
            // Assert
            Assert.IsTrue(Kata.UniqueInOrder(employees).Count() == 1);

        }

        public class Employee
        {
            public string Name { get; set; }
        }
    }
}
