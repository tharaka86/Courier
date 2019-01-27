namespace FundApps.Courier
{
    public class MediumParcel : Parcel
    {
        public MediumParcel(int height, int width, int length, int weight) : base(height, width, length, weight)
        {
        }

        public override int Price => 8;

        public override int WeightLimit => 3;
    }
}
