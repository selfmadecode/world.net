namespace World.Net.UnitTests.Countries
{
    public sealed class BulgariaTest
    {
        private const string BULGARIA_NAME = "Bulgaria";
        private const int BULGARIA_STATE_COUNT = 28;
        private const string BULGARIA_OFFICIAL_NAME = "Republic of Bulgaria";
        private const string BULGARIA_NATIVE_NAME = "България";
        private const string BULGARIA_CAPITAL = "Sofia";
        private const int BULGARIA_NUMERIC_CODE = 100;
        private const string BULGARIA_ISO2_CODE = "BG";
        private const string BULGARIA_ISO3_CODE = "BGR";
        private const string BULGARIA_CALLING_CODE = "+359";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_for_Bulgaria()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Bulgaria;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(BULGARIA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(BULGARIA_STATE_COUNT, country.States.Count());
            Assert.Equal(BULGARIA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(BULGARIA_NATIVE_NAME, country.NativeName);
            Assert.Equal(BULGARIA_CAPITAL, country.Capital);
            Assert.Equal(BULGARIA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(BULGARIA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(BULGARIA_ISO3_CODE, country.ISO3Code);
            Assert.Equal(BULGARIA_CALLING_CODE, country.CallingCode);
        }
    }
}
