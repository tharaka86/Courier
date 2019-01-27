using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundApps.Courier
{
    public class OrderProcessor
    {
        private readonly List<Parcel> _parcels;
        private readonly Order _order;
        private const int SpeedOrderFactor = 2;

        public OrderProcessor(Order order)
        {
            _order = order;
            _parcels = new List<Parcel>();
            _parcels.AddRange(order.ParcelSpecs.Select(ord => ord.GetParcelBySpec()));
        }

        /// <summary>
        /// if order is a speedy delivery, multiply the order total by speed order factor
        /// </summary>
        public int OrderTotal
        {
            get
            {
                return _parcels.Sum(p => p.ItemPrice) * (_order.IsSpeedyDelivery ? SpeedOrderFactor : 1);
            }
        }

    }
}
