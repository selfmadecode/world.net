namespace World.Net.UnitTests.Countries
{
    public class KosovoTest : AssertCountryTestBase
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kosovo;
        private const string ExpectedName = "Kosovo";
        private const string ExpectedOfficialName = "Republic of Kosovo";
        private const string ExpectedNativeName = "Republika e Kosovës";
        private const string ExpectedCapital = "Pristina";
        private const int ExpectedNumericCode = 383;
        private const string ExpectedISO2Code = "XK";
        private const string ExpectedISO3Code = "XKX";
        private static readonly string[] ExpectedCallingCode = ["+383"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Ferizaj", "XK-05", "District"),
            ("Gjakovë", "XK-06", "District"),
            ("Gjilan", "XK-07", "District"),
            ("Mitrovicë", "XK-03", "District"),
            ("Pejë", "XK-02", "District"),
            ("Prishtinë", "XK-01", "District"),
            ("Prizren", "XK-04", "District")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForKosovo()
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
