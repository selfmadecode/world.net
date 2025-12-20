namespace World.Net.UnitTests.Countries
{
    public sealed class EstoniaTest : AssertCountryTestBase
    {
        private const string ESTONIA_NAME = "Estonia";
        private const int ESTONIA_STATE_COUNT = 15;
        private const string ESTONIA_OFFICIAL_NAME = "Republic of Estonia";
        private const string ESTONIA_NATIVE_NAME = "Eesti";
        private const string ESTONIA_CAPITAL = "Tallinn";
        private const int ESTONIA_NUMERIC_CODE = 233;
        private const string ESTONIA_ISO2_CODE = "EE";
        private const string ESTONIA_ISO3_CODE = "EST";
        private readonly string[] ESTONIA_CALLING_CODE = ["372"];
        private static CountryIdentifier ExpectedId => CountryIdentifier.Estonia;
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Harju", "37", "County"),
            new("Hiiu", "39", "County"),
            new("Ida-Viru", "44", "County"),
            new("Jõgeva", "49", "County"),
            new("Järva", "51", "County"),
            new("Lääne", "57", "County"),
            new("Lääne-Viru", "59", "County"),
            new("Põlva", "65", "County"),
            new("Pärnu", "67", "County"),
            new("Rapla", "70", "County"),
            new("Saare", "74", "County"),
            new("Tartu", "78", "County"),
            new("Valga", "82", "County"),
            new("Viljandi", "84", "County"),
            new("Võru", "86", "County")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEstonia()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert
            AssertCorrectInformation(
                country,
                ExpectedId,
                ESTONIA_NAME,
                ESTONIA_OFFICIAL_NAME,
                ESTONIA_NATIVE_NAME,
                ESTONIA_CAPITAL,
                ESTONIA_NUMERIC_CODE,
                ESTONIA_ISO2_CODE,
                ESTONIA_ISO3_CODE,
                ESTONIA_CALLING_CODE,
                ExpectedStates
            );
        }
    }
}
