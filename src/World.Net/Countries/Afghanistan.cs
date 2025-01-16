namespace World.Net.Countries
{
    public class Afghanistan : ICountry
    {
        public string Name { get; set; } = nameof(Afghanistan);
        public string OfficialName { get; set; } = "Islamic Republic of Afghanistan";
        public int NumericCode { get; set; } = 4;
        public string CountryCode { get; set; } = "AF";
        public string CallingCode { get; set; } = "+93";
    }
}
