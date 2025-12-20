namespace World.Net.UnitTests.Countries
{
    public sealed class EthiopiaTest : AssertCountryTestBase
    {
        private const string ETHIOPIA_NAME = "Ethiopia";
        private const string ETHIOPIA_OFFICIAL_NAME = "Federal Democratic Republic of Ethiopia";
        private const string ETHIOPIA_NATIVE_NAME = "ኢትዮጵያ";
        private const string ETHIOPIA_CAPITAL = "Addis Ababa";
        private const int ETHIOPIA_NUMERIC_CODE = 231;
        private const string ETHIOPIA_ISO2_CODE = "ET";
        private const string ETHIOPIA_ISO3_CODE = "ETH";
        private readonly string[] ETHIOPIA_CALLING_CODE = ["251"];
        private static CountryIdentifier ExpectedId => CountryIdentifier.Ethiopia;
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Addis Ababa", "AA", "Administration"),
            new("Afar", "AF", "Region"),
            new("Amhara", "AM", "Region"),
            new("Benishangul-Gumuz", "BE", "Region"),
            new("Dire Dawa", "DD", "Administration"),
            new("Gambela", "GA", "Region"),
            new("Harari", "HA", "Region"),
            new("Oromia", "OR", "Region"),
            new("Sidama", "SI", "Region"),
            new("Somali", "SO", "Region"),
            new("Southern Nations, Nationalities, and Peoples' Region", "SN", "Region"),
            new("Tigray", "TI", "Region")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEthiopia()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert
            AssertCorrectInformation(
                country,
                ExpectedId,
                ETHIOPIA_NAME,
                ETHIOPIA_OFFICIAL_NAME,
                ETHIOPIA_NATIVE_NAME,
                ETHIOPIA_CAPITAL,
                ETHIOPIA_NUMERIC_CODE,
                ETHIOPIA_ISO2_CODE,
                ETHIOPIA_ISO3_CODE,
                ETHIOPIA_CALLING_CODE,
                ExpectedStates
            );
        }
    }
}
