namespace FundApps.Courier
{
    public class SmallParcel : Parcel
    {
        public SmallParcel(int height, int width, int length, int weight) : base(height, width, length, weight)
        {
        }

        public override int Price => 3;

        public override int WeightLimit => 1;
    }
}
