namespace FundApps.Courier
{
    public class XlParcel : Parcel
    {
        public XlParcel(int height, int width, int length, int weight) : base(height, width, length, weight)
        {
        }

        public override int Price => 25;

        public override int WeightLimit => 10;
    }
}
