namespace FundApps.Courier
{
    public class LargeParcel : Parcel
    {
        public LargeParcel(int height, int width, int length, int weight) : base(height, width, length, weight)
        {
        }

        public override int Price => 15;

        public override int WeightLimit => 6;
    }
}
