using System;
using Xunit;

namespace FundApps.Courier.Tests
{
    public class ParcelSpecTest
    {
        [Theory]
        [InlineData(8, 8, 8, 1, 3)]
        [InlineData(25, 25, 10, 3, 8)]
        [InlineData(60, 55, 10, 6, 15)]
        [InlineData(110, 75, 25, 10, 25)]
        public void ParcelSpecWithAppropriateWeight_Should_Provide_ParcelWithCorrectPrice(int height, int width, int length, int weight, int expectedPrice)
        {
            var spec = new ParcelSpec(height, width, length, weight);

            var parcel = spec.GetParcelBySpec();

            Assert.True(parcel.Price.Equals(expectedPrice));
        }

    }
}
