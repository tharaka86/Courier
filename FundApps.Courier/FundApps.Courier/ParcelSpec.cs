using System.Collections.Generic;
using System.Linq;

namespace FundApps.Courier
{
    public class ParcelSpec
    {
        public ParcelSpec(int height, int width, int length, int weight)
        {
            Height = height;
            Width = weight;
            Length = length;
            Weight = weight;
        }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }

        /// <summary>
        /// get the max value out of height, width and length
        /// </summary>
        public int Max { get { return (new List<int> { Height, Width, Length }).Max(); } }
    }
}
