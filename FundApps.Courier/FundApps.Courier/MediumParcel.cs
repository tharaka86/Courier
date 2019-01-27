using System;
using System.Collections.Generic;
using System.Text;

namespace FundApps.Courier
{
    public class MediumParcel : Parcel
    {
        public MediumParcel(int height, int width, int length) : base(height, width, length)
        {
        }

        public override int Price => 8;
    }
}
