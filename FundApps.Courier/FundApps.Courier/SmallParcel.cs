using System;
using System.Collections.Generic;
using System.Text;

namespace FundApps.Courier
{
    public class SmallParcel : Parcel
    {
        public SmallParcel(int height, int width, int length) : base(height, width, length)
        {
        }

        public override int Price => 3;
    }
}
