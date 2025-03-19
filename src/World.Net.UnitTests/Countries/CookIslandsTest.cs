namespace World.Net.UnitTests.Countries
{
    public sealed class CookIslandsTest
    {
        private const string COOKISLANDS_NAME = "Cook Islands";
        private const string COOKISLANDS_OFFICIAL_NAME = "Cook Islands";
        private const string COOKISLANDS_NATIVE_NAME = "Cook Islands";
        private const string COOKISLANDS_CAPITAL = "Avarua";
        private const int COOKISLANDS_NUMERIC_CODE = 184;
        private const string COOKISLANDS_ISO2_CODE = "CK";
        private const string COOKISLANDS_ISO3_CODE = "COK";
        private const string COOKISLANDS_CALLING_CODE = "+682";


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCookIslands()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.CookIslands;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(COOKISLANDS_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Empty(country.States);
            Assert.Equal(COOKISLANDS_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(COOKISLANDS_NATIVE_NAME, country.NativeName);
            Assert.Equal(COOKISLANDS_CAPITAL, country.Capital);
            Assert.Equal(COOKISLANDS_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(COOKISLANDS_ISO2_CODE, country.ISO2Code);
            Assert.Equal(COOKISLANDS_ISO3_CODE, country.ISO3Code);
            Assert.Equal(COOKISLANDS_CALLING_CODE, country.CallingCode);
        }
    }
}
