using System;

namespace FundApps.Courier
{
    public abstract class Parcel
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public  abstract int Price { get; }

        public Parcel(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
    }
}
