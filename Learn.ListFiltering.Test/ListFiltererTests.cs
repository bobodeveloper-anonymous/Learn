using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Learn.ListFiltering.Test
{
    [TestClass]
    public class ListFiltererTests
    {
        [TestMethod]
        public void GetIntegersFromList_ReturnIntegerList_WhenCall()
        {

            // Assert
            CollectionAssert.AreEqual(new List<int>() { 1 }, 
                                ListFilterer.GetIntegersFromList(new List<object>() { 1 }).ToList());

            CollectionAssert.AreEqual(new List<int>() { 2 },
                                ListFilterer.GetIntegersFromList(new List<object>() { 2 }).ToList());


            CollectionAssert.AreEquivalent(new List<int>() { 1 , 2 },
                                ListFilterer.GetIntegersFromList(new List<object>() { 2, 1 }).ToList());


            CollectionAssert.AreEquivalent(new List<int>() { 1, 2 },
                                ListFilterer.GetIntegersFromList(new List<object>() { 2, 1, "s" }).ToList());
        }

    }
}
