namespace World.Net.UnitTests.Countries
{
    public class LesothoTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Lesotho;
        public string Name { get; } = "Lesotho";
        public string OfficialName { get; } = "Kingdom of Lesotho";
        public string NativeName { get; } = "Muso oa Lesotho";
        public string Capital { get; } = "Maseru";
        public int NumericCode { get; } = 426;
        public string ISO2Code { get; } = "LS";
        public string ISO3Code { get; } = "LSO";
        public string[] CallingCode { get; } = ["+266"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Berea", "LS-D", "District"),
            new("Butha-Buthe", "LS-B", "District"),
            new("Leribe", "LS-C", "District"),
            new("Mafeteng", "LS-E", "District"),
            new("Maseru", "LS-A", "District"),
            new("Mohale's Hoek", "LS-F", "District"),
            new("Mokhotlong", "LS-J", "District"),
            new("Qacha's Nek", "LS-H", "District"),
            new("Quthing", "LS-G", "District"),
            new("Thaba-Tseka", "LS-K", "District")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLebanon()
        {
            var country = CountryProvider.GetCountry(Id);

            AssertCorrectInformation(
                country,
                Id,
                Name,
                OfficialName,
                NativeName,
                Capital,
                NumericCode,
                ISO2Code,
                ISO3Code,
                CallingCode,
                States
            );
        }
    }
}
