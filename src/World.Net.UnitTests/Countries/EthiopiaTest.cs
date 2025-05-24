namespace World.Net.UnitTests.Countries
{
    public sealed class EthiopiaTest
    {
        private const string ETHIOPIA_NAME = "Ethiopia";
        private const int ETHIOPIA_STATE_COUNT = 12;
        private const string ETHIOPIA_OFFICIAL_NAME = "Federal Democratic Republic of Ethiopia";
        private const string ETHIOPIA_NATIVE_NAME = "ኢትዮጵያ";
        private const string ETHIOPIA_CAPITAL = "Addis Ababa";
        private const int ETHIOPIA_NUMERIC_CODE = 231;
        private const string ETHIOPIA_ISO2_CODE = "ET";
        private const string ETHIOPIA_ISO3_CODE = "ETH";
        private readonly string[] ETHIOPIA_CALLING_CODE = ["251"];
        private static readonly string[] VALID_STATE_TYPES = { "Region", "Administration" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEthiopia()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Ethiopia;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(ETHIOPIA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(ETHIOPIA_STATE_COUNT, country.States.Count());
            Assert.Equal(ETHIOPIA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(ETHIOPIA_NATIVE_NAME, country.NativeName);
            Assert.Equal(ETHIOPIA_CAPITAL, country.Capital);
            Assert.Equal(ETHIOPIA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(ETHIOPIA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(ETHIOPIA_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(ETHIOPIA_CALLING_CODE, country.CallingCode);
        }
    }
}
