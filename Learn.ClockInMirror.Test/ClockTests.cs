using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.ClockInMirror.Test
{
    [TestClass]
    public class ClockTests
    {
        [TestMethod]
        public void WhatIsTheTime_WhenHourOnRightAndHaveMinute_ReturnTimeInMirror()
        {
           // Arrange
           Clock clock = new Clock();
            
            // Assert
           Assert.AreEqual("06:35" , clock.WhatIsTheTime("05:25"));
        }


        [TestMethod]
        public void WhatIsTheTime_WhenHourOnRightAndHaveZeroMinute_ReturnTimeInMirror()
        {
            // Arrange
            Clock clock = new Clock();

            // Assert
            Assert.AreEqual("07:00", clock.WhatIsTheTime("05:00"));
        }

        [TestMethod]
        public void WhatIsTheTime_WhenHourOnLeftAndHaveMinute_ReturnTimeInMirror()
        {
            // Arrange
            Clock clock = new Clock();

            // Assert
            Assert.AreEqual("05:25", clock.WhatIsTheTime("07:35"));
            Assert.AreEqual("12:02", clock.WhatIsTheTime("11:58"));

            Assert.AreEqual("12:41", clock.WhatIsTheTime("11:19"));
            Assert.AreEqual("04:23", clock.WhatIsTheTime("07:37"));
        }

        [TestMethod]
        public void WhatIsTheTime_WhenHourOnLeftAndZeroMinute_ReturnTimeInMirror()
        {
            // Arrange
            Clock clock = new Clock();

            // Assert
            Assert.AreEqual("05:00", clock.WhatIsTheTime("07:00"));
            Assert.AreEqual("03:00", clock.WhatIsTheTime("09:00"));
        }


        [TestMethod]
        public void WhatIsTheTime_WhenTimeInMiddle_ReturnSelf()
        {
            // Arrange
            Clock clock = new Clock();

            // Assert
            Assert.AreEqual("06:00", clock.WhatIsTheTime("06:00"));
            Assert.AreEqual("12:00", clock.WhatIsTheTime("12:00"));
        }

        [TestMethod]
        public void WhatIsTheTime_WhenHourOnCenterAndHaveMinute_ReturnTimeInMirror()
        {
            // Arrange
            Clock clock = new Clock();

            // Assert
            Assert.AreEqual("05:25", clock.WhatIsTheTime("06:35"));
            Assert.AreEqual("11:58", clock.WhatIsTheTime("12:02"));
        }
    }
}
