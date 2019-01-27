using System.Collections.Generic;

namespace FundApps.Courier
{
    public class Order
    {
        public List<ParcelSpec> ParcelSpecs { get; private set; }
        public bool IsSpeedyDelivery { get; private set; }

        public Order(List<ParcelSpec> specs, bool isSpeedyDelivery)
        {
            ParcelSpecs = specs;
            IsSpeedyDelivery = isSpeedyDelivery;
        }
    }
}
