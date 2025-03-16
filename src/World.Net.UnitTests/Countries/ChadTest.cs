namespace World.Net.UnitTests.Countries
{
    public sealed class ChadTest
    {
        private const string CHAD_NAME = "Chad";
        private const int CHAD_STATE_COUNT = 23;
        private const string CHAD_OFFICIAL_NAME = "Republic of Chad";
        private const string CHAD_NATIVE_NAME = "Tchad";
        private const string CHAD_CAPITAL = "N'Djamena";
        private const int CHAD_NUMERIC_CODE = 148;
        private const string CHAD_ISO2_CODE = "TD";
        private const string CHAD_ISO3_CODE = "TCD";
        private const string CHAD_CALLING_CODE = "+235";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForChad()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Chad;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CHAD_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(CHAD_STATE_COUNT, country.States.Count());
            Assert.Equal(CHAD_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CHAD_NATIVE_NAME, country.NativeName);
            Assert.Equal(CHAD_CAPITAL, country.Capital);
            Assert.Equal(CHAD_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CHAD_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CHAD_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CHAD_CALLING_CODE, country.CallingCode);
        }
    }
}
