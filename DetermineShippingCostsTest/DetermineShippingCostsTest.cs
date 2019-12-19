using System;
using NUnit.Framework;
using DetermineShippingCosts;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace DetermineShippingCostsTest
{
    [TestFixture]
    public class DetermineShippingCostsTest
    {
        public ClassAssignmentAvans determineShippingCosts;
        public Array typeOfShippingCost;

        [SetUp]
        public void Setup()
        {
            determineShippingCosts = createClassAssignmentAvans();
            string[] typeOfShippingCost = {"Ground", "InStor", "NextDayAir", "SecondDayAir"};
        }

        [Test]
        public void ThereAreNoShippingCostsCalculated()
        {
            var result = determineShippingCosts.ShippingCosts(false, "Instore", 1300);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ThereAreNoShippingCostsWhenMinimumIsReached()
        {
            var result = determineShippingCosts.ShippingCosts(true, "Instore", 1800);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ThereAreNoShippingCostsWhenDefaultIsSelected()
        {
            var result = determineShippingCosts.ShippingCosts(true, "", 1400);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ThereAreShippingCostsWhenGroundIsSelected()
        {
            var result = determineShippingCosts.ShippingCosts(true, "Ground", 1400);
            Assert.AreEqual(result, 100);
        }

        [Test]
        public void ThereAreShippingCostsWhenInStoreIsSelected()
        {
            var result = determineShippingCosts.ShippingCosts(true, "InStore", 1400);
            Assert.AreEqual(result, 50);
        }
        [Test]
        public void ThereAreShippingCostsWhenSecondDayAirIsSelected()
        {
            var result = determineShippingCosts.ShippingCosts(true, "SecondDayAir", 1400);
            Assert.AreEqual(result, 125);
        }
        [Test]
        public void ThereAreShippingCostsWhenNextDayAirIsSelected()
        {
            var result = determineShippingCosts.ShippingCosts(true, "NextDayAir", 1400);
            Assert.AreEqual(result, 250);
        }
        public ClassAssignmentAvans createClassAssignmentAvans()
        {
            return new ClassAssignmentAvans();
        }
    }
}