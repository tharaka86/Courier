using System.Collections.Generic;
using Xunit;

namespace FundApps.Courier.Tests
{
    public class OrderProcessorTest
    {

        [Fact]
        public void OrderProcessor_Should_Calculate_CorrectCost_For_Multiple_Parcels()
        {
            var smalSpec = new ParcelSpec(8, 8, 8, 1);
            var smallSpecExpectedCost = 3;

            var mediumSpec = new ParcelSpec(25, 20, 10, 3);
            var mediumSpecExpectedCost = 8;

            var specs = new List<ParcelSpec> { smalSpec, mediumSpec };
            var order = new Order(specs, false);
            var processor = new OrderProcessor(order);
            Assert.Equal(smallSpecExpectedCost+ mediumSpecExpectedCost, processor.OrderTotal);
        }

        [Fact]
        public void Speedy_Order_Should_DoubleTheCost()
        {
            var specs = new List<ParcelSpec>
            {
                new ParcelSpec(8,8,8,1)
            };
            var standardCostExpected = 3;

            var order = new Order(specs, true);

            var processor = new OrderProcessor(order);
            Assert.Equal(standardCostExpected * 2, processor.OrderTotal);
        }

        [Fact]
        public void Extra_Weight_Should_IncreseTheOrderTotal()
        {
            var extraWeight = 3;
            var extraWeightPanelty = 2;
            var specs = new List<ParcelSpec>
            {
                new ParcelSpec(8,8,8,1+extraWeight)
            };
            var standardCostExpected = 3;

            var order = new Order(specs, false);

            var processor = new OrderProcessor(order);
            Assert.Equal(standardCostExpected + (extraWeight * extraWeightPanelty), processor.OrderTotal);
        }
    }
}
