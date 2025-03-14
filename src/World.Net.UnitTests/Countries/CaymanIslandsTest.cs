namespace World.Net.UnitTests.Countries
{
    public sealed class CaymanIslandsTest
    {
        private const string CAYMAN_ISLANDS_COUNTRY_NAME = "Cayman Islands";
        private const string CAYMAN_ISLANDS_NATIVE_NAME = "Cayman Islands";
        private const string CAYMAN_ISLANDS_CAPITAL = "George Town";
        private const string CAYMAN_ISLANDS_OFFICIAL_NAME = "Cayman Islands";
        private const string CAYMAN_ISLANDS_ISO2_CODE = "KY";
        private const string CAYMAN_ISLANDS_ISO3_CODE = "CYM";
        private const int CAYMAN_ISLANDS_NUMERIC_CODE = 136;
        private const string CAYMAN_ISLANDS_CALLING_CODE = "+1-345";
        private const int CAYMAN_ISLANDS_STATE_COUNT = 3;
        private static readonly string[] VALID_STATE_TYPES = { "District" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCaymanIslands()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.CaymanIslands;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.NotNull(country);
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CAYMAN_ISLANDS_COUNTRY_NAME, country.Name);
            Assert.Equal(CAYMAN_ISLANDS_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CAYMAN_ISLANDS_NATIVE_NAME, country.NativeName);
            Assert.Equal(CAYMAN_ISLANDS_CAPITAL, country.Capital);
            Assert.Equal(CAYMAN_ISLANDS_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CAYMAN_ISLANDS_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CAYMAN_ISLANDS_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CAYMAN_ISLANDS_CALLING_CODE, country.CallingCode);
            Assert.NotNull(country.States);
            Assert.Equal(CAYMAN_ISLANDS_STATE_COUNT, country.States.Count());
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
        }
    }
}
