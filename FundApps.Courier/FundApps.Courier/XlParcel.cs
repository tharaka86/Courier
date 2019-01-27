using System;
using System.Collections.Generic;
using System.Text;

namespace FundApps.Courier
{
    public class XlParcel : Parcel
    {
        public XlParcel(int height, int width, int length) : base(height, width, length)
        {
        }

        public override int Price => 25;
    }
}
