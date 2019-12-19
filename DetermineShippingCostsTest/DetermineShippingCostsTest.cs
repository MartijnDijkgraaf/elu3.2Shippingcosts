using NUnit.Framework;
using DetermineShippingCosts;

namespace DetermineShippingCostsTest
{
    [TestFixture] 
    public class DetermineShippingCostsTest
    {
        [Test]
        public void TestThereAreNoShippingCosts()
        {
            var determineShippingCosts = createClassAssignmentAvans();
            var result = determineShippingCosts.ShippingCosts(false, "Instore", 1300);
            Assert.AreEqual(result, 0);
        }
        
        public ClassAssignmentAvans createClassAssignmentAvans()
        {
            return new ClassAssignmentAvans();
        }
    }
}