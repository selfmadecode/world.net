namespace World.Net.UnitTests.Countries
{
    public class LebanonTest : AssertCountryTestBase
    {
        private CountryIdentifier Id => CountryIdentifier.Lebanon;
        private string Name { get; } = "Lebanon";
        private string OfficialName { get; } = "Lebanese Republic";
        private string NativeName { get; } = "الجمهورية اللبنانية";
        private string Capital { get; } = "Beirut";
        private int NumericCode { get; } = 422;
        private string ISO2Code { get; } = "LB";
        private string ISO3Code { get; } = "LBN";
        private string[] CallingCode { get; } = ["+961"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Akkar", "LB-AK", "Governorate"),
            new("Baalbek-Hermel", "LB-BH", "Governorate"),
            new("Beirut", "LB-BA", "Governorate"),
            new("Beqaa", "LB-BI", "Governorate"),
            new("Mount Lebanon", "LB-JL", "Governorate"),
            new("Nabatieh", "LB-NA", "Governorate"),
            new("North Lebanon", "LB-AS", "Governorate"),
            new("South Lebanon", "LB-JA", "Governorate")
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
