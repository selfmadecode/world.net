namespace World.Net.UnitTests.Countries
{
    public sealed class ChileTest
    {
        private const string CHILE_NAME = "Chile";
        private const int CHILE_STATE_COUNT = 16;
        private const string CHILE_OFFICIAL_NAME = "Republic of Chile";
        private const string CHILE_NATIVE_NAME = "Chile";
        private const string CHILE_CAPITAL = "Santiago";
        private const int CHILE_NUMERIC_CODE = 152;
        private const string CHILE_ISO2_CODE = "CL";
        private const string CHILE_ISO3_CODE = "CHL";
        private const string CHILE_CALLING_CODE = "+56";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForChile()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Chile;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CHILE_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(CHILE_STATE_COUNT, country.States.Count());
            Assert.Equal(CHILE_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CHILE_NATIVE_NAME, country.NativeName);
            Assert.Equal(CHILE_CAPITAL, country.Capital);
            Assert.Equal(CHILE_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CHILE_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CHILE_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CHILE_CALLING_CODE, country.CallingCode);
        }
    }
}
