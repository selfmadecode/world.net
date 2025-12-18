namespace World.Net.UnitTests.Countries
{
    public class KyrgyzstanTest : AssertCountryTestBase
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kyrgyzstan;
        private const string ExpectedName = "Kyrgyzstan";
        private const string ExpectedOfficialName = "Kyrgyz Republic";
        private const string ExpectedNativeName = "Киргизская Республика";
        private const string ExpectedCapital = "Bishkek";
        private const int ExpectedNumericCode = 417;
        private const string ExpectedISO2Code = "KG";
        private const string ExpectedISO3Code = "KGZ";
        private static readonly string[] ExpectedCallingCode = ["+996"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Batken", "KG-B", "Region"),
            ("Chuy", "KG-C", "Region"),
            ("Jalal-Abad", "KG-J", "Region"),
            ("Naryn", "KG-N", "Region"),
            ("Osh", "KG-O", "Region"),
            ("Talas", "KG-T", "Region"),
            ("Issyk-Kul", "KG-Y", "Region"),
            ("Bishkek", "KG-GB", "City"),
            ("Osh City", "KG-GO", "City")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForKyrgyzstan()
        {
            var country = CountryProvider.GetCountry(ExpectedId);

            AssertCorrectInformation(
                country,
                ExpectedId,
                ExpectedName,
                ExpectedOfficialName,
                ExpectedNativeName,
                ExpectedCapital,
                ExpectedNumericCode,
                ExpectedISO2Code,
                ExpectedISO3Code,
                ExpectedCallingCode,
                ExpectedStates
            );
        }
    }
}
