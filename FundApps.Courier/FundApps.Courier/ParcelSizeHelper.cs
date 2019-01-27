namespace FundApps.Courier
{
    public static class ParcelSizeHelper
    {
        public static Parcel GetParcelBySpec(this ParcelSpec spec)
        {
            if (spec.Max < 10)
                return new SmallParcel(spec.Height, spec.Width, spec.Length, spec.Width);
            else if (spec.Max < 50)
                return new MediumParcel(spec.Height, spec.Width, spec.Length, spec.Width);
            else if (spec.Max < 100)
                return new LargeParcel(spec.Height, spec.Width, spec.Length, spec.Width);
            else
                return new XlParcel(spec.Height, spec.Width, spec.Length, spec.Width);
        }
    }

}
