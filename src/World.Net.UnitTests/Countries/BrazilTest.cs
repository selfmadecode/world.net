namespace World.Net.UnitTests.Countries
{
    public sealed class BrazilTest
    {
        private const string BRAZIL_NAME = "Brazil";
        private const int BRAZIL_STATE_COUNT = 27;
        private const string BRAZIL_OFFICIAL_NAME = "Federative Republic of Brazil";
        private const string BRAZIL_NATIVE_NAME = "Brasil";
        private const string BRAZIL_CAPITAL = "Brasilia";
        private const int BRAZIL_NUMERIC_CODE = 076;
        private const string BRAZIL_ISO2_CODE = "BR";
        private const string BRAZIL_ISO3_CODE = "BRA";
        private const string BRAZIL_CALLING_CODE = "+55";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_for_Brazil()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Brazil;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(BRAZIL_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(BRAZIL_STATE_COUNT, country.States.Count());
            Assert.Equal(BRAZIL_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(BRAZIL_NATIVE_NAME, country.NativeName);
            Assert.Equal(BRAZIL_CAPITAL, country.Capital);
            Assert.Equal(BRAZIL_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(BRAZIL_ISO2_CODE, country.ISO2Code);
            Assert.Equal(BRAZIL_ISO3_CODE, country.ISO3Code);
            Assert.Equal(BRAZIL_CALLING_CODE, country.CallingCode);
        }
    }
}
