using System;

namespace FundApps.Courier
{
    public abstract class Parcel
    {
        private const int ExtraWeightPanelty = 2;
        public Parcel(int height, int width, int length, int weight)
        {
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
        }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }
        public  abstract int Price { get; }
        public abstract int WeightLimit { get; }

       //some comment
        private int CalculateExtraWeight()
        {
            return Weight > WeightLimit ? Weight - WeightLimit : 0;
        }

        /// <summary>
        /// standard parcel price + extra weight charge
        /// </summary>
        public int ItemPrice { get { return Price + (CalculateExtraWeight() * ExtraWeightPanelty); } }
    }
}
