namespace World.Net.UnitTests.Countries
{
    public sealed class CongoTest
    {
        private const string CONGO_NAME = "Congo";
        private const int CONGO_STATE_COUNT = 12;
        private const string CONGO_OFFICIAL_NAME = "Democratic Republic of the Congo";
        private const string CONGO_NATIVE_NAME = "République du Congo";
        private const string CONGO_CAPITAL = "Brazzaville";
        private const int CONGO_NUMERIC_CODE = 178;
        private const string CONGO_ISO2_CODE = "CG";
        private const string CONGO_ISO3_CODE = "COG";
        private const string CONGO_CALLING_CODE = "+242";


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCongo()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Congo;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CONGO_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(CONGO_STATE_COUNT, country.States.Count());
            Assert.Equal(CONGO_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CONGO_NATIVE_NAME, country.NativeName);
            Assert.Equal(CONGO_CAPITAL, country.Capital);
            Assert.Equal(CONGO_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CONGO_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CONGO_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CONGO_CALLING_CODE, country.CallingCode);
        }
    }
}
